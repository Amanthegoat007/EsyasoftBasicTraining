using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    // OBIS (Object Identification System) class
    public class ObisCode
    {
        public byte[] Code { get; set; }

        public ObisCode(byte a, byte b, byte c, byte d, byte e, byte f)
        {
            Code = new byte[] { a, b, c, d, e, f };
        }

        public bool Match(ObisCode other)
        {
            if (other == null || other.Code.Length != Code.Length)
                return false;

            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i] != other.Code[i])
                    return false;
            }
            return true;
        }
    }