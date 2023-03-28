using Model.Domain.ControlDeCalzado;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IColorService
    {
        IEnumerable<Color> GetAll();
        Color Get(string id);
        Color GetEdit(string id);
        void Create(Color model);
        void Update(Color model);
        void Delete(string id);
        IEnumerable<Color> Buscar(string term);
    }
}
