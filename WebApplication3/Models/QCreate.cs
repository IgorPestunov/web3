using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class QCreate
    {
        Random rnd = new Random();
        public int num1 { get; set; }
        public int num2 { get; set; }
        public List<Qquest> Expressions { get; set; } = new List<Qquest>();
        public string operat { get; set; }
        public void Generate()
        {
            
            num1 = rnd.Next(0, 10);
            num2 = rnd.Next(0, 10);
            int whatoperator = rnd.Next(0, 10);
            if (whatoperator >= 5) operat = "+";
            else operat = "-";
        }


    }
}
