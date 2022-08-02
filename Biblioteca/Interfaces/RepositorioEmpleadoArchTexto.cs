
using System.IO;

namespace Biblioteca{

public class RepositorioEmpleadoArchTexto:IRepositorioEmpleado{


    public void AgregarEmpleado(Empleado empleado){
            using (StreamWriter sw = File.AppendText("Empleado.txt")){
                sw.WriteLine($"{empleado.documento}|{empleado.nombre}|{empleado.apellido}|{empleado.direccion}|{empleado.fecha_nacimiento}|{empleado.numero_legajo}");
                Console.WriteLine("***********  Empleado Agregado Correctamente  ***********");
            }          
    }
    public List<Empleado>GetEmpleados(){
        List<Empleado>lista = new List<Empleado>();
        StreamReader sr = File.OpenText("Empleado.txt");
        string? linea;
        string[] campos = new string[5];
        while(!sr.EndOfStream){
            Empleado empleado = new Empleado();
            linea = sr.ReadLine();
            if(linea != null){
                campos = linea.Split('|');
            }  
            empleado.documento=Int32.Parse(campos[0]);
            empleado.nombre=campos[1];
            empleado.apellido=campos[2];
            empleado.direccion=campos[3];
            empleado.fecha_nacimiento=DateTime.Parse(campos[4]);
            empleado.numero_legajo=Int32.Parse(campos[5]);
            lista.Add(empleado);
        
        }
        sr.Close();
        return lista;
    }

    public Empleado? GetEmpleado(int DNI){
        StreamReader sr = File.OpenText("Empleado.txt");
        Empleado empleado=new Empleado();
        string? linea;
        bool ok=false;
        while(!sr.EndOfStream && ok==false){
            linea = sr.ReadLine(); 
            string[]campos=new string[5];
            if(linea != null){
                campos = linea.Split("|");
            }
            if(Int32.Parse(campos[0]) == DNI){
                empleado.documento=Int32.Parse(campos[0]);
                empleado.nombre=campos[1];
                empleado.apellido=campos[2];
                empleado.direccion=campos[3];
                empleado.fecha_nacimiento=DateTime.Parse(campos[4]);
                empleado.numero_legajo=Int32.Parse(campos[5]);
                ok=true;
            }

        }
        sr.Close();
        if(ok==false){
            return null;
        }
        else{
            return empleado;
        }
    }

    public void ModificarEmpleado(Empleado empleado){
        StreamWriter sw = File.CreateText("temporal.txt");
        StreamReader sr = new StreamReader("Empleado.txt");
        string? linea;
        string[] campos = new string[5];
        while(!sr.EndOfStream){
            linea = sr.ReadLine();
            if(linea != null){
                campos = linea.Split('|');
            }
            if(Int32.Parse(campos[0]) == empleado.documento){
                sw.WriteLine($"{empleado.documento}|{empleado.nombre}|{empleado.apellido}|{empleado.direccion}|{empleado.fecha_nacimiento}|{empleado.numero_legajo}");
                
            }
            else{
                sw.WriteLine(linea);
            }
        }
        sw.Close();
        sr.Close();
        File.Delete("Empleado.txt");
        File.Move("temporal.txt","Empleado.txt");
        Console.WriteLine("*****Empleado modificado exitosamente *****");
    }

    public void EliminarEmpleado(int Dni){
        StreamWriter sw = File.CreateText("temporal.txt");
        StreamReader sr = new StreamReader("Empleado.txt");
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
        File.Delete("Empleado.txt");
        File.Move("temporal.txt","Empleado.txt");
        Console.WriteLine("***********  Empleado Eliminado Correctamente  ***********");

    }
}

}