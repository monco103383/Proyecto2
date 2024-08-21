using System;

class mercado
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos a mercadito la roca");
        Console.WriteLine("ingrese Nombre Por Favor");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese su Edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elija los productos que va a comprar");
        Console.WriteLine("1.Carnes");
        Console.WriteLine("2.Snacks");
        Console.WriteLine("3.productos de limpiesa");
        string categoria = Console.ReadLine();

        if (categoria == "1")
        {
            Console.WriteLine("Esta es la categoria de las carnes elija la que va a comprar ");
            Console.WriteLine("1.carne para bistec");
            Console.WriteLine("2.carne para asar");
            Console.WriteLine("3.filete de res ");
            Console.WriteLine("4.costilla de res ");
            Console.WriteLine("5.cabeza de lomo de cerdo");
            string Carnes = Console.ReadLine();

            if (Carnes == "1")
            {
                Console.WriteLine("1.media libra");
                Console.WriteLine("2.una libra");
                Console.WriteLine("3.dos libras ");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para bistec que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 41;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }

                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para bistec que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 51;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para bistec que va a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 66;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Carnes == "2")
            {
                Console.WriteLine("1.media libra ");
                Console.WriteLine("2.una libra");
                Console.WriteLine("3.dos libras ");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para asar que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para asar que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 62;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne para asar que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 80;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "3")
            {
                Console.WriteLine("1.media libra");
                Console.WriteLine("2.una libra");
                Console.WriteLine("3.dos libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de filete de res que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 49;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de filete de res que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 61;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de filete de res que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 79;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "4")
            {
                Console.WriteLine("1.media libra");
                Console.WriteLine("2.una libra");
                Console.WriteLine("3.dos libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de costilla de res que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 34;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de costilla de res que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 72;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de costilla de res que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 93;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "5")
            {
                Console.WriteLine("1.media libra ");
                Console.WriteLine("2.una libra");
                Console.WriteLine("3.dos libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cabeza de lomo de cerdo que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 62;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cabeza de lomo de cerdo que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 77;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cabeza de lomo de cerdo que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 100;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }
        else if (categoria == "2")
        {
            Console.WriteLine("Esta es la categoria de Snacks elija lo que va a comprar ");
            Console.WriteLine("1.doritos ");
            Console.WriteLine("2.Takis fuego");
            Console.WriteLine("3.Zambos ");
            Console.WriteLine("4.galletas oreo ");
            Console.WriteLine("5.mani mixtos");
            string Snacks = Console.ReadLine();

            if (Snacks == "1")
            {
                Console.WriteLine("1.pequeño");
                Console.WriteLine("2.mediano");
                Console.WriteLine("3.grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de doritos  que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 7;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de doritos  que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 8;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de doritos  que va a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 10;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Snacks == "2")
            {

                Console.WriteLine("1.pequeño");
                Console.WriteLine("2.mediano");
                Console.WriteLine("3.grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Takis fuego que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Takis fuego que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Takis fuego que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 19;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Snacks == "3")
            {
                Console.WriteLine("1.pequeño");
                Console.WriteLine("2.mediano");
                Console.WriteLine("3.grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Zambos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 8;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Zambos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 10;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Zambos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 13;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Snacks == "4")
            {
                Console.WriteLine("1.pequeño");
                Console.WriteLine("2.mediano");
                Console.WriteLine("3.grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de galleta oreo que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de galleta oreo que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de galleta oreo que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Snacks == "5")
            {
                Console.WriteLine("1.pequeño");
                Console.WriteLine("2.mediano");
                Console.WriteLine("3.grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de mani mixtos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 5;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de mani mixtos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 6;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de mani mixtos que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 7;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }
        else if (categoria == "3")
        {
            Console.WriteLine("Esta es la categoria de productos de limpieza elija lo que va a comprar ");
            Console.WriteLine("1.Ace ");
            Console.WriteLine("2.Asistin");
            Console.WriteLine("3.Cloro Magia Blanca ");
            Console.WriteLine("4.Suavitel ");
            Console.WriteLine("5.Jabon");
            string Productos_Limpiesa = Console.ReadLine();

            if (Productos_Limpiesa == "1")
            {
                Console.WriteLine("1.Bote Pequeño");
                Console.WriteLine("2.Bote Mediano");
                Console.WriteLine("3.Bote Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Ace  que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Ace  que va a comprar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 37;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Ace  que va a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 48;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Productos_Limpiesa == "2")
            {
                Console.WriteLine("1.Bote Pequeño");
                Console.WriteLine("2.Bote Mediano");
                Console.WriteLine("3.Bote Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Asistin que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Asistin que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Asistin que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Productos_Limpiesa == "3")
            {
                Console.WriteLine("1.Bote Pequeño");
                Console.WriteLine("2.Bote Mediano");
                Console.WriteLine("3.Bote Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cloro Magia Blanca que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 45;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cloro Magia Blanca que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 56;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cloro Magia Blanca que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 72;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Productos_Limpiesa == "4")
            {
                Console.WriteLine("1.Bote Pequeño");
                Console.WriteLine("2.Bote Mediano");
                Console.WriteLine("3.Bote Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Suavitel que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 80;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Suavitel que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 100;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Suavitel que va  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 130;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Productos_Limpiesa == "5")
            {
                Console.WriteLine("1.Bote Pequeño");
                Console.WriteLine("2.Bote Mediano");
                Console.WriteLine("3.Bote Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Jabon que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Jabon que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 43;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Jabon que va a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 55;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }

    }
}

