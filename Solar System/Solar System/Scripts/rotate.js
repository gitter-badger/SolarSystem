jQuery(document).ready(function () {

    var $planets = jQuery(".planet>.space-object");

    for (var i = 0; i < $planets.length; i++) {
        rotate($planets[i]);
    }

    function rotate(spaceObject) {
        var f = 0,
            s = 2 * Math.PI / 180;

        setInterval(function() {
            f += s;
            spaceObject.style.left = 235 + 149 * Math.sin(f) + 'px';
            spaceObject.style.left = 235 + 149 * Math.cos(f) + 'px';
        }, 1000);
    }
});

