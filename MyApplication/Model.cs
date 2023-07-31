using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgramm
{
    public class Model
    {
        private int calculation;

        public void Calculate(int a, int b)
        {
            calculation = a + b;
        }

        public int Calculation { get => calculation; }
    }
}
