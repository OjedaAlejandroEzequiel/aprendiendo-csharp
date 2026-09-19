class Moto:Vehiculo
{
    public int Cilindrada{get;set;}
    //Constructor
    public Moto(string marca,string patente,int cilindrada):base(marca,patente)
    {
        Cilindrada= cilindrada;
    }

    public override string MostrarDatos()
    {
        return $"Moto - Marca: {Marca} - Patente: {Patente} - Cilindrada: {Cilindrada}";
    }
}