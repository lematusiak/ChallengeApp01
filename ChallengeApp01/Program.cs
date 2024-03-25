using ChallengeApp01;

Employee employee1 = new Employee("Tibo", "Tabulacz", 41);
Employee employee2 = new Employee("Maku", "Makowiec", 36);
Employee employee3 = new Employee("Suso", "Susłonek", 52);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(6);
employee1.AddScore(1);
employee1.AddScore(8);

employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(2);

employee3.AddScore(10);
employee3.AddScore(0);
employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(6);

var employees = new List<Employee> { employee1, employee2, employee3 };

int maxResult = 0;
Employee employeeWithMaxResult = null!;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine($"Mistrz Klasyfikacji: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}. Wiek pracownika w latach: {employeeWithMaxResult.Age}. Liczba uzyskanych punktów: {maxResult}.");

Console.ReadKey();
