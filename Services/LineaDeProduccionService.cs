using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LineaDeProduccionService
    {
        public static IEnumerable<LineaDeProduccion> GetAll()
        {
            var result = new List<LineaDeProduccion>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from lin in db.LineasDeProduccion
                          select lin
                          ).ToList();
            }
            return result;
        }

        public static List<LineaDeProduccion> GetAllAviable()
        {
            var result = new List<LineaDeProduccion>();

            using (var db = new ApplicationDbContext())
            {
                //Agregar Logica para buscar solo las libres
                result = (from lin in db.LineasDeProduccion
                          select lin
                          ).ToList();
            }
            return result;
        }

        public static LineaDeProduccion Get(int id)
        {
            var result = new LineaDeProduccion();

            using (var db = new ApplicationDbContext())
            {
                result = (from lin in db.LineasDeProduccion.Where(x => x.NumeroLinea == id)
                          select lin
                          ).Single();
            }
            return result;
        }

        public static LineaDeProduccion GetEdit(int id)
        {
            var result = new LineaDeProduccion();

            using (var db = new ApplicationDbContext())
            {
                result = db.LineasDeProduccion.Where(x => x.NumeroLinea == id).Single();
            }

            return result;
        }

        public static void Create(LineaDeProduccion model)
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.LineasDeProduccion.Any(l => l.NumeroLinea == model.NumeroLinea))
                {
                    throw new Exception("Numero de linea ya existente");
                
                }
                var LineaDeProduccion = new LineaDeProduccion();
                LineaDeProduccion.NumeroLinea = model.NumeroLinea;

                db.LineasDeProduccion.Add(LineaDeProduccion);
                db.SaveChanges();
            }
        }

        public static void Update(LineaDeProduccion model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.LineasDeProduccion.Where(x => x.NumeroLinea == model.NumeroLinea).Single();

                originalEntity = model;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }



        public static void Delete(int id)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    LineaDeProduccion LineaDeProduccion = db.LineasDeProduccion.Where(x => x.NumeroLinea == id).Single();

                    db.LineasDeProduccion.Remove(LineaDeProduccion);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
