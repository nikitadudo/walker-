using System;

namespace Calculate
{
    class Operation
    {
        public virtual int DoSomeWork(int a, int b)
        {
            return 69;
        }
    }
    class Plus : Operation
    {
        public override int DoSomeWork(int a, int b)
        {
            return a + b;
        }
    }
    class Minus : Operation
    {
        public override int DoSomeWork(int a, int b)
        {
            return a - b;
        }
    }
    sealed class Multyply : Operation
    {
        public override int DoSomeWork(int a, int b)
        {
            return a * b;
        }
    }
    sealed class Divide : Operation
    {
        public override int DoSomeWork(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int i = Int32.Parse(Console.ReadLine());
            Console.Write("Введите знак: ");
            char c = Char.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int z = Int32.Parse(Console.ReadLine());
            Console.Write("Результат: ");
            switch (c)
            {
                case '+':
                    Plus plus = new Plus();
                    Console.WriteLine(plus.DoSomeWork(i, z));
                    break;
                case '-':
                    Minus minus = new Minus();
                    Console.WriteLine(minus.DoSomeWork(i, z));
                    break;
                case '*':
                    Multyply multyply = new Multyply();
                    Console.WriteLine(multyply.DoSomeWork(i, z));
                    break;
                case '/':
                    Divide divide = new Divide();
                    Console.WriteLine(divide.DoSomeWork(i, z));
                    break;
            }
        }


    }
}