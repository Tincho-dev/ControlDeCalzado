/* BEGIN EXTERNAL SOURCE */
function name388() {
BotonSumarObsIzq()
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name389() {
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name390() {
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

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

        $(document).on('click', '.detail-link', function () {
            var id = $(this).data('id');
            $.ajax({
                url: '/OrdenDeProduccion/Details/' + id,
                type: 'GET',
                success: function (result) {
                    $('#detail-container').html(result);
                }
            });
        });
    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name62() {
BotonSumarObsIzq/*****/
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name30(663
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name31(664
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

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
            var numeroDeOrden = //***********/var cantidadActual = parseInt($('#lblcantidad').text());
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

        $(document).on('click', '.detail-link', function () {
            var id = $(this).data('id');
            $.ajax({
                url: '/OrdenDeProduccion/Details/' + id,
                type: 'GET',
                success: function (result) {
                    $('#detail-container').html(result);
                }
            });
        });
    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name28() {
BotonSumarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name29() {
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name30() {
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

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
            var numeroDeOrden = /***********/;
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

        $(document).on('click', '.detail-link', function () {
            var id = $(this).data('id');
            $.ajax({
                url: '/OrdenDeProduccion/Details/' + id,
                type: 'GET',
                success: function (result) {
                    $('#detail-container').html(result);
                }
            });
        });
    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name34() {
/************************************************************/
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name35() {
/************************************************************/
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name36() {
BotonSumarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name37() {
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name38() {
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name39() {
history.go(-1);
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

        function BotonRestarParDePrimera() {
            //llamar a la funcion de arriba
            //$("#ParesDePrimera").html('model.ParesDePrimera*');

        }
        function BotonSumarParDePrimera() {
            //escribimos el total de pares directo de la op, o llamamos a una fuincion contadora de registros
            //$("#ParesDePrimera").html('/**********************/');
        }

		function sumarJs() {
			$("#paresDePrimera").value = Controller.RegistrarParDePrimera(op.ParesDePrimera, "+");

		}

        function BotonSumarObsIzq() {

        }

		function BotonsumarRepro() {

		}

        function BotonRestarObsIzq() {

        }

		function BotonRestarRepro() {

		}
*************/
    
/* END EXTERNAL SOURCE */
