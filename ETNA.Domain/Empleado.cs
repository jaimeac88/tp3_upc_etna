
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
    
public partial class Empleado
{

    public Empleado()
    {

        this.Almacen = new HashSet<Almacen>();

        this.DocumentoReferencia = new HashSet<DocumentoReferencia>();

        this.SolicitudEntrada = new HashSet<SolicitudEntrada>();

        this.SolicitudSalida = new HashSet<SolicitudSalida>();

    }


    public int Id { get; set; }

    public string Nombres { get; set; }

    public string Apellidos { get; set; }

    public string Direccion { get; set; }

    public string Cargo { get; set; }



    public virtual UserProfile UserProfile { get; set; }

    public virtual ICollection<Almacen> Almacen { get; set; }

    public virtual ICollection<DocumentoReferencia> DocumentoReferencia { get; set; }

    public virtual ICollection<SolicitudEntrada> SolicitudEntrada { get; set; }

    public virtual ICollection<SolicitudSalida> SolicitudSalida { get; set; }

}

}
