// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//------MELVIN ALEXANDER PEREZ RAMIREZ------
//ejercicio 1
//using (var contextdb = new ContextoDB())
//{
//    foreach (var item in contextdb.Estudiante)
//    {
//        Console.WriteLine(item.Id+" "+item.Nombres+" "+item.Apellidos+" "+item.Edad+" "+item.Sexo);
//    }
//}
//ejercicio2
//using (var contextdb = new ContextoDB())
//{
//    contextdb.Database.EnsureCreated();

//    var estudiante1 = new EstudianteUnab() { Nombres = "Pepita", Apellidos = "Perez" };

//    contextdb.Add(estudiante1);
//    contextdb.SaveChanges();

//    foreach (var item in contextdb.Estudiante)
//    {
//        Console.WriteLine(item.Nombres+" "+item.Apellidos);
//    }
//}
//ejercicio3

//bool agregarMasRegistros = true;

//using (var contextdb = new ContextoDB())
//{
//    contextdb.Database.EnsureCreated();

//    while (agregarMasRegistros)
//    {
//        Console.Write("Ingrese el nombre: ");
//        string nombre = Console.ReadLine();

//        Console.Write("Ingrese el apellido: ");
//        string apellido = Console.ReadLine();

//        Console.Write("Ingrese el sexo: ");
//        string sexo = Console.ReadLine();

//        Console.Write("Ingrese la edad: ");
//        int edad;
//        if (int.TryParse(Console.ReadLine(), out edad))
//        {
//            var estudiante = new EstudianteUnab() { Nombres = nombre, Apellidos = apellido, Sexo = sexo, Edad = edad };
//            contextdb.Add(estudiante);
//            contextdb.SaveChanges();

//            Console.WriteLine("Estudiante sera agregado ala base de datos.");

//            Console.Write("¿Desea agregar más registros? (SI/NO): ");
//            string respuesta = Console.ReadLine();
//            agregarMasRegistros = respuesta.Trim().ToUpper() == "SI";
//        }
//    }

//    Console.WriteLine("Registros en la base de datos:");
//    foreach (var estudiante in contextdb.Estudiante)
//    {
//        Console.WriteLine($"Nombre: {estudiante.Nombres}, Apellido: {estudiante.Apellidos}, Sexo: {estudiante.Sexo}, Edad: {estudiante.Edad}");
//    }
//}

//INGRESO DE REGISTRO SEMANA 13
//---------1--------------

//using (var contextdb = new ContextoDB())
//{
//    foreach (var item in contextdb.Estudiante)
//    {
//        Console.WriteLine(item.Id+" "+item.Nombres+" "+item.Apellidos+" "+item.Edad+" "+item.Sexo);
//    }
//}
//---------2--------------

//using (var DB = new ContextoDB())
//{
//    Console.WriteLine("Ingrese el ID del registro que desea modificar:");
//    var id = Console.ReadLine();
//    var persona = DB.Estudiante.FirstOrDefault(p => p.Id == Int32.Parse(id));

//    if (persona != null)
//    {
//        Console.WriteLine("¿Qué atributo desea modificar (NOMBRE, APELLIDO, SEXO o EDAD)?");
//        var atributoAModificar = Console.ReadLine();

//        switch (atributoAModificar.ToUpper())
//        {
//            case "NOMBRE":
//                Console.WriteLine("Ingrese el nuevo nombre:");
//                persona.Nombres = Console.ReadLine();
//                break;
//            case "APELLIDO":
//                Console.WriteLine("Ingrese el nuevo apellido:");
//                persona.Apellidos = Console.ReadLine();
//                break;
//            case "SEXO":
//                Console.WriteLine("Ingrese el nuevo sexo:");
//                persona.Sexo = Console.ReadLine();
//                break;
//            case "EDAD":
//                Console.WriteLine("Ingrese la nueva edad:");
//                persona.Edad = Convert.ToInt32(Console.ReadLine());
//                break;
//            default:
//                Console.WriteLine("Atributo no válido.");
//                break;
//        }

//        DB.SaveChanges();
//        Console.WriteLine("Registro modificado correctamente.");
//    }
//    else
//    {
//        Console.WriteLine("ID no encontrado. No se pudo realizar la modificación.");
//    }
//}
    
//---------3--------------
using (var DB = new ContextoDB())
{
    Console.WriteLine("ingrese el id del registro que desea eliminar");
    var id = Console.ReadLine();
    var persona = DB.Estudiante.SingleOrDefault(p => p.Id == Int32.Parse(id));
    if (persona != null )
    {
        DB.Estudiante.Remove(persona);
        DB.SaveChanges();
    }

}
//MELVIN ALEXANDER PEREZ RAMIREZ SEMANA 13
