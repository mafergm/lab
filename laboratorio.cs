using System;
using System.IO;

namespace lab
{

    class Program
    {
        static string us = "Usuarios.txt";
        static string inv = "Inventario.txt";
        static string fac = "Facturas.txt";
        static FileStream archivo;
        static StreamReader lectura;
        static StreamWriter escritura;

        static int volv = 0, area = 0, total = 0;
        static string resp = "";
        static string inicio = "", detalle = "";

        static void Main(string[] args)
        {
            acceso();
            while (volv != 3)
            { 
             
            
            }

        }

        static string leer(string l)
        {
            string guardar = "";
            archivo = new FileStream(l, FileMode.Open, FileAccess.Read);
            leer = new StreamReader(archivo);
            guardar = leer.ReadToEnd();
            leer.Close();
            return guardar();
        }

        static void encabezadous()
        { 
        
        }

        static void datosdeusuario(string nomb, int edad, int naci, string trab, string cod)
        {
            escribir = File.AppendText(us);
            escribir.WriteLine(nomb + "-" + edad + "-" + naci + "-" + trab + "-" + cod);
            escribir.Close();
        }

        static void acceso()
        {
            Console.WriteLine("EMPRESA LOS PATOS");
            Console.WriteLine("\n");
            Console.Write("Escriba su código para acceder: ");
            inicio = Console.ReadLine();
            Console.WriteLine("\n");

        }

        static void areaus()
        {
            Console.WriteLine("\n");
            Console.WriteLine("¿Desea crear usuarios?");
            Console.WriteLine("a.Si\nb.No");
            string usu = Console.ReadLine();
            Console.WriteLine("\n");
            if (usu == "a")
            {
                datosusu();
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("USUARIOS REGISTRADOS");
                Console.WriteLine("Escriba z para mostrar.");
            }
        }

        static void usuarios()
        {
            string a = "";
            while (a != "b")
            {
                Console.WriteLine("DATOS DE USUARIO");
                Console.WriteLine("Ingrese nombre: ");
                string nomb = Console.ReadLine();
                Console.WriteLine("Ingrese edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese día de nacimiento: ");
                int naci = int.Parse(Console.ReadLine());
                Console.WriteLine("Puesto de trabajo: \na.Administrador   b.Trabajador");
                string trab = Console.ReadLine();
                Console.WriteLine("\n");
                if (trab == "a")
                {
                    string opciona = "admin" + edad + naci;
                    Console.WriteLine("Código para acceder:\n" + "" + opciona);
                }

                else
                {
                    string opciona = "trab" + edad + naci;
                    Console.WriteLine("Código para acceder:\n" + "" + opciona);

                }
                Console.WriteLine("\n");
                Console.WriteLine("Desea agregar otro usuario a. Si b. No");
                a = Console.ReadLine();
                Console.WriteLine("\n");

                datosdeusuario(nomb, edad, naci, trab, opciona);
            }
        }
    }
}