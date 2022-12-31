using System;
using System.IO;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (FileStream bytes = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] bytesBuffer = new byte[bytesFilePath.Length];
                    bytes.Read(bytesBuffer, 0, bytesFilePath.Length);
                    byte[] imageBuffer = new byte[image.Length];
                    image.Read(imageBuffer, 0, imageBuffer.Length);
                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        for(int i = 0; i < imageBuffer.Length; i++)
                        {
                            for(int b = 0; b < bytesBuffer.Length; b++)
                            {
                                if(imageBuffer[i] == bytesBuffer[b])
                                {
                                    output.Write(new byte[] { bytesBuffer[b] });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
