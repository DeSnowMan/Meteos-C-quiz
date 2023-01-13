#nullable disable
Console.Clear();
Console.WriteLine("Hola, Usario nuevo y bienvenida al concurso de Meteos!");

bool Loop = true;

while (Loop) {
    double Score = 0;
    Console.WriteLine("esta listo?");
    string Ready = Console.ReadLine();

    if (Ready == "Si" || Ready == "si" || Ready == "yes" || Ready == "Yes") {
        Console.WriteLine("vamos iniciar!");
    } else {
        Loop = false;
    };

    Console.WriteLine("Pregunta 1:");
    Console.WriteLine("cual es el nombre para la nave espacial que los Geolitia usar para viajar entre las planetas");
    string Repuesta1 = Console.ReadLine();
    if (Repuesta1 == "Metamo Ark" || Repuesta1 == "metamo ark" || Repuesta1 == "MetamoArk" || Repuesta1 == "metamoark") {
        Console.WriteLine("Correcto!");
        Score++;
    } else {
        Console.WriteLine("Incorrecto! la repuesta correcta es: Metamo Ark");
    };


    Console.WriteLine("Pregunta 2:");
    Console.WriteLine("cual de las planeta es la 'Amenaza Del Universo y la creador del caos universal'");
    string Repuesta2 = Console.ReadLine();

    if (Repuesta2 == "Meteo" || Repuesta2 == "METEO" || Repuesta2 == "meteo" || Repuesta2 == "Planeta Meteo") {
        Console.WriteLine("Correcto!");
        Score++;
    } else {
        Console.WriteLine("Incorrecto! la repuesta correcta es: Meteo");
    };

    Console.WriteLine("Pregunta 3:");
    Console.WriteLine("como se llaman los nativos de la planeta Gravitas");
    string Repuesta3 = Console.ReadLine();

    if ( Repuesta3 == "Gravitasianeses" || Repuesta3 == "gravitasianses" || Repuesta3 == "GRAVITASIANSES") {
        Console.WriteLine("Correcto!");
        Score++;
    } else {
        Console.WriteLine("Incorrecto! la repuesta correcta es: Gravitasianeses");
    };

    Console.WriteLine("Pregunta 4:");
    Console.WriteLine("cual dos planetas tienen un conexion para los tecnologia");
    string Repuesta4 = Console.ReadLine();

    if (Repuesta4 == "Bavoom y Anasaze" || Repuesta4 == "Bavoom, Anasaze" || Repuesta4 == "Anasaze, Bavoom" || Repuesta4 == "Anasaze y Bavoom" ) {
    Console.WriteLine("Correcto!");
        Score++;
    } else {
        Console.WriteLine("Incorrecto! la repuesta correcta es: Bavoom y Anasaze");
    };

    Console.WriteLine("Pregunta 5:");
    Console.WriteLine("Cual es la nombre por los nativos y la planeta que solo tiene 32 habitantes");
    string Repuesta5 = Console.ReadLine();

    if (Repuesta5 == "Magmoriones y Magmor" || Repuesta5 == "Magmoriones, Magmor" || Repuesta5 == "Magmor y Magmoriones" || Repuesta5 == "Magmor, Magmoriones") {
        Console.WriteLine("Correcto!");
        Score++;
    } else {
        Console.WriteLine("Incorrecto! la repuesta correcta es: Magmoriones y Magmor");
    };

    Console.WriteLine("Pregunta 6:");
    Console.WriteLine("Cual es tu planeta favorita de meteos");
    string Repuesta6 = Console.ReadLine();
    Console.WriteLine("Muy bien!");

    Score = Score / 4 * 100;
    Console.WriteLine($"Gracias, Tu marcador es {Score}%");
    Loop = false;

};
