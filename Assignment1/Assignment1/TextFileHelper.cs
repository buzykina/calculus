using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TextFileHelper
    {
        //public BinaryTree tree;
        public string text;
        public TextFileHelper()
        {
            //this.tree = new BinaryTree();
        }
        public void savingFile(List<string> list)
        {
            text = "";
            FileStream fs = null;
            fs = new FileStream("abc.dot", FileMode.Truncate,FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("graph calculus {");
                text += "graph calculus {";
                sw.WriteLine("   node [ fontname = \"Arial\" ]");
                text += $"{Environment.NewLine}   node [ fontname = \"Arial\" ]";
                foreach (string s in list)
                {
                    sw.WriteLine(s);
                    text += $"{Environment.NewLine}{s}";
                }
                sw.WriteLine("}");
                text += $"{Environment.NewLine}" +"}";
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
