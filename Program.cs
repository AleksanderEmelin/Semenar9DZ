internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        
        void Recursion64(int counter, int number)
        {
            // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные 
            //числа кратные 3-ём в промежутке от M до N.
            if (counter > number) return;         
            {
                if (counter % 3 == 0) Console.Write(counter + " ");
            }
            counter++;
            Recursion64(counter, number); 
        }
        Recursion64(1, 20); 

        void Task66()
        {
            //   Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
            int counter = Input("Введите первое число: ");
            int number = Input("Введите второе число: ");
            int sum = 0;

            while (counter <= number)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine("Сумма равна " + sum);
        }
        //Task66();

        void Recursion66(int counter, int number, int sum = 0)
        {
            if (counter > number) return;
            sum += counter;
            counter++;
            Console.WriteLine("Сумма равна " +sum);
            Recursion66(counter, number);
        }
        //Recursion66(1, 3);

    
        
        void Recursion68()
        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 3, n = 2 -> A(m,n) = 2
        {            
            int m = Input("Введите число m: ");
            int n = Input("Введите число n: ");
            AkkermanFunction(m,n);
            void AkkermanFunction(int m, int n)
            {
                Console.Write(Akkerman(m, n)); 
            }
            int Akkerman(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }
                else if (n == 0 && m > 0)
                {
                    return Akkerman(m - 1, 1);
                }
                else
                {
                    return (Akkerman(m - 1, Akkerman(m, n - 1)));
                }
            }
        }
        //Recursion68();
        
    }
}