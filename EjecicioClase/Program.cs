using EjecicioClase;

SuperHeroe super = new SuperHeroe();
SuperHeroe superDos = new SuperHeroe();
SuperHeroe supeTres = new SuperHeroe();


super.nombre="superman";
super.IdentidadSecreta = " Clrk Kent";
super.ciudad = "Metropolis";
super.puedeVolar = true;

Console.WriteLine($"Nombre: {super.nombre}");
Console.WriteLine($"Identidad Secreta: {super.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {super.ciudad}");
Console.WriteLine($"Puede Volar: {super.puedeVolar}");

superDos.nombre = "superman";
superDos.IdentidadSecreta = " Clrk Kent";
superDos.ciudad = "Metropolis";
superDos.puedeVolar = true;

Console.WriteLine($"Nombre: {super.nombre}");
Console.WriteLine($"Identidad Secreta: {super.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {super.ciudad}");
Console.WriteLine($"Puede Volar: {super.puedeVolar}");