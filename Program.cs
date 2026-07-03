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