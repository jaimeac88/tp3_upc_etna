﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETNA.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ETNADbModelContainer : DbContext
    {
        public ETNADbModelContainer()
            : base("name=ETNADbModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DocumentoReferencia> DocumentosReferencia { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SolicitudEntrada> SolicitudesEntrada { get; set; }
        public DbSet<DetalleSolicitudEntrada> DetalleSolicitudEntrada { get; set; }
        public DbSet<Kardex> Kardex { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<TipoLote> TipoLotes { get; set; }
        public DbSet<ProgramacionEncuesta> ProgramacionesEncuesta { get; set; }
    }
}
