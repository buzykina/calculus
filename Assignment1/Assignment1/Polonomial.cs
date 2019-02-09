using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Polonomial
    {
        public Row firstRow { get; private set; }
        private int numberRows;
        public Polonomial()
        {
            this.firstRow = null;
        }
        public Term First(int number, int x, int y)
        {
            Term first = null;
            Term temp = null;
            for (int j = 1; j <= number; j++)
            {
                if (j == 1)
                {
                    first = new Term(Math.Pow((double)x, (double)number - j));
                    temp = first;
                }
                else
                { 
                    temp.nextTerm = new Term(Math.Pow((double)x, (double)number - j));
                    temp = temp.nextTerm;
                }
            }
            temp.nextTerm = new Term(y);
            return first;
        }
        public void MakesRows(int number, int x, int y)
        {
            this.numberRows = number;
            if (firstRow == null)
            {
                firstRow = new Row(this.First(number, x, y));
            }
            else
            {
                Row current = firstRow;
                while (current.nextRow != null)
                {
                    current = current.nextRow;
                }
                current.nextRow = new Row(this.First(number, x, y));
            }
        }
        private double[] CalculateCoef()
        {
            Row tempRow1;
            Row tempRow2;
            Term tempTerm1;
            double[] coef = new double[numberRows];
            for (int i = 1; i <= numberRows;i++)
            {
                tempRow1 = this.FindRow(i);
                tempTerm1 = tempRow1.firstTerm;
                double devideby = tempRow1.FindTerm(i).number;
                while(tempTerm1 != null)
                {
                    tempTerm1.number = tempTerm1.number / devideby;
                    tempTerm1 = tempTerm1.nextTerm;
                }
                for(int j = 1; j <= numberRows;j++)
                {
                    if(i != j)
                    {
                        tempRow2 = this.FindRow(j);
                        double multiply = tempRow2.FindTerm(i).number;
                        for(int x = 1; x <= numberRows + 1; x++)
                        {
                            tempRow2.FindTerm(x).number = (-tempRow1.FindTerm(x).number * multiply) + tempRow2.FindTerm(x).number;
                        }
                    }
                }
            }
            for (int i = 1; i <= numberRows; i++)
            {
                tempRow1 = this.FindRow(i);
                double c = tempRow1.FindTerm(numberRows+1).number;
                coef[i - 1] = c;
            }
            return coef;
        }
        public BinaryTree MakeBinaryTreePolonomial()
        {
            BinaryTree polonomial = new BinaryTree();
            polonomial = polonomial.MakePolonomialFunction(this.CalculateCoef());
            return polonomial;
        }
        private Row FindRow(int i)
        {
            int count = 1;
            Row temp = firstRow;
            while (count != i)
            {
                temp = temp.nextRow;
                count++;
            }
            return temp;
        }
    }
}
