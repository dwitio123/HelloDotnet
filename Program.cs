Developer dev = new Developer();
dev.Name = "Prabowo";
dev.Experience = 2;
dev.Introduce();

Developer dev2 = new Developer();
dev2.Name = "Gibran";
dev2.Experience = 2;
dev2.Introduce();

public class Developer
{
    public string Name { get; set; } = "";
    public int Experience { get; set; }
    public void Introduce()
    {
        Console.WriteLine($"Halo, saya {Name} dengan pengalaman {Experience} tahun");
    }
}