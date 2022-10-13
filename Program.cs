enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons
}

class Program
{

    static PersonList personList;

    static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen()
    {
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintListMenu()
    {
        Console.WriteLine("Welcome to registration new user school application");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Registration new Student");
        Console.WriteLine("2. Registration new Teacher");
        Console.WriteLine("3. Get List Persons");
        Console.WriteLine("****************************************************");
    }

    static void InputMenuFromKeyboard()
    {
        Console.Write("Please input Menu:");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.RegisterNewStudent:
                ShowInputRegistrationNewStudentScreen();
                break;
            case Menu.RegisterNewTeacher:
                ShowInputRegistrationNewTeacherScreen();
                break;
            case Menu.GetListPersons:
                ShowPersons();
                break;
            default:
                break;
        }
    }

    static void ShowPersons()
    {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }

    static void ShowInputRegistrationNewTeacherScreen()
    {
        Console.Clear();

        PrintHeaderRegistrationTeacher();

        int totalNewTeacher = TotalNewTeacher();
        inputNewTeacherFromKeyboard(totalNewTeacher);
    }

    static void ShowInputRegistrationNewStudentScreen()
    {
        Console.Clear();

        PrintHeaderRegisterStudent();

        int totalStudent = TotalNewStudent();
        InputNewStudentFromKeyboard(totalStudent);
    }

    static void PrintHeaderRegistrationTeacher()
    {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*********************");
    }

    static void PrintHeaderRegisterStudent()
    {
        Console.WriteLine("Register New Student");
        Console.WriteLine("*********************");
    }

    static int TotalNewStudent()
    {
        Console.Write("Input Total new Student: ");

        return int.Parse(Console.ReadLine());
    }

    static int TotalNewTeacher()
    {
        Console.Write("Input Total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }

    static void InputNewStudentFromKeyboard(int totalNewStudent)
    {
        for (int i = 0; i < totalNewStudent; i++)
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputStudentID()
            );

            Program.personList.AddNewPerson(student);
        }

        BackToMainMenu();
    }

    static void inputNewTeacherFromKeyboard(int totalNewTeacher)
    {
        for (int i = 0; i < totalNewTeacher; i++)
        {
            Console.Clear();
            PrintHeaderRegistrationTeacher();

            Teacher teacher = new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID()
            );

            Program.personList.AddNewPerson(teacher);
        }

        BackToMainMenu();
    }

    static void BackToMainMenu()
    {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personList = new PersonList();
    }

    static string InputName()
    {
        Console.Write("Name :");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID :");

        return Console.ReadLine();
    }

    static string InputAddress()
    {
        Console.Write("Address : ");

        return Console.ReadLine();
    }

    static string InputCitizenID()
    {
        Console.Write("CitizenID: ");

        return Console.ReadLine();
    }

    static string InputEmployeeID()
    {
        Console.Write("EmployeeID: ");

        return Console.ReadLine();
    }
}
