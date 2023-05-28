using System.Text;
using System.Text.RegularExpressions;

namespace Translator_3000
{
    internal class Translator : Form1
    {
        public string? Output { get; private set; }

        public string Encode(string text)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(text);

            foreach (byte b in byteArray)
            {
                string output;

                output = Convert.ToString(b, 2)
                                .PadLeft(8, '0')
                                .Replace("0", "A")
                                .Replace("1", "Г");

                Output += output;
            }
            return Output;
        }

        public string Decode(string input)
        {
            input = input.Replace("A", "0").Replace("Г", "1");

            string output = Encoding.UTF8.GetString(
                Regex.Split(input, "(.{8})")
                     .Where(binary => !String.IsNullOrEmpty(binary))
                     .Select(binary => Convert.ToByte(binary, 2))
                     .ToArray());

            return output;
        }

    }
}