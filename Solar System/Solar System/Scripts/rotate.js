jQuery(document).ready(function () {

	var $planets = $(".orbit>.space-object");

	for (var i = 0; i < $planets.length; i++) {
		$planets[i].name = $planets.attr("data-name");
		$planets[i].period = $planets.attr("data-orbital-period");
		$planets[i].aphelion = $planets.attr("data-aphelion");
		$planets[i].perihelion = $planets.attr("data-perihelion");
		$planets[i].radius = $planets.attr("data-radius");
		$planets[i].rotate = (function (object) {
			setInterval("rotate('" + object + "')", $planets[i].period * 1000);
		})($planets[i]);
	}

	function rotate(object) {
	    var x=
	}
});

