abstract class Persona : IInformable //Esto significa Persona se compromete a cumplir el contrato de IInformable.
//abstract significa Esta clase sirve como base para otras clases, pero no se pueden crear objetos directamente de ella.
{
    public string Nombre{get;set;}

    //Constructor
    public Persona(string nombre)
    {
        Nombre=nombre;
    }

    /*public virtual string Presentarse()
    {
        return $"Soy {Nombre}";
    }*/

    public abstract string Presentarse();//Significa Toda clase concreta que herede de Persona está obligada a implementar Presentarse()

    public virtual string MostrarInformacion() //El "virtual" indica que Las clases hijas pueden redefinir este método
    {
        // devolver información de la persona
        return$"Persona: {Nombre}";
    }
}