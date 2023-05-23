int programm;
Boolean begin = true;
while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch(programm)
    {
        case 1:
            //Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            void Sum1(int n, int count)
            {
                if (count > n) return;

                else
                {
                    Sum1(n, count + 1);
                    Console.Write(count + " ");
                }
            }
            Sum1(n, count);
        break;
        case 2:
            //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            Console.WriteLine("Введите М: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(SumNumber1(m1-1,n1));
            int SumNumber1(int m, int n)
            {
                if (m == n) 
                {
                    return m;
                }
                else
                {
                    return m + SumNumber1(m + 1, n);
                }
            }
        break;
       
      
    default:
             begin = false;
             break;
}
}