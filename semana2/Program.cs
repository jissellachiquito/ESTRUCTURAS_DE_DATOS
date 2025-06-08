
//crear clase que represente un triangulo
class triangulo
{
    //atributos
    private Double base_triangulo;  //atributo que guarda el valor de la base
    private Double altura;  //atributo que guarda el valor de la altura

    //metodo constructor ejerce la funcion de inicializar los valores de base y altura con los datos que recibe
    public triangulo(Double base_triangulo, Double altura)
    {
        // La palabra 'this' se usa para diferenciar entre el atributo y el parametro
        this.base_triangulo = base_triangulo;
        this.altura = altura;
    }

    //cálculo del area 
    public Double Calcular_area() // Calcular_area es una funcion que devuelve un valor double utilizada para calcular el area
    {
        // Usa la fórmula (base * altura) / 2 y no recibe argumentos porque utiliza los atributos del objeto
        return (base_triangulo * altura) / 2;
    }

    //cálculo del perimetro
    public Double Calcular_perimetro()// Calcular_perimetro es una funcion que devuelve un valor double, se usa para calcular el perimetro
    {
        // Asume que los tres lados del triángulo
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

    //cálculo del area 
    public Double Calcular_area() // Calcular_area es una funcion que devuelve un valor double
    {
        // aplica la formula ancho * alto y no requiere argumentos externos porque usa los atributos del objeto
        return ancho * alto;
    }

    //cálculo del perimetro
    public Double Calcular_perimetro() // Calcular_perimetro es una funcion que devuelve un valor double
    {
        // aplica la formula 2 * (ancho + alto)
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

    


