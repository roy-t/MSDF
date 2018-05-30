namespace FontAnalyzer.TTF.Cmap
{
    public interface ICmapSubtable
    {
        uint GetGlyphIndex(char c);
    }
}
