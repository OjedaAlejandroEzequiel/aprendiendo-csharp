class Auto: Vehiculo,IAsegurable
{
    public int CantidadPuertas{get;set;}

    //Constructor
    public Auto(string marca,string patente, int cantidadPuertas):base(marca,patente)
    {
        CantidadPuertas= cantidadPuertas;
    }

    public override string MostrarDatos()
    {
        return $"Auto - Marca: {Marca} - Patente: {Patente} - Puertas: {CantidadPuertas}";
    }

    public double CalcularSeguro()
    {
        return CantidadPuertas*5000;
    }
}