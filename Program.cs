using System;
using System.Collections.Generic;


namespace M4
{
    class Program
    {
        static void Main(string[] args)
        {
            int bill5 = 5;
            int bill10 = 10;
            int bill20 = 20;
            int bill50 = 50;
            int bill100 = 100;
            int bill200 = 200;
            int bill500 = 500;

            int precioFinal = 0;

            string [] menu= new string[7];
            int [] precio = new int [7];

            List <string> pedido = new List<string>();

            Dictionary<int,string> insertInMenu = new Dictionary<int,string>();
            Dictionary<int, int> insertInPrecio = new Dictionary<int, int>();


            insertInMenu.Add(0, "Espagueti");
            insertInMenu.Add(1, "Hamburgesa");
            insertInMenu.Add(2, "Ensalada");
            insertInMenu.Add(3, "Paella");
            insertInMenu.Add(4, "Bocadillo");
            insertInMenu.Add(5, "Calamares");
            insertInMenu.Add(6, "Buffet");

            insertInPrecio.Add(0, bill10);
            insertInPrecio.Add(1, bill20);
            insertInPrecio.Add(2, bill5);
            insertInPrecio.Add(3, bill50);
            insertInPrecio.Add(4, bill100);
            insertInPrecio.Add(5, bill200);
            insertInPrecio.Add(6, bill500);

            for (int i = 0; i < menu.Length; i++)
            {
                menu[i] = insertInMenu[i];          
            }
            for (int i = 0; i < precio.Length; i++)
            {
                precio[i] = insertInPrecio[i];
            }

            for (int i = 0; i < 7; i++)
            {                             
                    Console.WriteLine("Plato: {0} con Precio: {1}",menu[i],precio[i]);               

            }        

            Boolean seguir = true;
            Boolean platoEnLista = false;
            do
            {
                Console.WriteLine("=====================");
                Console.WriteLine("¿Que desea comer?");

                pedido.Add(Console.ReadLine());

                for (int i = 0; i < menu.Length; i++)
                {
                    if (pedido.Contains(menu[i]))
                    {
                        Console.WriteLine("El plato esta en el menu");
                        switch (pedido)
                        {                        

                            default:
                                break;
                        }


                        for (int j = 0; j < precio.Length; j++)
                        {
                            precioFinal = precioFinal + precio[j];
                        }
                       
                    }
                    else
                    {
                       
                    }

                }


                Console.WriteLine("¿Es todo lo que desea?");
                String respuesta = Console.ReadLine().ToLower();

                if (respuesta=="si")
                {
                    seguir = false;
                }    

            } while (seguir==true);

            Console.WriteLine("Usted ha pedido: ");
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine(pedido[i],"\n");
            }

            Console.WriteLine("Precio final: {0}", precioFinal);

            
            

        }
    }
}
