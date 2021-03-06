﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETNA.MVC.Models.LO
{
    public class ListaSolicitudSalidaViewModel
    {
        [Key]
        [DisplayName("Código solicitud")]
        public int Id { get; set; }

        [DisplayName("Fecha Elaboración")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaElaboracion { get; set; }

        [DisplayName("Tipo de Salida")]
        public string TipoSalida { get; set; }

        [DisplayName("Elaborada por")]
        public string NombreEmpleado { get; set; }
    }
}