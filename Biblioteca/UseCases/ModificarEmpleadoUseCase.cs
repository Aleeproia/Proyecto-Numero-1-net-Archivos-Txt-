namespace Biblioteca{
    public class ModificarEmpleadoUseCase{

        RepositorioEmpleadoArchTexto re= new RepositorioEmpleadoArchTexto();
        public void Ejecutar(Empleado empleado){
        try {
            if(re.GetEmpleado(empleado.documento) != null){
                re.ModificarEmpleado(empleado);
            }
            else{
                throw new Exception("Empleado no encontrado en el archivo");
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
      }
    }
}