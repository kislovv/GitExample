using System.Text;

namespace Streams;

public class SuperFireReader : StreamReader
{

    public SuperFireReader(Stream stream) : base(stream)
    {
    }

    public SuperFireReader(Stream stream, bool detectEncodingFromByteOrderMarks) : base(stream, detectEncodingFromByteOrderMarks)
    {
    }

    public SuperFireReader(Stream stream, Encoding encoding) : base(stream, encoding)
    {
    }

    public SuperFireReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) : base(stream, encoding, detectEncodingFromByteOrderMarks)
    {
    }

    public SuperFireReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : base(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize)
    {
    }

    public SuperFireReader(Stream stream, Encoding? encoding = null, bool detectEncodingFromByteOrderMarks = true, int bufferSize = -1, bool leaveOpen = false) : base(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen)
    {
    }

    public SuperFireReader(string path) : base(path)
    {
    }

    public SuperFireReader(string path, bool detectEncodingFromByteOrderMarks) : base(path, detectEncodingFromByteOrderMarks)
    {
    }

    public SuperFireReader(string path, FileStreamOptions options) : base(path, options)
    {
    }

    public SuperFireReader(string path, Encoding encoding) : base(path, encoding)
    {
    }

    public SuperFireReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) : base(path, encoding, detectEncodingFromByteOrderMarks)
    {
    }

    public SuperFireReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : base(path, encoding, detectEncodingFromByteOrderMarks, bufferSize)
    {
    }

    public SuperFireReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, FileStreamOptions options) : base(path, encoding, detectEncodingFromByteOrderMarks, options)
    {
    }

    public void ShowAllFileData(string inputPath)
    {
        foreach (string line in ReadToEnd().Split('\n'))
        {
            Console.WriteLine(line);
        }
    }

    protected override void Dispose(bool disposing)
    {
        
        base.Dispose(disposing);
    }
}