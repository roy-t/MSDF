using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FontAnalyzer.TTF
{   
    public sealed class FontReader : BinaryReader
    {
        public FontReader(Stream stream)
            : base(stream) { }

        public long Position => this.BaseStream.Position;

        public short ReadInt16BigEndian()
        {
            var bytes = ReadBigEndian(2);
            return BitConverter.ToInt16(bytes, 0);
        }        

        public int ReadInt32BigEndian()
        {
            var bytes = ReadBigEndian(4);
            return BitConverter.ToInt32(bytes, 0);
        }

        public long ReadInt64BigEndian()
        {
            var bytes = ReadBigEndian(8);
            return BitConverter.ToInt64(bytes, 0);
        }

        public ushort ReadUInt16BigEndian()
        {
            var bytes = ReadBigEndian(2);
            return BitConverter.ToUInt16(bytes, 0);
        }       

        public uint ReadUInt32BigEndian()
        {
            var bytes = ReadBigEndian(4);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public ulong ReadUInt64BigEndian()
        {
            var bytes = ReadBigEndian(8);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public string ReadAscii(int length)
        {            
            var bytes = this.ReadBytes(length);
            return new string(bytes.Select(b => (char) b).ToArray(), 0, length).Replace("\0", string.Empty);
        }

        public string ReadBigEndianUnicode(int length)
        {
            var bytes = ReadBytes(length);
            return Encoding.BigEndianUnicode.GetString(bytes).Replace("\0", string.Empty);
        }

        public string ReadUTF8(int length)
        {
            var bytes = ReadBytes(length);
            return Encoding.UTF8.GetString(bytes).Replace("\0", string.Empty);
        }        


        /// <summary>
        /// Reads a 32 bit signed fixed point number (16.16)        
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        public void ReadFixedBigEndian(out short major, out short minor)
        {            
            major = ReadInt16BigEndian();
            minor = ReadInt16BigEndian();
        }

        private byte[] ReadBigEndian(int count)
        {
            var data = base.ReadBytes(count);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(data);
            }

            return data;
        }

        public void Seek(long offset)
        {            
            this.BaseStream.Seek(offset, SeekOrigin.Begin);
        }        
    }
}
