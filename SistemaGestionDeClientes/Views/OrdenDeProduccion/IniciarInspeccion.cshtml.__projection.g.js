/* BEGIN EXTERNAL SOURCE */
function name9() {
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

/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name20(/*************{
history.go(-1);
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

		$(document).ready(function () {
            			click(function () {
     				lizarCantidad(1);
            });

        				r').clic			) {			     actu				1);
          				;

   /****************************************************/d( 				n = /***********/;
            var cantidadActual = parseInt				').text());
            var nue					dActual + cantidad;

            i				 <			          alert('No se permiten numeros negativos');
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
function name12() {
/************************************************************/
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name13() {
/************************************************************/
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name14() {
BotonSumarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name15() {
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name16() {
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name17() {
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
            


        /********************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/
	
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name36() {
BotonSumarParDePrimera
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name31() {
BotonRestarParDePrimera
}
/37OURCE */
function name33() {
BotonRestarObsIzq
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNA38SOURCE */
function name34() {
BotonSumarRepro
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL 39URCE */
function name35() {
history.go(-1);
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL 40URCE */

        function BotonRestarParDePrimera() {
            //llamar a la funcion de arriba
            //$("#ParesDePrimera").html('model.ParesDePrimera*');

        }
        function BotonSumarParDePrimera() {
            //escribimos el total de pares directo de la op, o llamamos a una fuincion contadora de registros
            //$("#ParesDePrimera").html('/**********************/');
        }

        function BotonSumarObsIzq() {
            
        }

        function BotonsumarRepro() {
            

        function BotonRestarObsIzq() {
           
        }

		function BotonRestarRepro() {

		}
            


        /********************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/
	
/* END EXTERNAL SOURCE */
