using Formas.Entities;
using Formas.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Formas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a Qtd de figuras: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape> { };

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Dados da Figura #{i}: ");
                Console.WriteLine("Retangulo ou Circulo (r/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("Cor (Black/Red/Blue): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(c == 'r' || c == 'R') {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(width, heigth, color));
                } else {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
                                               
            }

            Console.WriteLine("Shape Areas: ");

            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
