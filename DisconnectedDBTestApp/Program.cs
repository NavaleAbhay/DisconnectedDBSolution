

int MainChoice;

do
{
    DisplayManager.ShowMainMenu();
    MainChoice = int.Parse(Console.ReadLine());

    int choice = 0;
    switch (MainChoice)
    {

        case 1:

            do
            {
                DisplayManager.ShowDepartmentMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayManager.ShowAllDepartment();
                        break;

                    case 2:
                        DisplayManager.ShowDepartmentById();
                        break;

                    case 3:
                        DisplayManager.InsertDepartment();
                        break;

                    case 4:
                        DisplayManager.UpdateDepartment();
                        break;

                    case 5:
                        DisplayManager.DeleteDepartment();
                        break;


                    default:
                        Console.WriteLine("Enter valid Input");
                        break;

                }
            } while (choice != 0);
            break;

        case 2:
            do
            {
                DisplayManager.ShowEmployeeMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayManager.ShowAllEmployees();
                        break;

                    case 2:
                        DisplayManager.ShowEmployeeById();
                        break;

                    case 3:
                        DisplayManager.InsertEmployee();
                        break;

                    case 4:
                        DisplayManager.UpdateEmployee();
                        break;

                    case 5:
                        DisplayManager.DeleteEmployee();
                        break;

                    default:
                        Console.WriteLine("Enter valid Input");
                        break;

                }

            } while (choice != 0);
            break;
    }
} while (MainChoice != 0);







