do
{
    Console.WriteLine("Introduzca una cadena de 40 caracteres");
    string? cadena = Console.ReadLine();

    if (cadena != null)
    {
        while (cadena.Length < 40)
        {
            Console.WriteLine("Error cadena de {0}", cadena.Length);
            Console.WriteLine("Introduzca una cadena de 40 caracteres");
            cadena = Console.ReadLine();
            if (cadena == null) return;
        }

        Console.WriteLine("Menú: ");
        Console.WriteLine("Opcion 1: Sustituir una palabra por otra");
        Console.WriteLine("Opcion 2: Buscar texto en la cadena");
        Console.WriteLine("Opcion 3: Buscar texto de inicio en la cadena");

        var Opcion = Console.ReadLine();

        switch (Opcion)
        {
            case "1":
                Console.WriteLine("Introduzca la palabra a sustituir y la sustituta ");

                string? busqueda = Console.ReadLine();
                
                if (busqueda != null)
                {
                    string[] Espacio = busqueda.Split(" ");

                    if(Espacio.Length == 2)
                    {
                        if (cadena.Contains(Espacio[0]))
                        {
                            cadena = cadena.Replace(Espacio[0], Espacio[1]);
                            Console.WriteLine("Nueva: ", cadena);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                
                break;

            case "2":
                Console.WriteLine("Introduzca un texto ");

                string? texto = Console.ReadLine();

                if (texto != null)
                {
                    if(texto.Contains(texto))
                    {
                        Console.WriteLine("Verdadero");
                    }
                    else
                    {
                        Console.WriteLine("Falso");
                    }
                }
                break;

            case "3":
                Console.WriteLine("Introduzca un texto ");

                string? inicio = Console.ReadLine();

                if (inicio != null)
                {
                    if (inicio.StartsWith(inicio))
                    {
                        Console.WriteLine("Verdadero");
                    }
                    else
                    {
                        Console.WriteLine("Falso");
                    }
                }
                break;
        }

    }
    else
    {
        return;
    }

} while (true);
     