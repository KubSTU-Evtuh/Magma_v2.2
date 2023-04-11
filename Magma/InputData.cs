using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Magma
{
    internal static class InputData
    {
        private static Data instance = new Data(string.Empty, string.Empty);

        public static void SetInstance(Data data)
        {
            instance = data;
        }

        public static Data GetInstance()
        {
            return instance;
        }

        public static string GetA0PlusK0()
        {
            long a0 = Convert.ToInt64(ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(4, 4)), 2);
            long k0 = Convert.ToInt64(ByteConverter.GetByteCode(InputData.GetInstance().Key.Substring(0, 4)), 2);
            return Convert.ToString(Convert.ToInt64((a0 + k0) % Math.Pow(2, 32)), 2);
        }

        public static string GetN0()
        {
            string a0k0 = GetA0PlusK0();
            string n0 = string.Empty;
            for (int i = 0, blockNumber = 0; i < a0k0.Length; i += 4, blockNumber++)
            {
                n0 += FormatBinaryString(Convert.ToString(new PermutationTable().Permuate(Convert.ToInt32(a0k0.Substring(i, 4), 2), 7 - blockNumber), 2));
            }
            return n0;
        }

        private static string FormatBinaryString(string input)
        {
            switch (input.Length)
            {
                case 0:
                    return "0000" + input;
                case 1:
                    return "000" + input;
                case 2:
                    return "00" + input;
                case 3:
                    return "0" + input;
                default:
                    return input.Substring(0, 4);
            }
        }

        public static string GetN0Shifted()
        {
            char[] binaryCode = GetN0().ToCharArray();
            char[] shiftElements = binaryCode.Take(11).Reverse().ToArray();
            for (int i = 0; i < binaryCode.Length - 1; i++)
                binaryCode[i] = binaryCode[i + 1];
            binaryCode = binaryCode.Reverse().ToArray();
            for (int i = 0; i < shiftElements.Length; i++)
                binaryCode[i] = shiftElements[i];
            binaryCode = binaryCode.Reverse().ToArray();
            int index = 0;
            string result = Convert.ToString(binaryCode.Reverse().Select(x => (int)(int.Parse(x.ToString()) * Math.Pow(2, index++))).Sum(), 2).PadLeft(32, '0');
            return result;
        }

        public static string GetN0XORL0()
        {
            int n0 = Convert.ToInt32(GetN0Shifted(), 2);
            int l0 = Convert.ToInt32(ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(0, 4)), 2);
            return Convert.ToString(l0 ^ n0, 2);
        }

        public class Data
        {
            readonly public string Message;
            readonly public string Key;

            public Data(string message, string key)
            {
                this.Message = message;
                this.Key = key;
            }
        }
    }
}
