using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
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

        public override FieldFont Process(FontDescription input, ContentProcessorContext context)
        {
            var msdfgen = Path.Combine(Directory.GetCurrentDirectory(), this.ExternalPath);
            var objPath = Path.Combine(Directory.GetCurrentDirectory(), "obj");

            if (File.Exists(msdfgen))
            {
                var glyphs = new FieldGlyph[input.Characters.Count];

                Parallel.For(
                    0,
                    input.Characters.Count,
                    i =>
                    {
                        var c = input.Characters[i];
                        var output = ProcessCharacter(input, msdfgen, objPath, c);
                        var bytes = File.ReadAllBytes(output);
                        glyphs[i] = new FieldGlyph(c, bytes);
                    });

                return new FieldFont(input.Path, glyphs);
            }

            throw new FileNotFoundException(
                "Could not find path to msdfgen.exe, check your processor parameters",
                msdfgen);
        }

        private static string ProcessCharacter(FontDescription font, string msdfgen, string objPath, char c)
        {
            var outputPath = GetOuputPath(objPath, font, c);
            var startInfo = new ProcessStartInfo(msdfgen)
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = $"-font \"{font.Path}\" {(int)c} -o \"{outputPath}\" -size {font.Size} {font.Size} -translate 0 8"
            };
          
            var process = System.Diagnostics.Process.Start(startInfo);
            if (process == null)
            {
                throw new InvalidOperationException("Could not start msdfgen.exe");
            }

            var output = process.StandardOutput.ReadToEnd();
            if (!string.IsNullOrEmpty(output))
            {
                throw new InvalidOperationException(startInfo.Arguments + " threw" + output);
            }

            return outputPath;
        }       

        private static string GetOuputPath(string objPath, FontDescription font, char c)
        {
            var name = Path.GetFileNameWithoutExtension(font.Path);
            return Path.Combine(objPath, $"{name}-{(int)c}.bmp");
        }
    }
}