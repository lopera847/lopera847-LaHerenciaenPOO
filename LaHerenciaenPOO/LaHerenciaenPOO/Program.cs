using LaHerenciaenPOO.Clases;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== MENÚ DE FIGURAS GEOMÉTRICAS ===");
            Console.WriteLine("1. Crear Círculo");
            Console.WriteLine("2. Crear Triángulo");
            Console.WriteLine("3. Crear Rectángulo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearCirculo();
                    break;
                case "2":
                    CrearTriangulo();
                    break;
                case "3":
                    CrearRectangulo();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.\n");
                    break;
            }
        }
    }

    static void CrearCirculo()
    {
        Console.Write("Ingrese la posición X: ");
        double posicionX = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la posición Y: ");
        double posicionY = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el radio: ");
        double radio = double.Parse(Console.ReadLine());

        Circulo circulo = new Circulo(posicionX, posicionY, radio);
        MostrarResultados(circulo);
    }

    static void CrearTriangulo()
    {
        Console.Write("Ingrese la posición X: ");
        double posicionX = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la posición Y: ");
        double posicionY = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado #1 del triangulo: ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado #1 del triangulo: ");
        double lado2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado #1 del triangulo: ");
        double lado3 = double.Parse(Console.ReadLine());

        Triangulo triangulo = new Triangulo(posicionX, posicionY, lado1, lado2, lado3);
        MostrarResultados(triangulo);
    }

    static void CrearRectangulo()
    {
        Console.Write("Ingrese la posición X: ");
        double posicionX = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la posición Y: ");
        double posicionY = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la base: ");
        double basee = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura: ");
        double altura = double.Parse(Console.ReadLine());

        Rectangulo rectangulo = new Rectangulo(posicionX, posicionY, basee, altura);
        MostrarResultados(rectangulo);
    }

    static void MostrarResultados(Figura figura)
    {
        Console.WriteLine($"\nÁrea: {figura.CalcularArea():F2}");
        Console.WriteLine($"Perímetro: {figura.CalcularPerimetro():F2}\n");
    }
}