﻿using System.IO;
using System.IO.Compression;

namespace CompatApiClient.Compression
{
    public class DeflateCompressor : Compressor
    {
        public override string EncodingType => "deflate";

        public override Stream CreateCompressionStream(Stream output)
        {
            return new DeflateStream(output, CompressionMode.Compress, true);
        }

        public override Stream CreateDecompressionStream(Stream input)
        {
            return new DeflateStream(input, CompressionMode.Decompress, true);
        }
    }
}