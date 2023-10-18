
    function MostrarSerie(IdSerie) {
        $.ajax(
            {
                type:'POST',
                dataType:'JSON',
                url:'/Home/VerInfoSerieAjax',
                data:{IdS: IdSerie},
                success:
                function(response)
                {
                    $("#Nombre").html(response.nombre);
                    $("#ImagenSerie").attr("src", "/" +response.imagenSerie);
                    $("#Sinopsis").html(response.sinopsis);
                    $("#AñoInicio").html("Año de inicio: " + response.añoInicio.substr(0,9));
                }
            });
    }
