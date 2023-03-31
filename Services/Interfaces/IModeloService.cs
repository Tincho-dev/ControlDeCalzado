using Model.Domain.ControlDeCalzado;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IModeloService
    {
        IEnumerable<Modelo> GetAll();
        Modelo Get(string id);
        Modelo GetEdit(string id);
        void Create(Modelo model);
        void Update(Modelo model);
        void Delete(string id);
    }
}
