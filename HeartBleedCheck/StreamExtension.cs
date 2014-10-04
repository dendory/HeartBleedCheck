using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace HeartBleedCheck
{
    public static class StreamExtension
    {
        public static byte[] Read(this Stream sourceStream, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];

            int len = sourceStream.Read(buffer, 0, bufferSize);

            Array.Resize(ref buffer, len);

            return buffer;
        }

        public static byte[] ReadAll(this Stream stream)
        {
            var chunkSize = 0x100;
            IEnumerable<byte> buffer = new byte[0];
            var tmp = new byte[0];

            do
            {
                tmp = stream.Read(chunkSize);
                buffer = buffer.Concat(tmp);
            } while (tmp.Length == chunkSize);

            return buffer.ToArray();
        }

        public static void Write(this Stream destinationStream, byte[] buffer)
        {
            destinationStream.Write(buffer, 0, buffer.Length);
        }
    }
}
