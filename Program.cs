// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace Foluwa
{
    class Programs
    {
        static void Main(string []args)
        {
            Console.WriteLine("Hello Student");
            //Grading assignment
            Console.WriteLine("A program to grade your scores \n Scores should be between the range of 0-100");
            Console.WriteLine("Input your name below");
            Console.ReadLine();
            Console.WriteLine("Input score");
            int p = Convert.ToInt32(Console.ReadLine());
            if ((p >=0) && (p <=39))
            Console.WriteLine("Your Grade is \n F");
            if ((p >=40) && (p <=44))
            Console.WriteLine("Your Grade is \n E");
            if ((p >=45) && (p <=49))
            Console.WriteLine("Your Grade is \n D");
            if ((p >=50) && (p <=59))
            Console.WriteLine("Your Grade is \n C");
            if ((p >=60) && (p <= 69))
            Console.WriteLine("Your Grade is \n B");
            if ((p >=70) && (p <=100))
            Console.WriteLine("Your Grade is \n A");




        }
    }
}
   