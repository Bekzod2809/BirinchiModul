namespace dars3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR
            //for (int i = 100; i < 1000; i++)
            //{
            //    int yuzlik = i / 1 % 10;
            //    int onlik = i / 10 % 10;
            //    int birlik = i / 100 % 10;
            //    if (yuzlik % 2 != 0 && onlik % 2 != 0 && birlik % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //UYGA VAZIFA
            //1.3.1-oson-1
            //for (int i = 1; i <=20; i++)
            //{
            //    Console.Write($"{i},");
            //}

            //1.3.1-soson-2
            //for (int i = 25; i <=100;  i++)
            //{
            //    Console.Write($" {i} ,");
            //}

            //1.3.1-oson-3
            //for (int i = 12; i <= 200; i++)
            //{
            //    Console.Write($" {i}, ");
            //}

            //1.3.1-oson-4
            //for (int i = 15; i >= 2; i--)
            //{
            //    Console.Write(i);
            //}

            //1.3.1-oson-5
            //for (int i = 120; i >= 23; i--)
            //{
            //    Console.Write($" {i}, ");
            //}

            //1.3.1-oson-6
            //for (int i = 10; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write($" {i}, ");
            //    }
            //}

            //1.3.1-oson-7
            //for (int i = 120; i <= 250; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i},");
            //    }
            //}

            //1.3.1-oson-8
            //for (int i = 100; i >= 50; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write($" {i}, ");
            //    }
            //}

            //1.3.1-oson-9
            //for (int i = 80; i >= 20; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($" {i}, ");
            //    }
            //}

            //1.3.1-oson-10
            //Console.Write(" a sonini kiriting");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.Write(" a sonidan kattaroq b sonini kiriting");
            //var num2 = int.Parse(Console.ReadLine());
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.1-oson-11
            //Console.Write("a sonini kiritng :");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.Write("a dan kattaroq b sonini kiriting :");
            //var num2 = int.Parse(Console.ReadLine());
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine($"4ga karali sonlar : {i},");
            //    }
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine($"7ga karali sonlar : {i},");
            //    }
            //}

            //1.3.1-oson-12
            //Console.Write("a sonini kiriting : ");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiriting ");
            //var num2 = int.Parse(Console.ReadLine());
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i % 8 == 0)
            //    {
            //        Console.WriteLine($"8ga karali sonlar : {i} ");
            //    }
            //}

            //1.3.1-oson-13
            //var overall = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        overall += i;
            //    }
            //}
            //Console.WriteLine(overall);

            //1.3.1-qiyin-15
            //for (int i = 100; i < 1000; i++)
            //{
            //    int yuzlik = i / 100 % 10;
            //    int onlik = i / 10 % 10;
            //    int birlik = i % 10;
            //    int yigindi = yuzlik + onlik + birlik;
            //    if (yigindi > 20)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.1-qiyin-16
            //for (int i = 100; i < 1000; i++)
            //{
            //    var yuzlik = i / 100 % 10;
            //    var onlik = i / 10 % 10;
            //    var birlik = i % 10;
            //    if (yuzlik == birlik)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.1-qiyin-17
            //var natija = 0;
            //var miqdor = 0;
            //for (int i = 10; i < 100; i++)
            //{
            //    var onlik = i / 10 % 10;
            //    var birlik = i % 10;
            //    var yigindi = onlik * birlik;
            //    if (yigindi > 12)
            //    {
            //        natija += i;
            //        miqdor++;
            //    }
            //}
            //Console.WriteLine(natija);
            //Console.WriteLine(miqdor);

            //1.3.1-qiyin-18
            //for (int i = 100; i < 1000; i++)
            //{
            //    var onlar = i / 10 % 10;
            //    if (onlar == 2 || onlar == 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.1-qiyin-19
            //Console.Write("a sonini kiritng :");
            //int num = int.Parse(Console.ReadLine());
            //string yigindi = " ";
            //for (int i = 1; i <= num; i++)
            //{
            //    yigindi += num;
            //}
            //Console.WriteLine(yigindi);

            //1.3.1-qiyin-20
            //Console.Write("a sonini kiritni :");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiritng : ");
            //int num2 = int.Parse(Console.ReadLine());
            //string yigindi = " ";
            //for (int i = 1; i <= num2; i++)
            //{
            //    yigindi += num1;
            //}
            //Console.WriteLine(yigindi);

            //1.3.1-qiyin-21
            //Console.Write("a sonini kiriting : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiritng : ");
            //int num2 = int.Parse(Console.ReadLine());
            //string yigindi = " ";
            //for (int i = 1; i <= num1; i++)
            //{
            //    yigindi += num2;
            //}
            //Console.WriteLine(yigindi);

            //1.3.1-qiyin-22
            //Console.Write("a sonini kiritng :");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.1-qiyin-23
            //Console.Write("a sonini kiriting : ");
            //int num = int.Parse(Console.ReadLine());
            //int yigindi = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        yigindi += 1;
            //    }
            //}
            //Console.WriteLine(yigindi);

            //1.3.1-qiyin-24
            //Console.Write("a sonini kiritng");
            //var num = int.Parse(Console.ReadLine());
            //var yigindi = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        yigindi = yigindi + i;
            //    }
            //}
            //Console.WriteLine(yigindi);

            //1.3.1-judaQiyin-25
            //Console.Write("a sonini kiriting : ");
            //var num = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        counter++;
            //    }
            //}
            //if (counter == 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //1.3.1-judaQiyin-26
            //Console.Write("a sonini kiriting");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiriting");
            //var num2 = int.Parse(Console.ReadLine());
            //var counterNum1 = 0;
            //var counterNum2 = 0;
            //for (int i = 1; i <= num1; i++)
            //{
            //    if (num1 % i == 0)
            //    {
            //        counterNum1++;
            //    }
            //}
            //for (int j = 1; j <= num2; j++)
            //{
            //    if (num2 % j == 0)
            //    {
            //        counterNum2++;
            //    }
            //}
            //if (counterNum1 == 2 || counterNum2 == 0)
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else
            //{
            //    Console.WriteLine(num2 * num1);
            //}

            //1.3.1-judaQiyin-27
            //var kg = 7000;
            //for (int i = 3; i <= 60; i++)
            //{
            //    var natija = kg * i;
            //    Console.WriteLine($"{i} kilogram : {natija}");
            //}

            //1.3.1-judaQiyin-28
            //Console.Write("23dan katta n sonini kiriting");
            //var n = int.Parse(Console.ReadLine());
            //var counter = 0;
            //for (int i = 23; i <= n; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        counter++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Bunday sonlar soni: " + counter);

            //1.3.1-judaQiyin-29
            //    Console.Write("a sonini kiriting :");
            //    var a = int.Parse(Console.ReadLine());
            //    Console.Write("b sonini kiriting :");
            //    var b = int.Parse(Console.ReadLine());
            //    var acounter = 0;
            //    var bcounter = 0;
            //    for (int i = 1; i <= a; i++)
            //    {
            //        if (a % 2 == 0)
            //        {
            //            acounter++;
            //        }
            //    }
            //    for (int j = 1; j <= b; j++)
            //    {
            //        if (b % 2 == 0)
            //        {
            //            bcounter++;
            //        }
            //    }
            //    if (acounter > bcounter)
            //    {
            //        Console.WriteLine($" a sonini bo'luvchisi koproq");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" b sonini bo'luvchisi koproq");
            //    }

            //1.3.1-judaQiyin-30
            //Console.Write("a sonini kiriting :");
            //var a = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiriting :");
            //var b = int.Parse(Console.ReadLine());
            //var yigindi = 0;
            //for (int i = a+1; i < b; i++)
            //{
            //    yigindi = yigindi + i;
            //}
            //Console.WriteLine(yigindi);



            //1.3.3-oson-1
            //for (int i = 14; i < 21; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1.3.3-oson-2
            //for (int i = 11; i <= 99; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1.3.3-oson-3
            //for (int i = 12; i <= 300; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1.3.3-oson-4
            //for (int i = 25; i >= 15; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //1.3.3-oson-5
            //for (int i = 500; i >= 80; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //1.3.3-oson-6
            //for (int i = 11; i <= 88; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-7
            //for (int i = 12; i <= 25; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-8
            //for (int i = 15; i <= 88; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-9
            //for (int i = 99; i >= 10 ; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-10
            //Console.Write("a sonini kiriting");
            //var a = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiriting");
            //var b = int.Parse(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-11
            //Console.Write("a sonini kiriting : ");
            //var a = int.Parse(Console.ReadLine());
            //Console.Write("b sonini kiritng");
            //var b = int.Parse(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 5 == 0 && i % 6 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3.3-oson-12
            int a = 10;
            int b = 90;
            for (int i = a; i <= b; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
