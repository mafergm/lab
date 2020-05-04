using System;
using System.IO;
using System.Diagnostics;

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
        static string resp = "", cod = "";
        static string inicio = "", detalle = "";

        static void Main(string[] args)
        {
            encabezadous();
            acceso();
            buscar(inicio);
            buscart(inicio);
            while (volv != 3)
            {
                    principaladmin();
                    if (area == 1)
                    {
                        Process play = new Process();
                        play.StartInfo.FileName = "Inventario.txt";
                        play.Start();
                    }

                    else if (area == 2)
                    {
                        Process play = new Process();
                        play.StartInfo.FileName = "Usuarios.txt";
                        play.Start();
                    }

                    else if (area == 3)
                    {
                        Process play = new Process();
                        play.StartInfo.FileName = "Facturas.txt";
                        play.Start();

                    }
             
            
            }

        }

        static void buscar(string codigo)
        {
            string lupa = "busqueda";
            leer = File.OpenText(us);
            lupa = leer.ReadLine();

            while (lupa != "USUARIOS TRABAJADOR")
            { 
                if (codigo == cod)
                {
                    principaladmin();

                }

                else
                {
                    Console.WriteLine("Código incorrecto");
                }
            }
        }

        static void buscart(string codigo)
        {
            string lupa = "busqueda";
            leer = File.OpenText(us);
            lupa = leer.ReadLine();

            while (lupa != "USUARIOS ADMINISTRADOR")
            {
                if (codigo == cod)
                {
                    principaltrab();

                }

                else
                {
                    Console.WriteLine("Código incorrecto");
                }
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
            escribir=File.AppendText(us);
            escribir.WriteLine("USUARIOS\nNombre " +"Edad " +"Día de nacimiento " + "Puesto de trabajo" + "Código de acceso");
            escribir.Close();
        }

        static void datosdeusuario(string nomb, int edad, int naci, string trab, cod)
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

        static void principaladmin()
        {
            Console.WriteLine("Escriba el número según el área a la que desea entrar");
            Console.WriteLine("1. Inventario\n2. Usuarios\n3. Facturas");
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

        }

        static void principaltrab()
        {
            Console.WriteLine("Escriba el número según el área a la desea entrar.");
            Console.WriteLine("1. Cargar inventario\n2. Facturación");
            area = int.Parse(Console.ReadLine());
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