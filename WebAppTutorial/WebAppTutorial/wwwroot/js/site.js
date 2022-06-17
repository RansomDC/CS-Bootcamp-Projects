// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//Functions for the tutorial
// These are to be called on mouseover and mouseout to change the color of "stuff it"
function newColor() {
    document.getElementById("stuff_it").style.color = "blue";
}

function oldColor() {
    document.getElementById("stuff_it").style.color = "darkolivegreen";
}

var id = null;
function myMove() {
    var elem = document.getElementById("myAnimation");
    var pos = 1;
    var secondPos = 0;
    clearInterval(id);
    id = setInterval(frame, 10);
    function frame() {
        if (pos == 350) {
            secondPos++;
            elem.style.left = secondPos + 'px';
            if (secondPos == 350) {
                clearInterval(id);
            }
        } else {
            pos++;
            elem.style.top = pos + 'px';
            //elem.style.left = pos + 'px';
        }
    }
}