using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Security
{
    public class Sequence
    {
        public static string Encode(List<string> list) 
        {
            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                result += list.ElementAt(i) + ";";
            }

            return result;
        }

        public static List<string> Decode(string seq) 
        {
            string[] div = seq.Split(';');
            var result = new List<string>();

            for (int i = 0; i < div.Length; i++)
                result.Add($"{div[i]}");

            return result;
        }
    }
}
