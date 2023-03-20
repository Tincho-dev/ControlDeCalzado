/* BEGIN EXTERNAL SOURCE */
function name19() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name20() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name21() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name22() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name23() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name24() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name25() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name26() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,1)
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
                data: {
                    numeroDeOrden: numeroDeOrden,
                    idHorarioDeControl: parseInt(/*************************/),
					cantidad: cantidad
				},
                success: function (response) {
                    $('#lblcantidad').text(response);
                }
            });
        }


/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */


        function btnActualizarDefecto(IdDefecto,id,pie,tipoDefecto,cantidad) {
			//var cantidadActual = parseInt($('#lblcantidad').text());
            //var id = `${descripcionDefecto}Contador`;
            var cantidadActual = parseInt($(`#${id}`).text());
            var nuevaCantidad = cantidadActual + cantidad;

            if (nuevaCantidad < 0) {
                alert('No se permiten numeros negativos');
                return;
            }

            $.ajax({
                type: "POST",
                url: "/**************************************************/",
                data: {
						idHorarioDeControl: parseInt(/*************************/),
						cantidad: cantidad,
						IdDefecto:IdDefecto,
						pie:pie,
						tipoDefecto:tipoDefecto},
				success: function (response) {
					console.log("Defecto registrado");
					console.log(cantidadActual);
					console.log(response);
					console.log(id);
                    $(`#${id}`).text(response);
                }
            });
        }

    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name448() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name449() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name450() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name451() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name452() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name453() {
btnActualizarDefecto(/*************/,'/***************/Izquierdo', /*******************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name454() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,-1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name455() {
btnActualizarDefecto(/*************/,'/***************/Derecho', /*****************/,/***************************/,1)
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
 SOURCE */
y.go(-1);
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

/***********/ion actualizarCantidad(cantidad) {
            var cantidadActual = parseInt($('#lblcantidad').text());
            var nuevaCantidad = cantidadActual + cantidad;

            if (nuevaCantidad < 0) {
                alert('No se permiten numeros negativos');
                return;
            }

     /****************************************************/          url: "/*************************************************/*************************/              idHorarioDeControl: parseInt(/*************************/),
					cantidad: cantidad
				},
                success: function (response) {
                    $('#lblcantidad').
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
   }

    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */


        function btnActualizarDefecto(IdDefecto,id,pie,tipoDefecto,cantidad) {
			//var cantidadActual = parseInt($('#lblcantidad').text());
            //var id = `${descripcionDefecto}Contador`;
            var cantidadActual = parseInt($(`#${id}`).text());
            var nuevaCantidad = cantidadActual + cantidad;

            if (nuevaCantidad < 0) {
                alert('No se permiten numeros negativos');
                return;
            }

     /**************************************************/            url: "/*********************************************/*************************/ata: {
						idHorarioDeControl: parseInt(/*************************/),
						cantidad: cantidad,
						IdDefecto:IdDefecto,
						pie:pie,
						tipoDefecto:tipoDefecto},
				success: function (response) {
					console.log("Defecto registreado");
					console.log(cantidadActual);
					console.log(id);
                    $(`#${id}`).
/* END EXTERNAL SOURCE */
    }
         /* BEGIN EXTERNAL SOURCE */

        $(document).on('click', '.detail-link'tion name21() {
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
