﻿using System;

public class Producto
{
    // Propiedades de la clase
    public int Id { get; set; } // ID del producto (numérico)
    public string Nombre { get; set; } = string.Empty; // Nombre del producto
    public string Unidad { get; set; } = string.Empty; // Unidad de medida
    public double[] Precios { get; set; } // Array para manejar tres precios

    // Constructor por defecto
    public Producto()
    {
        Precios = new double[3]; // Inicializar el array con tres precios
    }

    // Método para registrar un producto
    public void RegistrarProducto(int id, string nombre, string unidad, double[] precios)
    {
        if (precios.Length != 3)
        {
            throw new ArgumentException("Debe proporcionar exactamente tres precios.");
        }

        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }

    // Método para mostrar la información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}\nNombre: {Nombre}\nUnidad: {Unidad}\nPrecios: {string.Join(", ", Precios)}");
    }
}

// Programa principal para probar la clase
class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Producto
        Producto producto = new Producto();

        // Datos del producto
        int id = 101;
        string nombre = "Laptop";
        string unidad = "Unidad";
        double[] precios = { 1200.50, 1300.75, 1400.99 };

        // Registrar el producto
        producto.RegistrarProducto(id, nombre, unidad, precios);

        // Mostrar la información del producto
        producto.MostrarInformacion();
    }
}