using Modelos;

namespace Blazor.Interfaces
{
    public interface IProductoServicio
    {
        Task<bool> Nuevo(Producto producto);
        Task<bool> Actualizar(Producto producto);
        Task<bool> Eliminar(string codigo);
        Task<IEnumerable<Producto>> GetLista();
        Task<Producto> GetPorCodigo(string codigo);
<<<<<<< HEAD

=======
>>>>>>> 436537307f44024e9550e046a4c449f1878a2dd5
    }
}