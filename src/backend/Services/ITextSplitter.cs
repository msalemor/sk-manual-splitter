using backend.Models;
using TiktokenSharp;

namespace backend.Services;
public interface ITextSplitter<T>
{
    private const string EncodingName = "cl100k_base";
    List<ChunkInfo>? ChunkText(string text, int? maxTokensPerLine, int? maxTokensPerParagraph, int? overlapTokens);
    public static TikToken tikToken = TikToken.GetEncoding(EncodingName);
}

public class SKSplitter { }
public class ParagraphSplitter { }
public class ParagraphWordsSplitter { }

public enum SplitterType
{
    SK,
    Paragraph,
    ParagraphWords
}
