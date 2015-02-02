jQuery(document).ready(function () {

    var $planets = jQuery(".planet>.space-object");

    for (var i = 0; i < $planets.length; i++) {
        rotate($planets[i]);
    }

    function rotate(spaceObject) {
        var f = 0,
            s = 0.1 * Math.PI / 180;

        setInterval(function() {
            f += s;
            spaceObject.style.left = 50 * Math.sin(f) + 'px';
            spaceObject.style.top = 100 * Math.cos(f) + 'px';
        }, 0.365);
    }
});

