
namespace Biblioteca{
    public class ListaDePersonasUseCase{
        public List<Persona> Ejecutar(){
            List<Persona>aux= new List<Persona>();
            var listaclientes = new ListaDeClientesUseCase().Ejecutar();
            foreach(var cliente in listaclientes){
                aux.Add(cliente);
            }
            var listaempleados = new ListaDeEmpleadosUseCase().Ejecutar();
            foreach(var empleado in listaempleados){
                aux.Add(empleado);
            }
            List<Persona> listord = aux.OrderBy(x => x.apellido).ThenBy(y => y.nombre).ToList();

            return listord;
        }
    } 

}