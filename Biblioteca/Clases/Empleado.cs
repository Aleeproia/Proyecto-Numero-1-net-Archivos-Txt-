using System;

namespace Biblioteca{
    public class Empleado :Persona{
        public int numero_legajo{get;set;}

        public Empleado(string nombre, string apellido,string direccion, int documento, DateTime fecha, int numer):base(nombre, apellido,direccion, documento, fecha){
            this.numero_legajo = numer;
        }

        public Empleado(){}

        public override string ToString(){
            return apellido+", "+nombre+"("+documento+")"+" Dir:calle "+direccion+" F.nac: "+fecha_nacimiento+" Numero legajo: "+numero_legajo+" [EMPLEADO]";
        }
        
    }
}

   