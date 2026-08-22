namespace dars11;

internal class Program
{
    static List<Employes> employes = new List<Employes>();
    static void Main(string[] args)
    {
        //Console.WriteLine(GetIsGiveNotIs("is-is"));
        Console.WriteLine(GetNumsSum("salom123"));
    }
    static void AddEmployer(Employes employe)
    {
        employes.Add(employe);
    }

    static void RemoveEmploye(Guid EmployeId)
    {
        foreach (var employe in employes)
        {
            if (employe.employeId == EmployeId)
            {
                employes.Remove(employe);
                break;
            }
        }
    }

    static void UpdateQuestion(Guid EmplyeId, Employes newEmploye)
    {
        for (int i = 0; i < employes.Count; i++)
        {
            if (employes[i].employeId == EmplyeId)
            {
                newEmploye.employeId = EmplyeId;
                employes[i] = newEmploye;
                break;
            }
        }
    }

    static void Display()
    {
        foreach (var employe in employes)
        {
            Console.WriteLine($"Employe id {employe.employeId}");
            Console.WriteLine($"Employe id {employe.FirstName}");
            Console.WriteLine($"Employe id {employe.LastName}");
            Console.WriteLine($"Employe id {employe.Salary}");
            Console.WriteLine($"Employe id {employe.Position}");
            Console.WriteLine($"Employe id {employe.Age}");
        }
    }
    static string GetIsGiveNotIs(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'i' && str[i + 1] == 's')
            {
                return str.Remove(i, 2).Insert(i, "is not");
            }
        }
        return str;
    }
    static int GetNumsSum(string str)
    {
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                sum += str[i] - '0';
            }
        }
        return sum;
    }

}
