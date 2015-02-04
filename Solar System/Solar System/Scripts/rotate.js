jQuery(document).ready(function () {

    var $planets = jQuery(".planet>.space-object");

    for (var i = 0; i < $planets.length; i++) {
        rotate($planets[i]);
    }

    function rotate(spaceObject) {
        var f = Math.floor((Math.random() * 360) + 0),
            s = 0.1 * Math.PI / 180,
            interval = 0.1 * $(spaceObject).attr("data-period") / 10,
            isRetrograde = $(spaceObject).attr("data-is-retro"),
            semiMinorAxis = $(spaceObject).attr("data-semi-minor"),
            semiMajorAxis = $(spaceObject).attr("data-semi-major"),
            perihelion = $(spaceObject).attr("data-perihelion"),
            radius = $(spaceObject).attr("data-radius");

        setInterval(function () {

            if (isRetrograde == "True") {
                f -= s;
            } else {
                f += s;
            }

            spaceObject.style.left = (semiMajorAxis) * Math.sin(f) + (semiMajorAxis - perihelion - radius) + 'px';
            spaceObject.style.top = (semiMinorAxis) * Math.cos(f) - radius + 'px';
        }, interval);
    }
});

