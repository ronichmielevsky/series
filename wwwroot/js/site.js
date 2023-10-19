
    function MostrarSerie(id) {        
        $.ajax(
            {
                url:'/Home/VerInfoSerieAjax',
                type:'GET',
                dataType:'JSON',                
                data:{IdSerie: id},
                success:
                    function(response) //en este caso response es un objeto SERIE
                    {                        
                        $("#TextoModalSerie").html(response.sinopsis);
                    }
            });
    }


    
    function MostrarActores(id) {        
         $.ajax(
           {
                 url:'/Home/VerInfoActoresAjax',
                 type:'GET',
               dataType:'JSON',                
                 data:{IdSerie: id},
                 success:
                     function(response)  //en este caso response es una lista de ACTORES
                     {   
                        console.log(response);
                        let text= "";
                         response.forEach(element => {
                             text += "<li>" + element.nombre + "</li>";
                             text+= " | "
                         });
                         $("#TextoModalActores").html(text);
                     }
             });
     }
    
    
     function MostrarTemporadas(id) {        
        $.ajax(
          {
                url:'/Home/VerInfoTemporadasAjax',
                type:'GET',
              dataType:'JSON',                
                data:{IdSerie: id},
                success:
                    function(response)  //en este caso response es una lista de ACTORES
                    {   
                       console.log(response);
                       let text= "";
                        response.forEach(element => {
                            text += "<li>" + element.tituloTemporada + "</li>";
                            text+= " | "
                        });
                        $("#TextoModalTemporadas").html(text);
                    }
            });
    }
