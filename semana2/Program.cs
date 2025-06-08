
//crear clase que represente un triangulo
class triangulo
{
    //atributos
    private Double base_triangulo;  //atributo que guarda el valor de la base
    private Double altura;  //atributo que guarada el valor de la altura

    //metodo constructor ejerce la funcion de inicializar los valores de base y altura con los datos que recibe
    public triangulo(Double base_triangulo, Double altura)
    {
        // La palabra 'this' se usa para diferenciar entre el atributo y el parametro
        this.base_triangulo = base_triangulo;
        this.altura = altura;
    }

    //formula para calcular el area del triangulo
    public Double Calcular_area()
    {
        return (base_triangulo * altura) / 2;
    }

    //formula para calcular el perimetro
    public Double Calcular_perimetro()
    {
        return 3 * base_triangulo;
    }

}

//crear clase que represente un rectangulo
class rectangulo
{
    //atributos
    private Double ancho;  //atributo que guarda el valor para la anchura
    private Double alto;  //atributo que guarda el valor para la altura

    //metodo constructor usado para asignar valores iniciales al ancho y alto del rectangulo al momento de crearlo
    public rectangulo(Double ancho, Double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    //formula para calcular el area 
    public Double Calcular_area()
    {
        return ancho * alto;
    }

    //formula para calcular el perimetro
    public Double Calcular_perimetro()
    {
        return 2 * (ancho + alto);
    }

}

class Program
{
    static void Main(string[] args)
    {
        // crear un triangulo con base 4 y altura 4
        triangulo mi_triangulo = new triangulo(4, 4);
        System.Console.WriteLine("Triangulo:");
        System.Console.WriteLine("Area: " + mi_triangulo.Calcular_area()); //muestra el area calculada
        System.Console.WriteLine("Perimetro: " + mi_triangulo.Calcular_perimetro()); //muestra el perimetro calculado

        // crear un rectangulo con ancho 5 y alto 3
        rectangulo mi_rectangulo = new rectangulo(5, 3);
        System.Console.WriteLine("\nRectangulo:");
        System.Console.WriteLine("area: " + mi_rectangulo.Calcular_area()); //muestra el area calculada
        System.Console.WriteLine("Perimetro: " + mi_rectangulo.Calcular_perimetro()); //muestra el perimetro calculado
    }
}

    


