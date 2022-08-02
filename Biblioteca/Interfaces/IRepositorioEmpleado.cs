namespace Biblioteca;

public interface IRepositorioEmpleado{
    void AgregarEmpleado(Empleado empleado);
    List<Empleado>GetEmpleados();
    Empleado? GetEmpleado(int DNI);
    void ModificarEmpleado(Empleado empleado);
    void EliminarEmpleado(int DNI);
}
