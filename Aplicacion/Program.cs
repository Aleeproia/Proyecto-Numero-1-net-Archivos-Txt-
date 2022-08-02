using Biblioteca;

/*Cliente cliente = new Cliente("Alejandro","Proia","345335",111111,new DateTime(1958,5,6),DateTime.Today);

new AgregarClienteUseCase().Ejecutar(cliente);*/
Console.ReadKey();

/*Empleado empleado = new Empleado("Alejandro","Proia","345335",111111,new DateTime(1958,5,6),56685);

new AgregarEmpleadoUseCase().Ejecutar(empleado);
Console.ReadKey();*/


//-----------------------------------------------------------------------------------------------------------------

/*var AgregarCliente = new AgregarClienteUseCase();

AgregarCliente.Ejecutar(new Cliente("Alejandro","Proia","345335",1233,new DateTime(1958,5,6),DateTime.Today));
AgregarCliente.Ejecutar(new Cliente("lalalaal","Proasdia","345335",99995,new DateTime(1958,5,6),DateTime.Today));
AgregarCliente.Ejecutar(new Cliente("nahuu","Pasda","345335",7896,new DateTime(1958,5,6),DateTime.Today));
AgregarCliente.Ejecutar(new Cliente("german","Prgaags","345335",11117,new DateTime(1958,5,6),DateTime.Today));

var AgregarEmpleado = new AgregarEmpleadoUseCase();

AgregarEmpleado.Ejecutar(new Empleado("Alejandro","Proia","345335",173,new DateTime(1958,5,6),123456));
AgregarEmpleado.Ejecutar(new Empleado("lalalaal","Proasdia","345335",95,new DateTime(1958,5,6),654987));
AgregarEmpleado.Ejecutar(new Empleado("nahuu","Pasda","345335",7854,new DateTime(1958,5,6),654321));
AgregarEmpleado.Ejecutar(new Empleado("german","Prgaags","345335",11437,new DateTime(1958,5,6),324598));
Console.ReadKey();*/


//-----------------------------------------------------------------------------------------------------------------

/*Cliente cliente = new Cliente("Alejandro","Proia","345335",7575,new DateTime(1958,5,6),DateTime.Today);
try{
    new AgregarClienteUseCase().Ejecutar(cliente);
} 
catch(Exception e){
    Console.WriteLine(e.Message);
}

Empleado empleado = new Empleado("Alejandro","Proia","345335",7575,new DateTime(1958,5,6),456789);
try{
    new AgregarEmpleadoUseCase().Ejecutar(empleado);
} 
catch(Exception e){
    Console.WriteLine(e.Message);
}
System.Console.ReadKey();*/

//-----------------------------------------------------------------------------------------------------------------

Cliente cliente =  new Cliente("asd123","rodriguez","345335",111111,new DateTime(1958,5,6),DateTime.Today);


new ModificarClienteUseCase().Ejecutar(cliente);

/*Empleado empleado =  new Empleado("sfgretsf","rodriguez","11111",1233,new DateTime(1958,5,6),4568524);


new ModificarEmpleadoUseCase().Ejecutar(empleado);*/


System.Console.ReadKey();

//-----------------------------------------------------------------------------------------------------------------

/*var lista = new Biblioteca.ListaDeClientesUseCase().Ejecutar();

foreach(var cli in lista){
    Console.WriteLine($"{cli.apellido} {cli.nombre} {cli.FechaRetornoi}diass");
}

var lista = new Biblioteca.ListaDeEmpleadosUseCase().Ejecutar();

foreach(var empleado in lista){
    Console.WriteLine($"{empleado.apellido} {empleado.nombre} {empleado.numero_legajo}diass");
}

Console.ReadKey();*/

//-----------------------------------------------------------------------------------------------------------------

/*new EliminarClienteUseCase().Ejecutar(111111);

//new EliminarEmpleadoUseCase().Ejecutar(1111);
Console.ReadKey();

//-----------------------------------------------------------------------------------------------------------------

/*var lista = new ListaDeClientesUseCase().Ejecutar();

foreach(var cli in lista){
    Console.WriteLine(cli);
}
var lista2 = new ListaDeEmpleadosUseCase().Ejecutar();

foreach(var empleado in lista2){
    Console.WriteLine(empleado);
}

Console.ReadKey();*/

//-----------------------------------------------------------------------------------------------------------------

/*var lista = new ListaDePersonasUseCase().Ejecutar();

foreach(var persona in lista){
    Console.WriteLine(persona);
}

Console.ReadKey();*/

