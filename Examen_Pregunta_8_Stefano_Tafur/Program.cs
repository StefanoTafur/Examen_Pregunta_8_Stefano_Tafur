using System;

// Definicion de la interfaz IPais
public interface IPais
{
    string ColorBandera();
    string Tamaño();
    string IdiomaOficial();
}

// Implementacion de la interfaz para Ecuador
public class Ecuador : IPais
{
    public string ColorBandera()
    {
        return "Amarillo, Azul, Rojo";
    }

    public string Tamaño()
    {
        return "283.561 km²";
    }

    public string IdiomaOficial()
    {
        return "Español";
    }
}

// Implementacion de la interfaz para Brasil
public class Brasil : IPais
{
    public string ColorBandera()
    {
        return "Verde, Amarillo, Azul, Blanco";
    }

    public string Tamaño()
    {
        return "8,51 millones km²";
    }

    public string IdiomaOficial()
    {
        return "Portugues";
    }
}

// Implementación de la interfaz para Andorra
public class Andorra : IPais
{
    public string ColorBandera()
    {
        return "Azul, Amarillo, Rojo";
    }

    public string Tamaño()
    {
        return "468 km²";
    }

    public string IdiomaOficial()
    {
        return "Catalan";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de los paises utilizando la interfaz
        IPais ecuador = new Ecuador();
        IPais brasil = new Brasil();
        IPais andorra = new Andorra();

        // Mostrar la informacion solicitada
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
    }
}
