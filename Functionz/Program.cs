using System;

namespace Functions{
    
    class Program{

        public void display()
        {
            Console.WriteLine("wat is the time");
        }

        public void showMessage(string message)
        {
            Console.WriteLine("Hello, " + message);
        }

        int addNumber(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        
        public int mathFunc()
        {
            int x = 12, y = 12, sum1;
            sum1 = x + y;
            return sum1;
        }

        static void Main(string[] arg)
        {
            Program uno = new Program();
            Program seco = new Program();
            
            seco.showMessage("mambo ni vp?");

            int sum = seco.addNumber(3, 5);

            Console.WriteLine("the sum is: " + sum);

            Console.WriteLine();

            seco.mathFunc();

            Console.WriteLine("the total is: " + seco.mathFunc() );
            
            uno.display();
        }   
    }
    
}
