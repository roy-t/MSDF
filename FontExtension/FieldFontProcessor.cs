using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kaitai;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace FontExtension
{
    
    [ContentProcessor(DisplayName = "Field Font Processor")]
    public class FieldFontProcessor : ContentProcessor<FontDescription, FieldFont>
    {        
        [DisplayName("msdfgen path")]
        [Description("Path to the msdfgen binary used to generate the multi-spectrum signed distance field")]
        [DefaultValue("msdfgen.exe")]
        public virtual string ExternalPath { get; set; } = "msdfgen.exe";


        [DisplayName("resolution")]
        [Description("Resolution of the the texture to store a single glyph in")]
        [DefaultValue(32)]
        public virtual uint Resolution { get; set; } = 32;

        [DisplayName("range")]
        [Description("Distance field range, in pixels in the output texture")]
        [DefaultValue(4)]
        public virtual uint Range { get; set; } = 4;


        public override FieldFont Process(FontDescription input, ContentProcessorContext context)
        {
            var msdfgen = Path.Combine(Directory.GetCurrentDirectory(), this.ExternalPath);
            var objPath = Path.Combine(Directory.GetCurrentDirectory(), "obj");

            if (File.Exists(msdfgen))
            {
                var glyphs = new FieldGlyph[input.Characters.Count];

                Process('p', input, msdfgen, objPath);

                Parallel.For(
                    0,
                    input.Characters.Count,
                    i =>
                    {
                        var c = input.Characters[i];
                        glyphs[i] = Process(c, input, msdfgen, objPath);                                               
                    });

                var kerning = ReadKerningInformation(input.Path);
                
                // TODO: filter unneeded kerning pairs
                return new FieldFont(input.Path, glyphs, kerning, this.Range);
            }

            throw new FileNotFoundException(
                "Could not find path to msdfgen.exe, check your processor parameters",
                msdfgen);
        }

        private FieldGlyph Process(char c, FontDescription input, string msdfgen, string objPath)
        {            
            var metrics = ProcessCharacter(input, msdfgen, objPath, c);
            var path = GetOuputPath(objPath, input, c);
            var bytes = File.ReadAllBytes(path);
            var glyph = new FieldGlyph(c, bytes, metrics);

            return glyph;
        }    

        private Metrics ProcessCharacter(FontDescription font, string msdfgen, string objPath, char c)
        {
            var outputPath = GetOuputPath(objPath, font, c);
            var startInfo = new ProcessStartInfo(msdfgen)
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = $"-font \"{font.Path}\" {(int)c} -o \"{outputPath}\" -size {this.Resolution} {this.Resolution} -pxrange {this.Range} -autoframe -printmetrics"                
            };
          
            var process = System.Diagnostics.Process.Start(startInfo);
            if (process == null)
            {
                throw new InvalidOperationException("Could not start msdfgen.exe");
            }

            var output = process.StandardOutput.ReadToEnd();
            return ParseOutput(output);            
        }

        private static Metrics ParseOutput(string output)
        {
            var advance = 0.0f;
            var scale = 0.0f;
            var translation = Vector2.Zero;

            foreach (var line in output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                ParseLine(line, "advance = ", float.Parse, ref advance);
                ParseLine(line, "scale = ", float.Parse, ref scale);
                ParseLine(line, "translate = ", ParseVector2, ref translation);
            }

            return new Metrics(advance, scale, translation);
        }

        private static string GetOuputPath(string objPath, FontDescription font, char c)
        {
            var name = Path.GetFileNameWithoutExtension(font.Path);
            return Path.Combine(objPath, $"{name}-{(int)c}.bmp");
        }

        private static Vector2 ParseVector2(string text)
        {
            var args = text.Split(',');
            return new Vector2(float.Parse(args[0]), float.Parse(args[1]));
        }
        
        private static void ParseLine<T>(string line, string match, Func<string ,T> resultParser, ref T result)
        {
            if (line.StartsWith(match, StringComparison.InvariantCultureIgnoreCase))
            {
                var value = line.Substring(match.Length).Trim();
                result = resultParser(value);                
            }            
        }

        private static List<KerningPair> ReadKerningInformation(string path)
        {
            // TODO:
            // 1. read the correct subtable, there can be more than one, it should be the horizontal one
            // maybe there are multiple horizontal ones... if the font has a normal and a bold/italic version in
            // the same file?? (Seems not, though that might be on a per glyph basis).
            // 2. Find the glyph ids for the characters since the kerning pairs are glyph ids
            // See: http://scripts.sil.org/cms/scripts/page.php?site_id=nrsi&id=iws-chapter08
            // 3. Compute how much pixels the advance is based on the units_per_em (in HEAD subtable)
            // since the KERN table lists FUNITS, we might be able to do 'HACK' something with finding 
            // the width of a glyph in funits, then the actual width of it according to msdfgen and then
            // use that to calculate the conversion to the kerning.
            // See also: https://docs.microsoft.com/en-us/typography/opentype/spec/ttch01
            


            var pairs = new List<KerningPair>();

            var ttf = Ttf.FromFile(path);

            var table = ttf.DirectoryTable.FirstOrDefault(
                x => string.Equals(x.Tag, "KERN", StringComparison.InvariantCultureIgnoreCase));

            var kerningTable = table?.Value as Kern;
            
            // TODO: match the subtable to the subtable for the font, if the font contains multiple variations
            var subTable = kerningTable?.Subtables.FirstOrDefault();
            if (subTable?.Format0 != null)
            {
                foreach (var pair in subTable.Format0.KerningPairs)
                {
                    var kern = new KerningPair((char) pair.Left, (char) pair.Right, pair.Value);
                    pairs.Add(kern);
                }
            }

            return pairs;
        }
    }   
}