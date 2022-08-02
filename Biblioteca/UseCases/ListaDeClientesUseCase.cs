namespace Biblioteca{
    public class ListaDeClientesUseCase{

        RepositorioClienteArchTexto rc= new RepositorioClienteArchTexto();

        public List<Cliente> Ejecutar(){
            return rc.GetClientes();
        }
    }
}