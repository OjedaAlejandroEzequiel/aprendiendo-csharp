

/*Console.Write("Ingrese el primer numero: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo numero: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el tercer numero: ");
int c = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el cuarto numero: ");
int d = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el quinto numero: ");
int e = int.Parse(Console.ReadLine()!);

double promedio = (a + b + c + d + e) / 5.0;

Console.WriteLine($"El promedio es: {promedio}");

int mayor = a;

if (b > mayor)
{
    mayor = b;
}
if (c > mayor)
{
    mayor = c;
}
if (d > mayor)
{
    mayor = d;
}
if (e > mayor)
{
    mayor = e;
}

Console.Write($"El mayor es: {mayor}");

*/
/*Sin constructor
Alumno alumno1 = new Alumno();
alumno1.Nombre = "Alejandro";
alumno1.Legajo = 12345;
alumno1.Nota = 8;
*/

//Con constructor
Alumno alumno1 = new Alumno("Alejandro", 12345, 8);

Console.WriteLine($"Alumno: {alumno1.Nombre}");
Console.WriteLine($"Legajo: {alumno1.Legajo}");
Console.WriteLine($"Nota: {alumno1.Nota}");

Console.WriteLine($"¿Está aprobado?: {alumno1.EstaAprobado()}");

Console.WriteLine(alumno1.CuantoFaltaPara(10));

Console.WriteLine($"Nota anterior: {alumno1.Nota}");

alumno1.ActualizarNota(9);
Console.WriteLine($"Nota nueva: {alumno1.Nota}");
alumno1.ActualizarNota(15);
Console.WriteLine($"Nota nueva: {alumno1.Nota}");


try
{
    Alumno alumno3 = new Alumno("Alejandro", 12345, 15);
}
catch (ArgumentException error)
{
    Console.WriteLine($"No se pudo crear el alumno: {error.Message}");
}

//Listas
List<Alumno> alumnos = new List<Alumno>();
alumnos.Add(new Alumno("Ezequiel",45611,9));
alumnos.Add(new Alumno("Alejandro",45601,9));
alumnos.Add(new Alumno("Lucia",42631,8));
alumnos.Add(new Alumno("Juan",42631,2));

foreach (Alumno alumno in alumnos)
{
    if(alumno.EstaAprobado()){
        Console.WriteLine($"Nombre: {alumno.Nombre}-Legajo:{alumno.Legajo}-Nota: {alumno.Nota}");
    }

}

Materia paradigma= new Materia("Paradigmas");
Materia sintaxis= new Materia("Sintaxis");

alumno1.AgregarMateria(paradigma);
alumno1.AgregarMateria(sintaxis);

foreach(Materia materia in alumno1.Materias)
{
    Console.WriteLine($"Materias:{materia.Nombre}");
}

Persona persona1 = new Profesor("Carlos",9921);

Persona persona2 = new Alumno("Ezequiel", 45611, 9);

Console.WriteLine(persona1.Presentarse());
Console.WriteLine(persona2.Presentarse());

List<Persona> personas = new List<Persona>();

personas.Add(new Profesor("Carlos",9921));
personas.Add(new Alumno("Ezequiel",45611,9));
personas.Add(new Profesor("Laura",9876));

foreach(Persona persona in personas){
    Console.WriteLine(persona.Presentarse());
}

List<IInformable> informables = new List<IInformable>();

informables.Add(new Profesor("Carlos",9921));
informables.Add(new Materia("Paradigmas"));
informables.Add(new Alumno("Ezequiel", 45611, 9));
informables.Add(new Profesor("Laura", 9876));

foreach(IInformable informable in informables){
    Console.WriteLine(informable.MostrarInformacion());
}