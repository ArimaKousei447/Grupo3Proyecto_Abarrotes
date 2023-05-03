using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public partial class Productos
    {
        [Inject] IProductoServicio productoServicio { get; set; }
        IEnumerable<Producto> listaProductos { get; set; }

<<<<<<< HEAD
=======

>>>>>>> 436537307f44024e9550e046a4c449f1878a2dd5
        protected override async Task OnInitializedAsync()
        {
            listaProductos = await productoServicio.GetLista();
        }
    }
}
