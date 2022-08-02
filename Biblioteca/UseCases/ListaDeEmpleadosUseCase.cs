namespace Biblioteca{

    public class ListaDeEmpleadosUseCase{
        RepositorioEmpleadoArchTexto re = new RepositorioEmpleadoArchTexto();

        public List<Empleado> Ejecutar(){
            return re.GetEmpleados();
        }
    }
}