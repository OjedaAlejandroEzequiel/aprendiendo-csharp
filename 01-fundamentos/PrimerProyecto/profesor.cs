class Profesor :Persona
{
    public int Legajo{get;set;}

    //Constructor
    public Profesor(string nombre,int legajo):base(nombre)
    {
        Legajo=legajo;
    }
    public override string Presentarse()
    {
        return $"Soy el profesor {Nombre},legajo {Legajo}";
    }

    public override string MostrarInformacion()
    {
        return $"Profesor: {Nombre} - Legajo: {Legajo}";
    }
}