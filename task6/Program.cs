int a = 0;

Console.WriteLine ("Введите число ");
string userEnterA = Console.ReadLine();
a = int.Parse(userEnterA);

        if (a % 2 == 0)
        {
        Console.WriteLine("Число четное");
        }
        else 
        {
        Console.WriteLine("Число нечетное");
        }