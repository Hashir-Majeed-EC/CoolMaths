using System;

namespace CoolMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(QuadraticFormula(1, 2, 1));
        }

        static int solutions(double a, double b, double c)
        {
            int numSolutions = 1;
            double discriminant = b*b - 4 * a * c;

            if (discriminant > 0)
            {
                numSolutions = 2;
            }

            if (discriminant < 0)
            {
                numSolutions = 0;
            }

            return numSolutions;
        }

        static string QuadraticFormula(double a, double b, double c)
        {
            string answer = "";

            if (solutions(a,b,c) == 2)
            {
                answer += Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)) + " , " + Convert.ToString((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
            }else if (solutions(a, b, c) == 1)
            {
                answer += Convert.ToString(-b / (2 * a));
            }
            else
            {
                answer += "No Solutions";
            }    

            return answer;
        }

        static int Factorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
