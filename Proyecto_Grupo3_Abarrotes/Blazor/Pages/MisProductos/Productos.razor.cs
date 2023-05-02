using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public partial class Productos
    {
        [Inject] IProductoServicio productoServicio { get; set; }

        IEnumerable<Producto> ListaProductos { get; set; }

        protected override async Task OnInitializedAsync() => ListaProductos = await productoServicio.GetLista();
    }
}
