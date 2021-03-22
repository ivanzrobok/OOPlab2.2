using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab2._2
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 2);
            Matrix matrix1 = new Matrix(2, 3);
            matrix.InputMatrix();
            matrix1.InputMatrix();

            Console.WriteLine("Множення матриць ");
            matrix *= matrix1;
            matrix.DisplayMatrix();

            Console.WriteLine("Додавання матриць ");
            matrix += matrix1;
            matrix.DisplayMatrix();
        }
    }
}
