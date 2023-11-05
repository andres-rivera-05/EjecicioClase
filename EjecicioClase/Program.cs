using EjecicioClase;

SuperHeroe super = new SuperHeroe();
SuperHeroe superDno = new SuperHeroe();
SuperHeroe supeTres = new SuperHeroe();


super.nombre="superman";
super.IdentidadSecreta = " Clrk Kent";
super.ciudad = "Metropolis";
super.puedeVolar = true;

Console.WriteLine($"Nombre: {super.nombre}");
Console.WriteLine($"Identidad Secreta: {super.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {super.ciudad}");
Console.WriteLine($"Puede Volar: {super.puedeVolar}");