namespace Biblioteca;

public interface IRepositorioCliente{
    void AgregarCliente(Cliente cliente);
    List<Cliente> GetClientes();
    Cliente? GetCliente(int DNI);
    void ModificarCliente(Cliente cliente);
    void EliminarCliente(int Dni);
}