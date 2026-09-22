class Alumno : Persona
{
    //public string Nombre { get; set; } = ""; No es necesario este campo porque lo hereda de Persona
    public int Legajo { get; set; }
    public double Nota { get; private set; }
    public List<Materia> Materias {get;private set;}

    //Constructor
    public Alumno(string nombre, int legajo, double nota) : base(nombre)
    {
        if (nota < 1 || nota > 10)
        {
            throw new ArgumentException("La nota debe estar entre 1 y 10");
        }
        //Nombre = nombre; No es necesario porque lo hereda de Persona
        Legajo = legajo;
        Nota = nota;
        Materias = new List<Materia>();
    }

    public bool EstaAprobado()
    {
        // código
        if(Nota>=6){
            return true;
        }
        return false;
    }

    public void ActualizarNota(double nuevaNota)
    {
        if ( nuevaNota>=1 && nuevaNota<=10)
        {
        Nota = nuevaNota;
        }
    }
    public double CuantoFaltaPara(double notaObjetivo)
    {
        if(Nota >= notaObjetivo){return 0;};

        return notaObjetivo-Nota;
    }
    public void AgregarMateria(Materia materia)
    {
        Materias.Add(materia);
    }
    public override string Presentarse()
    {
        return $"Soy el alumno {Nombre}, legajo {Legajo}";
    }

    public override string MostrarInformacion()
    {
        return $"Alumno: {Nombre} - Legajo: {Legajo} - Nota: {Nota}";
    }



}
