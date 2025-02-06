// Función para buscar productos o tiendas
function buscarProductos() {
    var inputBusqueda = document.getElementById("inputBusqueda").value.toLowerCase();
    var productos = document.querySelectorAll('.product-item');
    var tiendas = document.querySelectorAll('.store-item');

    // Filtrar productos
    productos.forEach(function(producto) {
        var nombreProducto = producto.querySelector('h3').innerText.toLowerCase();
        var descripcionProducto = producto.querySelector('p') ? producto.querySelector('p').innerText.toLowerCase() : '';
        if (nombreProducto.includes(inputBusqueda) || descripcionProducto.includes(inputBusqueda)) {
            producto.style.display = 'block';
        } else {
            producto.style.display = 'none';
        }
    });

    // Filtrar tiendas
    tiendas.forEach(function(tienda) {
        var nombreTienda = tienda.querySelector('h3').innerText.toLowerCase();
        var descripcionTienda = tienda.querySelector('p') ? tienda.querySelector('p').innerText.toLowerCase() : '';
        if (nombreTienda.includes(inputBusqueda) || descripcionTienda.includes(inputBusqueda)) {
            tienda.style.display = 'block';
        } else {
            tienda.style.display = 'none';
        }
    });
}

// Función para mostrar/ocultar detalles de las tiendas
function toggleDetails(tiendaId) {
    var details = document.getElementById('extraInfo' + tiendaId);
    if (details) {
        if (details.style.display === "none" || details.style.display === "") {
            details.style.display = "block";
        } else {
            details.style.display = "none";
        }
    } else {
        console.error("No se encontró el elemento con ID: extraInfo" + tiendaId);
    }
}

// Función para mostrar el botón "volver arriba"
window.onscroll = function() {
    var volverArriba = document.getElementById("volverArriba");
    if (document.body.scrollTop > 300 || document.documentElement.scrollTop > 300) {
        volverArriba.style.display = "block";
    } else {
        volverArriba.style.display = "none";
    }
};

// Función para hacer scroll hacia arriba
document.getElementById("volverArriba").onclick = function() {
    window.scrollTo({ top: 0, behavior: 'smooth' });
};

// Depuración: Verificar que el evento onclick de los botones funciona
document.addEventListener("DOMContentLoaded", function () {
    console.log("Página cargada y lista.");
});
