using backend.Models;
using Microsoft.SemanticKernel.Text;
using TiktokenSharp;

namespace backend.Services;
public class SplitBySkSplitter : ITextSplitter<SKSplitter>
{
    private const string EncodingName = "cl100k_base";
    readonly static TikToken tikToken = TikToken.GetEncoding(EncodingName);

    static List<string> Chunk(string content, int? maxTokensPerLine, int? maxTokensPerParagraph, int? overlapTokens = 256)
    {
        var lines = TextChunker.SplitPlainTextLines(content, maxTokensPerLine ?? 512);
        return TextChunker.SplitPlainTextParagraphs(lines, maxTokensPerParagraph ?? 1024, overlapTokens ?? 256);
    }
    public List<ChunkInfo>? ChunkText(string text, int? maxTokensPerLine, int? maxTokensPerParagraph, int? overlapTokens = 256)
    {
        if (string.IsNullOrEmpty(text))
        {
            return null;
        }

        List<ChunkInfo> chunksInfo = new();
        var chunks = Chunk(text, maxTokensPerLine, maxTokensPerParagraph, overlapTokens);

        foreach (var chunk in chunks)
        {
            chunksInfo.Add(new ChunkInfo(chunk, tikToken.Encode(chunk).Count));
        }

        return chunksInfo;
    }
}