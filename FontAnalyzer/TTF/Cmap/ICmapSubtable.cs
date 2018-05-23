namespace FontAnalyzer.TTF.Cmap
{
    public interface ICmapSubtable
    {
        ushort GetGlyphIndex(char c);
    }
}
