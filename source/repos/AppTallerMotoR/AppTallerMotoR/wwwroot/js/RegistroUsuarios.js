$().ready(function (){
    $("#form-registro").validate({
        rules: {
            nombre: {
                required: true,
                minlength: 3,
                maxlength: 50,

            },
            cedula: {
                required: true,
                minlength: 3,
                maxlength: 20,
            },

            telefono: {
                required: true,
                minlength: 3,
                maxlength: 10,
            },

            direccion: {
                required: true,
                minlength: 3,
                maxlength: 30,
            },

         
        },

        messages: {

            nombre: {
                required: "Es requerido",
                minlength: "Debe tener mínimo 3 carácteres",
                maxlength: "Debe teber máximo 50 carácteres",

            },
            cedula: {
                required: "Es requerido",
                minlength: "Debe tener mínimo 3 carácteres",
                maxlength: "Debe teber máximo 20 carácteres",
            },

            telefono: {
                required: "Es requerido",
                minlength: "Debe tener mínimo 3 carácteres",
                maxlength: "Debe teber máximo 10 carácteres",
            },

            direccion: {
                required: "Es requerido",
                minlength: "Debe tener mínimo 3 carácteres",
                maxlength: "Debe teber máximo 30 carácteres",
            },



        }

    });

});