using CompanyWork;
using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Company gameDevCompany = new GameDevCompany();
            Company outSourcingCompany = new OutSourcingCompany();

            while (true)
            {
                Console.WriteLine("Seleccione puesto de trabajo:");
                Console.WriteLine("1. Programador de juegos");
                Console.WriteLine("2. Programador de software");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Empleados Programadores de juegos trabajando en:");
                        gameDevCompany.CreateSoftware();
                        break;
                    case "2":
                        Console.WriteLine("Empleados Programadores de software trabajando en:");
                        outSourcingCompany.CreateSoftware();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Puesto de trabajo incorrecto");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

