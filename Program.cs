
using System;
using System.Security.Cryptography.X509Certificates;

namespace TugasPRPBO;

    class Program
{
    static void Main(string[] args)
    {
        Mobil mobil1 = new Agya();
        mobil1.ban = new Michelin();
        mobil1.NyalakanMesin();
        mobil1.MatikanMesin();
        Mobil mobil2 = new Avanza();
        mobil2.ban = new Bridgestone();
        ((Avanza)mobil2).NyalakanLampu();
        Civic civic1 = new Civic();
        civic1.VtecKickedIn();
        civic1.ban = new Bridgestone();
    }
}

    class Mobil
{
    public string merk, tipe;
    public Ban ban;

    public Mobil(string merk, string tipe) {this.merk = merk;this.tipe = tipe;}

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} mati");
    }
}
    class Ban
{
    public string merk;
    public Ban(string merk) {this.merk = merk;}
}

    class Toyota : Mobil
{
    public Toyota(string tipe) : base("Toyota", tipe) { }
}

    class Honda : Mobil
{
    public Honda(string tipe) : base("Honda", tipe) { }
}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe) : base("Honda", tipe) { }
}
    class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone") { }
}

    class Michelin : Ban
{
    public Michelin() : base("Michelin") { }
}

    class Agya : Toyota
{
    public Agya() : base("Agya") { }
}
    class Innova : Toyota
{
    public Innova(): base("Innova") { }
}
    class Avanza : Toyota
{
    public Avanza(): base("Avanza") { }
    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {merk} bertipe {tipe} menyala");
    }
}
    class Brio : Honda
{
    public Brio() : base("Honda") { }
}
    class Civic : Honda
{
    public Civic() : base("Civic") { }
    public void VtecKickedIn()
    {
        Console.WriteLine("Ngeeeng Wooosh!!!");
    }
}
    class Ayla : Daihatsu
{
    public Ayla() : base("Ayla") { }
}
    class Xenia : Daihatsu
{
    public Xenia() :base("Xenia") { }
}