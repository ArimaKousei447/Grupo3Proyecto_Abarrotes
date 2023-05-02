using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public class ProductosBase
    {

        IEnumerable<Producto> ListaProductos { get; set; }
        [Inject] IProductoServicio productoServicio { get; set; }

        protected override async Task OnInitializedAsync() => ListaProductos = await productoServicio.GetLista();
    }
}