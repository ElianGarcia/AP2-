using ArticlesApp.Data;
using ArticlesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlesApp.Controllers
{
    public class ArticulosController
    {
        public bool Guardar(Articulos articulos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Articulos.Add(articulos);
            paso = db.SaveChanges() > 0;
            return paso;

        }
        public Articulos Buscar(int Id)
        {
            Contexto db = new Contexto();
            Articulos articulo = new Articulos();
            articulo = db.Articulos.Find(Id);
            return articulo;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            var eliminar = db.Articulos.Find(Id);
            db.Entry(eliminar).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public bool Modificar(Articulos articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(articulo).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;
        }
    }
}