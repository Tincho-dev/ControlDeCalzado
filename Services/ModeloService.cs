using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class ModeloService
    {
        public static IEnumerable<Modelo> GetAll()
        {
            var result = new List<Modelo>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from col in db.Modelos
                          select col
                          ).ToList();
            }
            return result;
        }



        public static Modelo Get(string id)
        {
            var result = new Modelo();

            using (var db = new ApplicationDbContext())
            {
                result = (from col in db.Modelos.Where(x => x.Sku == id)
                          select col
                          ).Single();
            }
            return result;
        }

        public static Modelo GetEdit(string id)
        {
            var result = new Modelo();

            using (var db = new ApplicationDbContext())
            {
                result = db.Modelos.Where(x => x.Sku == id).Single();
            }

            return result;
        }

        public static void Create(Modelo model)
        {
            using (var db = new ApplicationDbContext())
            {
                var modelo = new Modelo();
                modelo.Sku = model.Sku;
                modelo.Denominacion = model.Denominacion;
                modelo.LimiteInferiorDeObservado = model.LimiteInferiorDeObservado;
                modelo.LimiteInferiorDeReproceso = model.LimiteInferiorDeReproceso;
                modelo.LimiteSuperiorDeObservado = model.LimiteSuperiorDeObservado;
                modelo.LimiteSuperiorDeReproceso = model.LimiteSuperiorDeReproceso;

                db.Modelos.Add(modelo);
                db.SaveChanges();
            }
        }

        public static void Update(Modelo model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.Modelos.Where(x => x.Sku == model.Sku).Single();

                originalEntity.Denominacion = model.Denominacion;
                originalEntity.LimiteInferiorDeObservado = model.LimiteInferiorDeObservado;
                originalEntity.LimiteInferiorDeReproceso = model.LimiteInferiorDeReproceso;
                originalEntity.LimiteSuperiorDeObservado = model.LimiteSuperiorDeObservado;
                originalEntity.LimiteSuperiorDeReproceso = model.LimiteSuperiorDeReproceso;

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
                    Modelo Modelo = db.Modelos.Where(x => x.Sku == id).Single();

                    db.Modelos.Remove(Modelo);
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
