/* BEGIN EXTERNAL SOURCE */
function name21() {
btnRestarReproceso(/**********************/, 
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
funct122 name16() {
btnSumarReprocesoIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
funct223 name17() {
history.go(-1);
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

		$(document).ready(function () {
			$('#btnSumar').click(function () {
                actualizarCantidad(1);
            });

            $('#btnRestar').click(function () {
                actualizarCantidad(-1);
            });
        });

        function actualizarCantidad(cantidad) {
            var numeroDeOrden = "/***********/";
            var cantidadActual = parseInt($('#lblcantidad').text());
            var nuevaCantidad = cantidadActual + cantidad;

            if (nuevaCantidad < 0) {
                alert('No se permiten numeros negativos');
                return;
            }

            $.ajax({
                type: "POST",
                url: "/****************************************************/",
                data: { numeroDeOrden: numeroDeOrden, cantidad: cantidad },
                success: function (response) {
                    $('#lblcantidad').text(response);
                }
            });
        }
    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */


		$(document).ready(function () {
            $('#btnSumarReprocesoIzq').click(function () {
                ActualizarCantidadDefectos(1);
			});

            $('#btnRestarReprocesoIzq').click(function () {
                ActualizarCantidadDefectos(-1);
			});
		});

		function ActualizarCantidadDefectos(cantidad) {
			var numeroDeOrden = "/***********/"
			var cantidadActual = parseInt($('#cantidadReprocesoIzq').text());
			var nuevaCantidad = cantidadActual + cantidad;

			if (nuevaCantidad < 0) {
				alert('No se permiten numeros negativos');
				return;
			}

			$.ajax({
				type: "GET",
				url: "/************************************************************************/",
				data: { numeroDeOrden: numeroDeOrden, cantidad: cantidad },
				success: function (response) {
                    $('#cantidadReprocesoIzq').text(response);
				}
			});
        }
    
/* END EXTERNAL SOURCE */
