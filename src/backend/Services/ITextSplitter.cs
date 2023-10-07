using backend.Models;

namespace backend.Services;
public interface ITextSplitter<T>
{
    List<ChunkInfo>? ChunkText(string text, int? maxTokensPerLine, int? maxTokensPerParagraph, int? overlapTokens);
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
