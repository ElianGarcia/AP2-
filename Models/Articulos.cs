using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
    public class Articulos
    {
        public Articulos()
        {
            Id = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }


        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Precio { get; set; }
    }
}
