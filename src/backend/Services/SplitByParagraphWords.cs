using backend.Models;

namespace backend.Services;
public class SplitByParagraphWords : ITextSplitter<ParagraphWordsSplitter>
{
    public List<ChunkInfo>? ChunkText(string text, int? maxTokensPerLine, int? maxTokensPerParagraph, int? overlapTokens)
    {
        if (string.IsNullOrEmpty(text))
        {
            return null;
        }

        var paragraphs = text.Split("\n\n");
        if (paragraphs.Length == 1)
        {
            paragraphs = text.Split("\r");
        }

        List<ChunkInfo> chunksInfo = new();
        foreach (var paragraph in paragraphs)
        {
            if (!string.IsNullOrEmpty(paragraph))
                chunksInfo.Add(new ChunkInfo(paragraph, paragraph.Split(" ").Length));
        }

        return chunksInfo;
    }
}