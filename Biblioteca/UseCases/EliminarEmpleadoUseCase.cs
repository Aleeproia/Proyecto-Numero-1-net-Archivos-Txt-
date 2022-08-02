namespace Biblioteca{

    public class EliminarEmpleadoUseCase{

        RepositorioEmpleadoArchTexto re = new RepositorioEmpleadoArchTexto();
        public void Ejecutar(int dni){
            try{
                if(re.GetEmpleado(dni)!= null){
                    re.EliminarEmpleado(dni);
                }
                else{
                    throw new Exception("El empleado no se encuentra en el archivo");
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }
}