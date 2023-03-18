using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class ColorService
    {
        public static IEnumerable<Color> GetAll()
        {
            var result = new List<Color>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from col in db.Colores
                          select col
                          ).ToList();
            }
            return result;
        }



        public static Color Get(string id)
        {
            var result = new Color();

            using (var db = new ApplicationDbContext())
            {
                result = (from col in db.Colores.Where(x => x.CodigoColor == id)
                          select col
                          ).Single();
            }
            return result;
        }

        public static Color GetEdit(string id)
        {
            var result = new Color();

            using (var db = new ApplicationDbContext())
            {
                result = db.Colores.Where(x => x.CodigoColor == id).Single();
            }

            return result;
        }

        public static void Create(Color model)
        {
            using (var db = new ApplicationDbContext())
            {
                var color = new Color();

                color.CodigoColor = model.CodigoColor;
                color.DescripcionColor = model.DescripcionColor;

                db.Colores.Add(color);
                db.SaveChanges();
            }
        }

        public static void Update(Color model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.Colores.Where(x => x.CodigoColor == model.CodigoColor).Single();

                originalEntity.DescripcionColor = model.DescripcionColor;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }



        public static void Delete(string id)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    Color Color = db.Colores.Where(x => x.CodigoColor == id).Single();

                    db.Colores.Remove(Color);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Color> Buscar(string term)
        {

            IEnumerable<Color> busqueda;

            using (var db = new ApplicationDbContext())
            {
                busqueda = (IEnumerable<Color>)db.Colores.Where(x => x.DescripcionColor.Contains(term))
                    .Select(x=> x.DescripcionColor).Take(5).ToList();
            }

            return busqueda;

        }

        //public static IEnumerable<Color> Buscar(string palabra, string value)
        //{
        //    var FechaActual = DateTime.Parse(DateTime.Today.ToShortDateString());
        //    var db = new ApplicationDbContext();
        //    IEnumerable<ColorGrid> proyecto;

        //    ColorGrid Color = new ColorGrid();

        //    using (db)
        //    {
        //        proyecto = GetAll();

        //        if (!String.IsNullOrEmpty(palabra))
        //        {
        //            proyecto = from pr in db.Color.Where(x => x.Titulo.ToUpper().Contains(palabra.ToUpper()))
        //                       from cli in db.Clientes.Where(x => x.Id == pr.Id_Cliente)
        //                       select new ColorGrid
        //                       {
        //                           Id_Proyecto = pr.Id_Proyecto,
        //                           Titulo = pr.Titulo,
        //                           Descripcion = pr.Descripcion,
        //                           FechaInicio = pr.FechaInicio,
        //                           FechaFin = pr.FechaFin,
        //                           Id_Cliente = cli.DNI,
        //                           Costo = pr.Costo
        //                       };
        //        }

        //        proyecto = proyecto.ToList();
        //    }

        //    return proyecto;
        //}

     
    }
}

