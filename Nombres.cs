string[] nombres = { "Juan", "Maria", "Pedro", "Ana", "Luis", "Elena", "Diego", "Lucia", "Carlos", "Sofia" };
        string[] apellidos = { "Garcia", "Lopez", "Perez", "Rodriguez", "Sanchez", "Martinez", "Gomez", "Fernandez", "Diaz", "Alvarez" };

        Random rd = new Random();

        Console.WriteLine("Generando 5 nombres aleatorios:");

        for (int i = 0; i < 5; i++)
        {

            int indiceNombre = rd.Next(0, nombres.Length);
            int indiceApellido = rd.Next(0, apellidos.Length);


            Console.WriteLine($"{i + 1}. {nombres[indiceNombre]} {apellidos[indiceApellido]}");
        }
