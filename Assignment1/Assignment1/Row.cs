using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Row
    {
        public Row nextRow { get; set; }
        public Term firstTerm { get; private set; }
        public Row(Term first)
        {
            this.firstTerm = first;
        }
        public Term FindTerm(int i)
        {
            int count = 1;
            Term temp = firstTerm;
            while(count != i)
            {
                temp = temp.nextTerm;
                count++;
            }
            return temp;
        }

    }
}
