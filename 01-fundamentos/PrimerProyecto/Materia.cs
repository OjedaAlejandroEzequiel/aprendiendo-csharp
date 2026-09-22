class Materia : IInformable
{
    public string Nombre{get;set;}

    //Constructor
    public Materia(string nombre)
    {
        Nombre=nombre;
    }
    
    public string MostrarInformacion()
    {
        return $"Materia: {Nombre}";
    }

}