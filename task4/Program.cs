  int max = 0;
  int b = 0;
  int c = 0;

Console.WriteLine ("Введите число a");
string userEnterA = Console.ReadLine();
max = int.Parse(userEnterA);

Console.WriteLine ("Введите число b");
string userEnterB = Console.ReadLine();
b = int.Parse(userEnterB);

Console.WriteLine ("Введите число c");
string userEnterC = Console.ReadLine();
c = int.Parse(userEnterC);

        if (b > max)
        {
        max = b;
        }
        if (c > max)
        {
         max = c;
        }

            Console.WriteLine("Максимальное число ");
            Console.WriteLine(max);