  int a = 0;
  int b = 0;

Console.WriteLine ("Введите число a");
string userEnterA = Console.ReadLine();
a = int.Parse(userEnterA);

Console.WriteLine ("Введите число b");
string userEnterB = Console.ReadLine();
b = int.Parse(userEnterB);

        if (a > b)
        {
            Console.WriteLine("Максимальное число ");
            Console.WriteLine(a);
        }
        else
        {
            Console.Write("Максимальное число ");
            Console.WriteLine(b);
        }
