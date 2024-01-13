using OOP_Exercise_2;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        ShowError(ex.Message);
    }
}
static void Run()
{
    var menu = GetInt("Choose An Option:\n" +
        "1.Add Employee\n" +
        "2.Add Manager\n" +
        "3.Show Employees\n" +
        "4.Show Managers\n" +
        "0.Exit\n");
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0);
                break;
            }
        case 1:
            {
                var id = GetString("Enter Employee Id:");
                var salary = GetInt("Enter Employee Salary:");
                Office.AddEmployee(id, salary);
                break;
            }
        case 2:
            {
                var id = GetString("Enter Manager Id:");
                var salary = GetInt("Enter Employee Salary:");
                var department = GetString("Enter Employee Department");
                Office.AddEmployee(id, salary, department);
                break;
            }
        case 3:
            {
                Office.ShowEmployees();
                break;
            }
            case 4:
            {
                Office.ShowManagers();
                break;
            }
    }
}


static string GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}
static void ShowError(string message)
{
    Console.WriteLine("#############################");
    Console.WriteLine(message);
    Console.WriteLine("#############################");
}