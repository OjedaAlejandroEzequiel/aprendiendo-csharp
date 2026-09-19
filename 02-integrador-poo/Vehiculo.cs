abstract class Vehiculo
{
    public string Marca{get;set;}
    public string Patente{get;set;}

    //constructor
    public  Vehiculo(string marca,string patente)
    {
        Marca= marca;
        Patente= patente;
    }

    public abstract string MostrarDatos();

}