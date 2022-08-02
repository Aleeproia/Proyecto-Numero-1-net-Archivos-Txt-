using System;

namespace Biblioteca{
    public class Cliente:Persona{
        public DateTime  fecha_compra{get;set;}
        
        public TimeSpan FechaRetornoi{
            get{
                return DateTime.Now - fecha_compra; // resultado devuleve TimeSpan en lugar de DateTime.
            }
        }
        public Cliente(string nombre, string apellido, string direccion, int documento, DateTime fecha, DateTime fc):base(nombre,apellido,direccion,documento,fecha){
            this.fecha_compra = fc;
        }
        public Cliente(){}

        public override string ToString(){
            return apellido+", "+nombre+"("+documento+")"+" Dir:calle "+direccion+" F.nac: "+fecha_nacimiento+" Última compra: "+fecha_compra+" [CLIENTE]";
        }
        
    }
}
