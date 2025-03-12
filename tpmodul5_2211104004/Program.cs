using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
        Console.ReadLine();
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Dina"); // Ganti dengan nama panggilan praktikan
    }
}