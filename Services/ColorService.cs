using Model.Domain.ControlDeCalzado;
using Persistanse;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class ColorService : IColorService
    {
        public IEnumerable<Color> GetAll()
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
        public Color Get(string id)
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
        public Color GetEdit(string id)
        {
            var result = new Color();

            using (var db = new ApplicationDbContext())
            {
                result = db.Colores.Where(x => x.CodigoColor == id).Single();
            }

            return result;
        }
        public void Create(Color model)
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
        public void Update(Color model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.Colores.Where(x => x.CodigoColor == model.CodigoColor).Single();

                originalEntity.DescripcionColor = model.DescripcionColor;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(string id)
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
        public IEnumerable<Color> Buscar(string term)
        {

            IEnumerable<Color> busqueda;

            using (var db = new ApplicationDbContext())
            {
                busqueda = (IEnumerable<Color>)db.Colores.Where(x => x.DescripcionColor.Contains(term))
                    .Select(x=> x.DescripcionColor).Take(5).ToList();
            }

            return busqueda;

        }
    }
}

