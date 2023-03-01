using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models
{
    public abstract class ObjetoEscuelaBase{
        public string Id { get; set; }
        
        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase(){
             this.Id=Guid.NewGuid().ToString();
        }

        public override string ToString(){
            return $"{Nombre},{Id}";
        }
    }
}