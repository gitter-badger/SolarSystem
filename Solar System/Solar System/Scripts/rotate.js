jQuery(document).ready(function () {

    var $planets = jQuery(".planet>.space-object");

    for (var i = 0; i < $planets.length; i++) {
        rotate($planets[i]);

        var $satellites = $planets.find(".satellite>.space-object");

        for (var j = 0; j < $satellites.length; j++) {
            //rotate($satellites[j]);
        }
    }

    function rotate(spaceObject) {
        var f = Math.floor((Math.random() * 360) + 0),
            s = 0.1 * Math.PI / 180,
            interval = 0.1 * $(spaceObject).attr("data-period") / 10,
            isRetrograde = $(spaceObject).attr("data-is-retro"),
            semiMinorAxis = parseFloat($(spaceObject).attr("data-semi-minor")),
            semiMajorAxis = parseFloat($(spaceObject).attr("data-semi-major")),
            perihelion = parseFloat($(spaceObject).attr("data-perihelion")),
            radius = parseFloat($(spaceObject).attr("data-radius")),
            primaryRadius = parseFloat($(spaceObject).attr("data-primary-radius")),
            x = semiMajorAxis + primaryRadius,
            y = semiMinorAxis + primaryRadius+radius;

        setInterval(function () {

            if (isRetrograde == "True") {
                f -= s;
            } else {
                f += s;
            }

            spaceObject.style.left = x * Math.sin(f) + (semiMajorAxis-perihelion) + 'px';
            spaceObject.style.top = y * Math.cos(f) + 'px';
        }, interval);
    }
});