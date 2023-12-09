using ChallengeApp;

//User user1 = new User("Adam","aaa");
//User user2 = new User("Monika", "mmm");
//User user3 = new User("Zusia", "zzz");
//User user4 = new User("Damian", "ddd");

//user1.AddScore(5);
//user1.AddScore(6);
//var result = user1.Result;
//Console.WriteLine(result);

Employee employee1 = new Employee("Jan", "Nowak", 30);
Employee employee2 = new Employee("Anna", "Nowak", 28);
Employee employee3 = new Employee("Ewa", "Kowalska", 24);

employee1.AddScore(8);
employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(7);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(10);
employee2.AddScore(1);
employee3.AddScore(6);
employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

int maxResultOfEmployee = 0;
Employee employeeWithMaxResult = null;

foreach (Employee employee in employees)
{
    if (employee.MaxGrade > maxResultOfEmployee)
    {
        maxResultOfEmployee = employee.MaxGrade;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z najwyższą oceną to: " + employeeWithMaxResult.ForeName + " " + employeeWithMaxResult.SurName + " w wieku " + employeeWithMaxResult.Age + " z wynikiem " + maxResultOfEmployee);

//zadania dodatkowe
//1. Odwrócenie liczby
//int number = 1387;
//string numberAsString = number.ToString();
//char[] chars = numberAsString.ToCharArray();
//string res = "";

//for (int i = chars.Length-1; i >= 0; i--)
//{
//    res += chars[i].ToString();
//}

//Console.WriteLine(res);