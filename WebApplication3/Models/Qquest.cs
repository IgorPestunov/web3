using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Qquest
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int answer { get; set; }
        public int Correctanswer { get; set; }
        public string oper { get; set; }  // + или -
        public void count()
        {
            switch (oper)
            {
                case "+":
                    Correctanswer = number1 + number2;
                    break;
                case "-":
                    Correctanswer = number1 - number2;
                    break;
            }
            
        }



    }
}
