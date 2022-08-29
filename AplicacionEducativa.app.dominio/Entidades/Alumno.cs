
using System.Data;
using System;
using System.ComponentModel.DataAnnotations;
namespace AplicacionEducativa.app.dominio.Entidades{
    public class Alumno{
        [Key]
        public int id {get;set;} 
        public string nombre{get;set;} 

        public string apellido{get;set;} 

        public string direccion{get;set;} 
         public Materia materia{get;set;} 
    }
}