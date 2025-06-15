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
    

 }



    