/* BEGIN EXTERNAL SOURCE */

        function updateSemaphor() {
            $.ajax({
                url: '/*******************************/',
                type: 'GET',
                dataType: 'json',
                success: function (result) {

                    if (result.contador == 0 && result.limiteInferior == 0 && result.limiteSuperior == 0) {
                        $('#verde').removeClass('green');
                        $('#amarillo').removeClass('yellow');
                        $('#rojo').removeClass('red');
                    } else if (result.contador > 0) {
                        $('#amarillo').removeClass('yellow');
                        $('#rojo').removeClass('red');
                        $('#verde').addClass('green');
                    } else if (result.contador >= result.limiteInferior) {
                        $('#rojo').removeClass('red');
                        $('#verde').removeClass('green');
                        $('#amarillo').addClass('yellow');
                    } else {
                        $('#amarillo').removeClass('yellow');
                        $('#verde').removeClass('green');
                        $('#rojo').addClass('red');
                    }
                }
            });
        }

        $(function () {
            updateSemaphor();
            setInterval(updateSemaphor, 5000);
        });
    
/* END EXTERNAL SOURCE */
