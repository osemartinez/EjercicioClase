// See https://aka.ms/new-console-template for more information


 public class SuperHeroe //* Creamos la clase SuperHeroe 
{
    //* Creamos los atributos de la clase 
    public string nombre {  get; set; }
    public string identidadSecreta { get; set; }
    public string ciudad {  get; set; }
    public bool puedeVolar {  get; set; } //* bool lo ultilizamos para tener valores logicos, solo pueden ser 2, "True o False" (me sirve escribirlo para recordarlo)
    public string superPoder {  get; set; }

    public SuperHeroe() {
        puedeVolar = true;
    
    }



}

public class SuperPoder
{
    public string nombre {  get; set; } 
    public string descripcion { get; set; }
    public int nivel {  get; set; }
}

 class Objetos //* Cree esta clase para poder crear los objetos "SuperHeroe y SuperPoder" (No se si es una buen practica pero solo asi lo hice funcionar)
{
    public static void Main(string[] args)
    {
        //* Creamos un objeto Superheroe1
        SuperHeroe superHeroe1 = new SuperHeroe();
        superHeroe1.nombre = "Superman";
        superHeroe1.identidadSecreta = "Clark Kent";
        superHeroe1.ciudad = "Metrópolis";
        superHeroe1.puedeVolar = true;
        superHeroe1.superPoder = "Super Fuerza";

        //* Cremaos objeto superHeroe2

        SuperHeroe superHeroe2 = new SuperHeroe();
        superHeroe2.nombre = "Spiderman";
        superHeroe2.identidadSecreta = "Peter Parker";
        superHeroe2.ciudad = "Nueva York";
        superHeroe2.puedeVolar = false;
        superHeroe2.superPoder = "Sentido arácnido";

        //* Creamos objeto superHeroe3

        SuperHeroe superHeroe3 = new SuperHeroe();
        superHeroe3.nombre = "Batman";
        superHeroe3.identidadSecreta = "Bruno Diaz";
        superHeroe3.ciudad = "Gótica";
        superHeroe3.puedeVolar= false;
        superHeroe3.superPoder = "Ser Millonario";

        //* Creamos el objeto SuperPoder1
        SuperPoder superPoder1 = new SuperPoder();
        superPoder1.nombre = "Super Fuerza";
        superPoder1.descripcion = "Capcidad de levantar objetos muy persados";
        superPoder1.nivel = 9;

        //* Creamos el objeto SuperPoder2
        SuperPoder superPoder2 = new SuperPoder();
        superPoder2.nombre = "Sentido arácnido";
        superPoder2.descripcion = "sexto sentido que da alerta de peligro";
        superPoder2.nivel = 7;

        //* Creamos el objeto SuperPoder3
        SuperPoder superPoder3 = new SuperPoder();
        superPoder3.nombre = "Ser Millonario";
        superPoder3.descripcion = "Herencia de sus padres";
        superPoder3.nivel = 10;

        Console.WriteLine("Nombre: " + superHeroe1.nombre);
        Console.WriteLine("Identidad Secreta: " + superHeroe1.identidadSecreta);
        Console.WriteLine("Ciudad: " + superHeroe1.ciudad);
        Console.WriteLine("Puede volar: " + superHeroe1.puedeVolar);
        Console.WriteLine("Super poder: " + superPoder1.nombre);
        Console.WriteLine("Descripcion: " + superPoder1.descripcion);
        Console.WriteLine("Nivel: " + superPoder1.nivel);
        Console.WriteLine();

        Console.WriteLine("Nombre: " + superHeroe2.nombre);
        Console.WriteLine("Identidad Secreta: " + superHeroe2.identidadSecreta);
        Console.WriteLine("Ciudad: " + superHeroe2.ciudad);
        Console.WriteLine("Puede volar: " + superHeroe2.puedeVolar);
        Console.WriteLine("Super poder: " + superPoder2.nombre);
        Console.WriteLine("Descripcion: " + superPoder2.descripcion);
        Console.WriteLine("Nivel: " + superPoder2.nivel);
        Console.WriteLine();


        Console.WriteLine("Nombre: " + superHeroe3.nombre);
        Console.WriteLine("Identidad Secreta: " + superHeroe3.identidadSecreta);
        Console.WriteLine("Ciudad: " + superHeroe3.ciudad);
        Console.WriteLine("Puede volar: " + superHeroe3.puedeVolar);
        Console.WriteLine("Super poder: " + superPoder3.nombre);
        Console.WriteLine("Descripcion: " + superPoder3.descripcion);
        Console.WriteLine("Nivel: " + superPoder3.nivel);
        Console.WriteLine();
    }
      

}




