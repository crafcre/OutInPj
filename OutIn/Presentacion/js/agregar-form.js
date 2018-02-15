var Datos = {}
var contenedor;
window.onload = function () {
    contenedor = document.getElementById('ContentPlaceHolder1');
}

function crearform() {
    var nuevaDiv = document.createElement('div');
    nuevaDiv.classList.add('disenioDiv');
    nuevaDiv.innerHTML = '<h2>Nuevo Formulario </h2>';

    var labelPar = document.createElement('label');
    labelPar.innerHTML = "Parametro:  ";

    nuevaDiv.appendChild(labelPar);

    var inputPar = document.createElement('input');
    inputPar.type = "text";
    inputPar.Name = "Parametro";

    nuevaDiv.appendChild(inputPar);

    var labelVal = document.createElement('label');
    labelVal.innerHTML = "<br>Valor:  ";

    nuevaDiv.appendChild(labelVal);

    var inputVal = document.createElement('input');
    inputVal.type = "text";
    inputVal.Name = "Valor";

    nuevaDiv.appendChild(inputVal);


    var inputBTN = document.createElement('input');
    inputBTN.type = "button";
    inputBTN.value = "Guardar";
    inputBTN.onclick = guardarDatos;

    nuevaDiv.appendChild(inputBTN);

    //nuevaDiv.onclick=cambiarEstilo;
    contenedor.appendChild(nuevaDiv);
}

function guardarDatos(evento) {
    var obj = evento.target;
    alert(obj);

}

function limpiarTodo() {
    contenedor.innerHTML = '';
}
