//namespace dars9
//{
//    internal class Program
//    {
//        static List<string> studnets = new List<string>();
//        static void Main(string[] args)
//        {

//            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            //List<string> list1 = new List<string>() { "salom", "$hello", "$hi" };

//            //Console.WriteLine(Total(list));
//            //Console.WriteLine(StartWith(list1));


//            var newId = string.Empty;
//            var oldId = string.Empty;
//            while (true)
//            {
//                Console.WriteLine("1. Create");
//                Console.WriteLine("2. Delete");
//                Console.WriteLine("3. Update");
//                Console.WriteLine("4. Display");
//                Console.WriteLine("5. Quit");
//                int choice = int.Parse(Console.ReadLine());

//                if (choice == 1)
//                {
//                    Console.WriteLine("Isimni kiriting : ");
//                    string name = Console.ReadLine();
//                    AddStudent(name);
//                    Console.WriteLine("Ism qo'shildi");
//                }
//                else if (choice == 2)
//                {
//                    Console.Write("Isimni kiriting : ");
//                    newId = Console.ReadLine();
//                    var exists = studnets.Contains(newId);
//                    if (exists == true)
//                    {

//                        DeleteStudent(newId);
//                        Console.WriteLine("Ism muvaffaqiyatli o'chirildi.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Bunday Ism mavjud emas.");
//                    }
//                }
//                else if (choice == 4)
//                {
//                    Displays();
//                }
//                else if (choice == 3)
//                {
//                    Console.Write("Eski id ni kiriting : ");
//                    oldId = Console.ReadLine();
//                    Console.Write("Yangi id ni kiriting : ");
//                    newId = Console.ReadLine();
//                    var exists = studnets.Contains(oldId);

//                    if (exists == true)
//                    {
//                        UpdateStudents(oldId, newId);
//                        Console.WriteLine("Id muvaffaqiyatli yangilandi.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Id yangilashda xatolik yuz berdi.");
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Davay");
//                    break;
//                }


//                Console.ReadKey();
//                Console.Clear();
//            }

//        }
//        static int Total(List<int> ints)
//        {
//            var count = 0;
//            foreach (var x in ints)
//            {
//                count = count + x;
//            }
//            return count;
//        }
//        static int StartWith(List<string> strs)
//        {
//            var count = 0;
//            foreach (var x in strs)
//            {
//                if (x.StartsWith("$"))
//                {
//                    count++;
//                }
//            }
//            return count;
//        }

//        static void AddStudent(string name)
//        {
//            studnets.Add(name);
//        }
//        static void DeleteStudent(string name)
//        {
//            studnets.Remove(name);
//        }

//        static void UpdateStudents(string OldName, string NewName)
//        {
//            int index = studnets.IndexOf(OldName);
//            if (index != -1)
//            {
//                studnets[index] = NewName;
//            }
//            else
//            {
//                Console.WriteLine("Bunday o'quvchi topilmadi");
//            }
//        }
//        static void Displays()
//        {
//            foreach (var name in studnets)
//            {
//                Console.WriteLine(name);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//}