var delta,
    isCall = false,
    zoomStep = 0.05;

if (!isCall) {
    var zoom = 1;
    isCall = true;
}

function addHandler(object, event, handler) {
    if (object.addEventListener) {
        object.addEventListener(event, handler, false);
    } else if (object.attachEvent) {
        object.attachEvent('on' + event, handler);
    } else alert("Обработчик не поддерживается");
}

addHandler(window, 'DOMMouseScroll', wheel);
addHandler(window, 'mousewheel', wheel);
addHandler(document, 'mousewheel', wheel);

function wheel(event) {
    event = event || window.event;

    if (event.wheelDelta) {
        delta = event.wheelDelta / 120;

        if (window.opera) {
            delta = -delta;
        }
    } else if (event.detail) {
        delta = -event.detail / 3;
    }

    if (event.preventDefault) {
        event.preventDefault();
    } else {
        event.returnValue = false;
    }

    if (delta > 0) {
        zoom += zoomStep;
        document.body.style.MozTransform = zoom;
        document.body.style.OTransform = zoom;
        document.body.style.zoom = zoom;
    } else {
        zoom -= zoomStep;
        document.body.style.MozTransform = zoom;
        document.body.style.OTransform = zoom;
        document.body.style.zoom = zoom;
    }
}

