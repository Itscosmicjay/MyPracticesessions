using System;
using System.Collections.Generic;
using System.Text;

namespace MyPracticesessions
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }
    }
}
