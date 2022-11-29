        /* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53*/

        int Prompt(string message)
        {
            System.Console.Write($"{message} >");
            return Convert.ToInt32(Console.ReadLine());
        }

        int x1 = Prompt("Введите x1 ");
        int y1 = Prompt("Введите y1 ");
        int z1 = Prompt("Введите z1 ");
        int x2 = Prompt("Введите x2 ");
        int y2 = Prompt("Введите y2 ");
        int z2 = Prompt("Введите z2 ");
        double dlina = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

        System.Console.Write("Длина отрезка в 3D пространстве составляет: ");
        System.Console.WriteLine( "{0:0.00}" , dlina);