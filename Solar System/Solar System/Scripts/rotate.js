jQuery(document).ready(function () {

    var $planets = jQuery(".planet>.space-object");

    for (var i = 0; i < $planets.length; i++) {
        rotate($planets[i]);
    }

    function rotate(spaceObject) {
        var f = Math.floor((Math.random() * 360) + 0),
            s = 0.1 * Math.PI / 180,
            interval = 0.1 * $(spaceObject).attr("data-period") / 100,
            isRetrograde = $(spaceObject).attr("data-is-retro"),
            semiMinorAxis = $(spaceObject).attr("data-semi-minor"),
            semiMajorAxis = $(spaceObject).attr("data-semi-major");

        setInterval(function () {

            if (isRetrograde == "True") {
                f -= s;
            } else {
                f += s;
            }

            spaceObject.style.left = semiMajorAxis * Math.sin(f) + 'px';
            spaceObject.style.top = semiMinorAxis * Math.cos(f) + 'px';
        }, interval);
    }
});

