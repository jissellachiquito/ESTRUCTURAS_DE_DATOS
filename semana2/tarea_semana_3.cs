public class Estudiante //creacion de clase estudiante 
{
    // declaracion de atributos del estudiante
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos;  // array para los tres teléfonos

    //generacion del constructor para inicializar los datos
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;
        this.telefonos = telefonos;
    }
    //metodo que devuelve todos los datos del estudiante
    public string Mostrar_informacion()
    {
         //se almacena la informacion del estudiante
        string informacion = "ID: " + id + "\n";
        informacion += "Nombres: " + nombres + "\n";
        informacion += "Apellidos: " + apellidos + "\n";
        informacion += "Direccion: " + direccion + "\n";
        informacion += "Telefonos:\n";

        //se recorre el array de telefonos para agregarlos uno por uno a la variable de informacion
        for (int i = 0; i < telefonos.Length; i++)
        {
            informacion += "- " + telefonos[i] + "\n";
        }

        return informacion;
    }  
 }

//ejecucion del programa
public class Programa
{
    static void Main(string[] args)
    {
        //creacion de los datos del estudiante
        int id = 1;
        string nombres = "Ezequiel";
        string apellidos = "Marquez";
        string direccion = "Av. Central y Calle 24";
        string[] telefonos = new string[3] { "0927234567", "0985349781", "0981651321" };

        // creacion del objeto estudiante
        Estudiante estudiante1 = new Estudiante(id, nombres, apellidos, direccion, telefonos);

        System.Console.WriteLine(estudiante1.Mostrar_informacion()); //se imprime la informacion del estudiante
        System.Console.ReadLine();
    } 
} 





    