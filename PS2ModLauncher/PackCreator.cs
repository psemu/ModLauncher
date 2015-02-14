using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MiscUtil.IO;
using MiscUtil.Conversion;

namespace PS2ModLauncher
{
    class FileHeader
    {
        public uint name_len;
        public byte[] name;
        public uint offset;
        public uint length;
        public uint crc32;

        public byte[] Encode()
        {
            EndianBinaryWriter wr = new EndianBinaryWriter(EndianBitConverter.Big, new MemoryStream());
            wr.Write(name_len);
            wr.Write(name);
            wr.Write(offset);
            wr.Write(length);
            wr.Write(crc32);

            return (wr.BaseStream as MemoryStream).ToArray();
        }
    }

    class ChunkHeader
    {
        public uint NextChunkOffset;
        public uint FileCount;
        public FileHeader[] files;

        public byte[] Encode()
        {
            EndianBinaryWriter wr = new EndianBinaryWriter(EndianBitConverter.Big, new MemoryStream());
            wr.Write(NextChunkOffset);
            wr.Write(FileCount);
            foreach (FileHeader h in files)
            {
                wr.Write(h.Encode());
            }

            return (wr.BaseStream as MemoryStream).ToArray();
        }
    }


    class PackCreator
    {
      
        public static void CreatePackFromFiles(string[] files, string savePath)
        {
            int fileCount = files.Length;

            List<FileHeader> fheader = new List<FileHeader>();
            List<byte[]> fileData = new List<byte[]>();

            //Create File Headers for each file to pack
            foreach (string file in files)
            {
                byte[] fdata = File.ReadAllBytes(file);
                fileData.Add(fdata);
                Crc32 crc = new Crc32();
                byte[] c = crc.ComputeHash(fdata);
                string filename = file.Substring(file.LastIndexOf("\\") + 1);
                FileHeader h = new FileHeader()
                {
                    name_len = (uint)filename.Length,
                    name = Encoding.ASCII.GetBytes(filename),
                    offset = 0,
                    length = (uint)fdata.Length,
                    crc32 = (uint)BitConverter.ToInt32(c, 0),
                };
                fheader.Add(h);
            }

            //Create a chunk header for the pack file
            ChunkHeader header = new ChunkHeader()
            {
                NextChunkOffset = 0,
                FileCount = (uint)fileCount,
                files = fheader.ToArray(),
            };

            //Update the files with the offset of each data chunk of the file
            int length = header.Encode().Length;
            int offset = 0;
            for (int i = 0; i < fheader.Count; i++)
            {
                if (i != 0) offset += fileData[i - 1].Length;
                fheader[i].offset = (uint)length + (uint)offset;
            }
            //Write the chunk to a file
            using (EndianBinaryWriter wr = new EndianBinaryWriter(EndianBitConverter.Big, File.Open(savePath, FileMode.OpenOrCreate)))
            {
                byte[] ph = header.Encode();
                wr.Write(ph);
                for (int i = 0; i < fileData.Count; i++)
                {
                    wr.Write(fileData[i]);
                }
            }
            
        }
    }
}
