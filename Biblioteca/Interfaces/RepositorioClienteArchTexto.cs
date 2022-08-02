
using System.IO;
using System;
namespace Biblioteca{

public class RepositorioClienteArchTexto:IRepositorioCliente{


    public void AgregarCliente(Cliente cliente){
            using (StreamWriter sw = File.AppendText("Clientes.txt")){
                sw.WriteLine($"{cliente.documento}|{cliente.nombre}|{cliente.apellido}|{cliente.direccion}|{cliente.fecha_nacimiento}|{cliente.fecha_compra}");
                Console.WriteLine("***********  Cliente Agregado Correctamente  ***********");
            }          
    }
    public List<Cliente>GetClientes(){
        List<Cliente>lista = new List<Cliente>();
        StreamReader sr = File.OpenText("Clientes.txt");
        string? linea;
        string[] campos = new string[5];
        while(!sr.EndOfStream){
            Cliente cliente = new Cliente();
            linea = sr.ReadLine();
            if(linea != null){
                campos = linea.Split('|');
            }  
            cliente.documento=Int32.Parse(campos[0]);
            cliente.nombre=campos[1];
            cliente.apellido=campos[2];
            cliente.direccion=campos[3];
            cliente.fecha_nacimiento=DateTime.Parse(campos[4]);
            cliente.fecha_compra=DateTime.Parse(campos[5]);
            lista.Add(cliente);
        
        }
        sr.Close();
        return lista;
    }

    public Cliente? GetCliente(int DNI){
        StreamReader sr = File.OpenText("Clientes.txt");
        Cliente cliente=new Cliente();
        string? linea;
        bool ok=false;
        while(!sr.EndOfStream && ok==false){
            linea = sr.ReadLine(); 
            string[]campos=new string[5];
            if(linea != null){
                campos = linea.Split("|");
            }
            if(Int32.Parse(campos[0]) == DNI){
                cliente.documento=Int32.Parse(campos[0]);
                cliente.nombre=campos[1];
                cliente.apellido=campos[2];
                cliente.direccion=campos[3];
                cliente.fecha_nacimiento=DateTime.Parse(campos[4]);
                cliente.fecha_compra=DateTime.Parse(campos[5]);
                ok=true;
            }

        }
        sr.Close();
        if(ok==false){
            return null;
        }
        else{
            return cliente;
        }
    }

    public void ModificarCliente(Cliente cliente){
        StreamWriter sw = File.CreateText("temporal.txt");
        StreamReader sr = new StreamReader("Clientes.txt");
        string? linea;
        string[] campos = new string[5];
        while(!sr.EndOfStream){
            linea = sr.ReadLine();
            if(linea != null){
                campos = linea.Split('|');
            }
            if(Int32.Parse(campos[0]) == cliente.documento){
                sw.WriteLine($"{cliente.documento}|{cliente.nombre}|{cliente.apellido}|{cliente.direccion}|{cliente.fecha_nacimiento}|{cliente.fecha_compra}");
            }
            else{
                sw.WriteLine(linea);
            }
        }
        sw.Close();
        sr.Close();
        File.Delete("Clientes.txt");
        File.Move("temporal.txt","Clientes.txt");
        Console.WriteLine("*****Cliente modificado exitosamente *****");
    }

    public void EliminarCliente(int Dni){
        StreamWriter sw = File.CreateText("temporal.txt");
        StreamReader sr = new StreamReader("Clientes.txt");
        string? linea;
        string[] campos = new string[5];
        while(!sr.EndOfStream){
            linea = sr.ReadLine();
            if(linea != null){
                campos = linea.Split('|');
            }
            if(Int32.Parse(campos[0]) != Dni){
                sw.WriteLine(linea);
            }
        }
        sw.Close();
        sr.Close();
        File.Delete("Clientes.txt");
        File.Move("temporal.txt","Clientes.txt");
        Console.WriteLine("***********  Cliente Eliminado Correctamente  ***********");
    }
    }
}
