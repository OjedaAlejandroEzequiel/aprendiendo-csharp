
List<Vehiculo> vehiculos =new List<Vehiculo>();

vehiculos.Add(new Auto("Ford","ARC123",4));
vehiculos.Add(new Moto("Zanella","AEC343",43));


foreach(Vehiculo vehiculo in vehiculos)
{
    Console.WriteLine(vehiculo.MostrarDatos());
}

IAsegurable auto1 = new Auto("Ford", "ARC123", 4);
Console.WriteLine(auto1.CalcularSeguro());

List<IAsegurable> asegurables = new List<IAsegurable>();

asegurables.Add(new Auto("Fiat","AEW123",4));
asegurables.Add(new Auto("Goal","AQR145",2));

foreach(IAsegurable asegurable in asegurables){
    Console.WriteLine(asegurable.CalcularSeguro());
}
