//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETNA.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Encuesta
    {
        public Encuesta()
        {
            this.PlantillaDetalle = new HashSet<PlantillaDetalle>();
        }
    
        public int Id { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaRespuesta { get; set; }
        public string Titulo { get; set; }
    
        public virtual ICollection<PlantillaDetalle> PlantillaDetalle { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Programacion Programacion { get; set; }
    }
}
