var o = new Octopus("Jack");

Console.WriteLine(o.Name);  // Jack  
o.Legs = 20;                // Erro de compilação

class Octopus
{
  public readonly string Name;
  public readonly int Legs = 8;
  
  public Octopus(string name)
  {
    Name = name;

    Console.WriteLine("V1.0");  //Jarol01
    Console.WriteLine("V2.0");  //Jarol02
    Console.WriteLine("V3.0");  //Jarol01
    Console.WriteLine("V4.0");  //Jarol01
  }
}
