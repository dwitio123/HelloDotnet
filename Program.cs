Developer dev = new Developer();
dev.Name = "Prabowo";
dev.Experience = 2;
dev.Introduce();

Developer dev2 = new Developer();
dev2.Name = "Gibran";
dev2.Experience = 2;
dev2.Introduce();

// -------------------------------------------

Employee employee = new()
{
    Name = "Jokowi",
    Age = 60,
    isActive = true
};

Console.WriteLine("-------------------------");
Console.WriteLine(employee.Name);
Console.WriteLine(employee.Age);
Console.WriteLine(employee.isActive);
Console.WriteLine("-------------------------");

// --------------------------------------------

Laptop laptop = new()
{
    Brand = "Lenovo",
    Processor = "Intel i5",
    Ram = 16,
    Price = 8500000
};

Console.WriteLine("-------------------------");
Console.WriteLine(laptop.Brand);
Console.WriteLine(laptop.Processor);
Console.WriteLine($"{laptop.Ram} GB");
Console.WriteLine($"Rp{laptop.Price}");
Console.WriteLine("-------------------------");

// --------------------------------------------
Student student = new ()
{
    Name = "Owi",
    Age = 54
};
student.Introduce();
Console.WriteLine("-------------------------");

// --------------------------------------------
Book book = new()
{
    Title = "Bumi Datar",
    Author = "TGS",
    Price = 100000
};
book.PrintInfo();
Console.WriteLine("-------------------------");

// --------------------------------------------
BankAccount account = new("Wokwi");
account.Deposit(500000);
account.Withdraw(200000);
account.ShowBalance();
Console.WriteLine("-------------------------");

// --------------------------------------------
ICalculator calculator = new Calculator();
Console.WriteLine(calculator.Add(10, 6));
Console.WriteLine("-------------------------");

// --------------------------------------------
IAnimal animal = new Duck();
animal.Speak();
Console.WriteLine("-------------------------");

// --------------------------------------------
// Exercise
Vehicle vehicle = new Car();
vehicle.Start();
Console.WriteLine("-------------------------");

// Challenge
List<Animal> animals = new()
{    
    new Monkey(),
    new Dog()
};

foreach (var animaru in animals)
{
    animaru.Speak();
}

Console.WriteLine("-------------------------");

// --------------------------------------------
// Exercise
// try
// {
//     Console.Write("Masukkan angka pertama: ");
//     int a = int.Parse(Console.ReadLine()!);

//     Console.Write("Masukkan angka kedua: ");
//     int b = int.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Hasil = {a / b}");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Pembagian dengan nol tidak diperbolehkan.");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Input harus berupa angka.");
// }
// finally
// {
//     Console.WriteLine("Program selesai.");
// }

// --------------------------------------------
// Exercise
List<DeveloperIndo> developers = new()
{
    new DeveloperIndo { Name = "Prabowo", Experience = 2 },
    new DeveloperIndo { Name = "Gibran", Experience = 2 },
    new DeveloperIndo { Name = "Jokowi", Experience = 5 },
    new DeveloperIndo { Name = "Megawati", Experience = 10 }
};


var seniorDevelopers = developers.Where(d => d.Experience >= 3);
foreach (var developer in seniorDevelopers)
{
    Console.WriteLine($"{developer.Name} - {developer.Experience} tahun");
}

//Challenge
Console.WriteLine("-------------------------");
var allDevelopers = developers.Select(d => d.Name);
foreach (var name in allDevelopers)
{
    Console.WriteLine(name);
}
Console.WriteLine("-------------------------");

var sorthighestExperience = developers.OrderByDescending(d => d.Experience);
foreach (var developer in sorthighestExperience)
{
    Console.WriteLine($"{developer.Name} - {developer.Experience} tahun");
}
Console.WriteLine("-------------------------");

var findDeveloper = developers.FirstOrDefault(d => d.Name == "Jokowi");
if (findDeveloper != null)
{
    Console.WriteLine($"Ditemukan: {findDeveloper.Name} - {findDeveloper.Experience} tahun");
}
else
{
    Console.WriteLine("Developer tidak ditemukan.");
}
Console.WriteLine("-------------------------");

// --------------------------------------------
// Exercise
static async Task SayHelloAsync()
{
    Console.WriteLine("Loading...");
    await Task.Delay(2000);
    Console.WriteLine("Hei Antek-Antek Async!");
}

await SayHelloAsync();
Console.WriteLine("-------------------------");

static async Task<string> GetNameAsync()
{
    await Task.Delay(1000);
    return "Prabowo";
}

string nameAsing = await GetNameAsync();
Console.WriteLine($"Nama: {nameAsing}");
Console.WriteLine("-------------------------");

// Exercise
static async Task<int> CalculateAsync(int a, int b)
{
    Console.WriteLine("Menghitung...");
    await Task.Delay(2000);
    return a + b;
}
Console.WriteLine("Mulai");
int result = await CalculateAsync(10, 6);
Console.WriteLine($"Hasil: {result}");
Console.WriteLine("Selesai");

public class Developer
{
    public string Name { get; set; } = "";
    public int Experience { get; set; }
    public void Introduce()
    {
        Console.WriteLine($"Halo, saya {Name} dengan pengalaman {Experience} tahun");
    }
}

public class Employee
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public bool isActive { get; set; }
}

// --------------------------------------------
// Challenge

public class Laptop
{
    public required string Brand { get; set; }
    public required string Processor { get; set; }
    public int Ram { get; set; }
    public double Price { get; set; }
}

// --------------------------------------------
// Exercise
public class Student
{
    public required string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
    }

    public void Introduce()
    {
        Console.WriteLine($"Halo, saya {Name}, umur {Age}");
    }
}

// Challenge
public class Book
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public int Price { get; set; }

    public Book() {

    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price}");
    }
}

// --------------------------------------------
// Exercise
public class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }
    public BankAccount(string owner) 
    {
        Owner = owner;
    }
    
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Saldo tidak mencukupi");
        }
        else 
        {
            Balance -= amount;
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"{Owner} memiliki saldo sebesar {Balance}");
    }
}

// --------------------------------------------
// Exercise
public interface ICalculator
{
    int Add(int a, int b);
}

public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

// --------------------------------------------
// Challenge
public interface IAnimal
{
    void Speak();
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meok");
    }
}

public class Duck : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Wik Wik");
    }
}

// --------------------------------------------
// Exercise
public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car engine started");
    }
}

// Challenge
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Sound");
    }
}

public class Monkey : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Ooh ooh");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Guk guk");
    }
}

// --------------------------------------------
// Exercise
public class DeveloperIndo
{
    public string Name { get; set; } = "";
    public int Experience { get; set; }
}

// --------------------------------------------
// Exercise

