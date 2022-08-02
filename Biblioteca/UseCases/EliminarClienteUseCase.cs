namespace Biblioteca{

    public class EliminarClienteUseCase{

        RepositorioClienteArchTexto rc = new RepositorioClienteArchTexto();
        public void Ejecutar(int dni){
            try{
                if(rc.GetCliente(dni)!= null){
                    rc.EliminarCliente(dni);
                }
                else{
                    throw new Exception("El cliente no se encuentra en el archivo");
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }

    }

}