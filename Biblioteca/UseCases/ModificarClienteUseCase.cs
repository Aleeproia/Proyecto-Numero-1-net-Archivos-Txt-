namespace Biblioteca{
    public class ModificarClienteUseCase{

        RepositorioClienteArchTexto rc = new RepositorioClienteArchTexto();
        public void Ejecutar(Cliente cliente){
        try {
            if(rc.GetCliente(cliente.documento) != null){
                rc.ModificarCliente(cliente);
            }
            else{
                throw new Exception("Cliente no encontrado en el archivo");
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
      }
    }
}