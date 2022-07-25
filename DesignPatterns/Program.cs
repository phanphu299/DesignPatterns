// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationPatterns.AbstractFactory;
using DesignPatterns.CreationPatterns.Builder;
using DesignPatterns.CreationPatterns.Factory;
using DesignPatterns.CreationPatterns.FactoryMethod;
using DesignPatterns.CreationPatterns.Fluent;
using DesignPatterns.CreationPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Facade;

Console.WriteLine("Hello, World!");
ShowFacadePattern();

#region CREATION_PATTERNS

void ShowFactoryPattern()
{
    // FACTORY
    var coffee = CoffeeFactory.GetCoffee(CoffeeTypeConsts.Cappuchino);
    if (coffee != null)
    {
        Console.WriteLine($"Coffee type: {coffee.GetCoffeeType()}");
        Console.WriteLine($"Cost: {coffee.GetCost()}");
        Console.WriteLine($"Tip: {coffee.GetTip()}");
    }
}

void ShowFactoryMethodPattern()
{
    // FACTORY METHOD
    var coffee = new MochaFactoyMethod().CreateCoffee();
    if (coffee != null)
    {
        Console.WriteLine($"Coffee type: {coffee.GetCoffeeType()}");
        Console.WriteLine($"Cost: {coffee.GetCost()}");
        Console.WriteLine($"Tip: {coffee.GetTip()}");
    }
}

void ShowAbstractFactoryPattern()
{
    IAnimal animal = null;
    AnimalFactory animalFactory = null;
    string speakSound = null;
    // Create the Sea Factory object by passing the factory type as Sea
    animalFactory = AnimalFactory.GetAnimalFactory(FactoryEnums.SeaAnimal);
    Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
    Console.WriteLine();
    // Get Octopus Animal object by passing the animal type as Frog
    animal = animalFactory.GetAnimal(AnimalEnums.Frog);
    Console.WriteLine("Animal Type : " + animal.GetType().Name);
    speakSound = animal.Speak();
    Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
    Console.WriteLine();
    Console.WriteLine("--------------------------");
    // Create Land Factory object by passing the factory type as Land
    animalFactory = AnimalFactory.GetAnimalFactory(FactoryEnums.LandAnimal);
    Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
    Console.WriteLine();
    // Get Lion Animal object by passing the animal type as Dog
    animal = animalFactory.GetAnimal(AnimalEnums.Dog);
    Console.WriteLine("Animal Type : " + animal.GetType().Name);
    speakSound = animal.Speak();
    Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
    Console.WriteLine();
    // Get Cat Animal object by passing the animal type as Chicken
    animal = animalFactory.GetAnimal(AnimalEnums.Chicken);
    Console.WriteLine("Animal Type : " + animal.GetType().Name);
    speakSound = animal.Speak();
    Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
}

void ShowBuilderPattern()
{
    Report report = new();
    ReportDirector reportDirector = new();

    PdfReportBuilder pdfReport = new();
    report = reportDirector.MakeReport(pdfReport);
    report.ShowReport();

    Console.WriteLine("--------------------------------------");

    ExcelReportBuilder excelReport = new();
    report = reportDirector.MakeReport(excelReport);
    report.ShowReport();
}

void ShowFluentPattern()
{
    FluentEmployee employee = new();

    employee
        .WithName("Phu")
        .LivingAt("Binh Duong")
        .Born(DateTime.Now);

    employee.ShowInfo();

    Console.WriteLine("--------------------------------------");

    DesignPatterns.CreationPatterns.Fluent.Employee ronaldo = new();
    ronaldo
        .WithName("Cr7")
        .LivingAt("England")
        .Born(DateTime.Now);

    Console.WriteLine($"Name: {ronaldo.Name}");
    Console.WriteLine($"Living at: {ronaldo.Address}");
    Console.WriteLine($"Born: {ronaldo.DateOfBirth.ToLongDateString()}");
}

void ShowSingletonPattern()
{
    Parallel.Invoke(
                () => PrintTeacherDetailsEager(),
                () => PrintStudentdetailsEager()
                );
    //Singleton fromTeachaer = Singleton.GetInstance;
    //fromTeachaer.ShowMessage("From Teacher");
    //Singleton fromStudent = Singleton.GetInstance;
    //fromStudent.ShowMessage("From Student");
}

void PrintTeacherDetails()
{
    Singleton fromTeacher = Singleton.GetInstance;
    fromTeacher.ShowMessage("From Teacher");
}
void PrintStudentdetails()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.ShowMessage("From Student");
}

void PrintTeacherDetailsLock()
{
    SingletonWithLock fromTeacher = SingletonWithLock.GetInstance;
    fromTeacher.ShowMessage("From Teacher");
}
void PrintStudentdetailsLock()
{
    SingletonWithLock fromStudent = SingletonWithLock.GetInstance;
    fromStudent.ShowMessage("From Student");
}

void PrintTeacherDetailsEager()
{
    EagerLoadingSingleton fromTeacher = EagerLoadingSingleton.GetInstance;
    fromTeacher.ShowMessage("From Teacher");
}
void PrintStudentdetailsEager()
{
    EagerLoadingSingleton fromStudent = EagerLoadingSingleton.GetInstance;
    fromStudent.ShowMessage("From Student");
}

#endregion

#region STRUCTURAL_PATTERNS

void ShowAdapterPattern()
{
    string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

    IAdapter adapter = new ProcessSalaryAdapter();
    adapter.ProcessSalary(employeesArray);
}

void ShowFacadePattern()
{
    Order order = new();
    order.PlaceOrder();
}

#endregion