using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class DefectoService
    {
        public static IEnumerable<Defecto> GetAll()
        {
            var result = new List<Defecto>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from defecto in db.Defectos
                          select defecto
                          ).ToList();
            }
            return result;
        }

        public static IEnumerable<Defecto> GetObservado()
        {
            var result = new List<Defecto>();

            using (var db = new ApplicationDbContext())
            {
                result = db.Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Observado).ToList();
            }

            return result;
        }

        public static IEnumerable<Defecto> GetReproceso()
        {
            var result = new List<Defecto>();

            using (var db = new ApplicationDbContext())
            {
                result = db.Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso).ToList();
            }

            return result;
        }



        public static Defecto Get(int id)
        {
            var result = new Defecto();

            using (var db = new ApplicationDbContext())
            {
                result = (from defecto in db.Defectos.Where(x => x.IdDefecto == id)
                          select defecto
                          ).Single();
            }
            return result;
        }

        public static Defecto GetEdit(int id)
        {
            var result = new Defecto();

            using (var db = new ApplicationDbContext())
            {
                result = db.Defectos.Where(x => x.IdDefecto == id).Single();
            }

            return result;
        }

        public static void Create(Defecto model)
        {
            using (var db = new ApplicationDbContext())
            {
                var Defecto = new Defecto();
                Defecto.IdDefecto = model.IdDefecto;
                Defecto.DescripcionDefecto = model.DescripcionDefecto;
                Defecto.TipoDefecto = model.TipoDefecto;

                db.Defectos.Add(Defecto);
                db.SaveChanges();
            }
        }

        public static void Update(Defecto model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.Defectos.Where(x => x.IdDefecto == model.IdDefecto).Single();

                originalEntity.DescripcionDefecto = model.DescripcionDefecto;
                originalEntity.TipoDefecto = model.TipoDefecto;

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
                    Defecto Defecto = db.Defectos.Where(x => x.IdDefecto == id).Single();

                    db.Defectos.Remove(Defecto);
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

