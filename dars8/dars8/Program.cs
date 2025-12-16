namespace dars8;

internal class Program
{
    static List<string> Names = new List<string>();

    static void Main(string[] args)
    {
        //while (true)
        //{
        //    Console.WriteLine("1. Create");
        //    Console.WriteLine("2. Delete");
        //    Console.WriteLine("3. Update");
        //    Console.WriteLine("4. Read");

        //    Console.Write("Tanlang : ");
        //    int.TryParse(Console.ReadLine(), out int c);

        //    if (c == 1)
        //    {
        //        Console.Write("Ismni kiriting : ");
        //        string name = Console.ReadLine();
        //        CreateName(name);
        //    }
        //    else if (c == 2)
        //    {
        //        Console.Write("Ismni o'chiring : ");
        //        string name = Console.ReadLine();
        //        DeleteName(name);
        //    }
        //    else if (c == 3)
        //    {
        //        Console.Write("Eski ismni kiriting : ");
        //        string oldName = Console.ReadLine();

        //        Console.Write("Yangi ismni kiriting : ");
        //        string newName = Console.ReadLine();

        //        UpdateName(oldName, newName);
        //    }
        //    else if (c == 4)
        //    {
        //        ReadNames();
        //    }

        //    Console.ReadKey();
        //    Console.Clear();


        List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 510, 21 };

        //Console.WriteLine(TheThereDigitCount(list));             1-chi mashq

        //Console.WriteLine(JuftElement(list));                    2-chi mashq

        //Console.WriteLine(ToqElement(list));                     3-chi mashq

        //Console.WriteLine(ThereAndSevenElement(list));           4-chi mashq

        Console.WriteLine(JuftXonaliToqElement(list));            //5 -chi mashq

    }













    static int JuftXonaliToqElement(List<int> ints)
    {
        var count = 0;
        foreach (var x in ints)
        {
            if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99)
            {
                count++;
            }
        }
        return count;
    }


    //static int ThereAndSevenElement(List<int> ints)
    //{
    //    var count = 0;
    //    foreach (var x in ints)
    //    {
    //        if (x % 3 == 0 && x % 7 == 0)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}


    //static int ToqElement(List<int> ints)
    //{
    //    var count = 0;
    //    foreach (var x in ints)
    //    {
    //        if (x % 2 != 0)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}


    //static int JuftElement(List<int> ints)
    //{
    //    var count = 0;
    //    foreach (var x in ints)
    //    {
    //        if (x % 2 ==0 )
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}

    //static int TheThereDigitCount(List<int> list)
    //{
    //    int counter = 0;
    //    foreach (int x in list)
    //    {
    //        if (Math.Abs(x) >= 100 && Math.Abs(x) <= 999)
    //        {
    //            counter++;
    //        }
    //    }
    //    return counter;
    //}

    //static void CreateName(string name)
    //{
    //    if (!string.IsNullOrWhiteSpace(name))
    //        Names.Add(name);
    //}

    //static void DeleteName(string name)
    //{
    //    Names.Remove(name);
    //}

    //static void UpdateName(string oldName, string newName)
    //{
    //    int index = Names.IndexOf(oldName);
    //    if (index != -1)
    //    {
    //        Names[index] = newName;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Bunday ism topilmadi!");
    //    }
    //}

    //static void ReadNames()
    //{
    //    foreach (var name in Names)
    //    {
    //        Console.WriteLine(name);
    //    }
    //}
}
