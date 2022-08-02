using System;

namespace Biblioteca{

    public class Persona{
        
        public string? nombre{get;set;}
        public string? apellido{get;set;}
        public string? direccion{get;set;}
        public int documento{get;set;}
        public DateTime fecha_nacimiento{get;set;}

        public Persona(string nom, string ap,string direc, int doc , DateTime fecha){
            nombre = nom;
            apellido = ap;
            direccion = direc;
            documento = doc;
            fecha_nacimiento = fecha;
        }
        public Persona(){}
       
    }
}