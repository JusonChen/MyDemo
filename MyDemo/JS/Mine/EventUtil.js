var EventUtil = {
    addHandler: function (element,type,handlerFn) {
        if (element.addEventListener) {
            element.addEventListener(type, handlerFn, false);
        }
        else if (element.attachEvent) {
            element.attachEvent("on" + type, handlerFn);
        }
        else {
            element["on" + type] = handlerFn;
        }
    },
    removeHandler: function (element, type, handlerFn) {
        if (element.removeEventListener) {
            element.removeEventListener(type, handlerFn, false);
        }
        else if (element.detachEvent) {
            element.detachEvent("on" + type, handlerFn);
        }
        else {
            element["on" + type] = null;
        }
    },
    getEvent: function (event) {
        return event ? event : window.event;
    },
    getTarget: function (event) {
        return event.target || event.srcElement;
    },
    preventDefault: function (event) {
        if (event.preventDefault) {
            event.preventDefault();
        }
        else {
            event.returnValue = false;
        }
    },
    stopPropagation: function (event) {
        if (event.stopPropagation) {
            event.stopPropagation();
        }
        else {
            event.cancelBubble = true;
        }
    },
    getButton: function (event) {
        if (document.implementation.hasFeature("MouseEvents", "2.0")) {
            return event.button;
        }
        else {
            switch (event.button) {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    return 1;
                case 5:
                case 6:
                    return 2;
                case 7:
                    return 0;               
            }
        }
    },
    getCharCode: function (event) {
        if (typeof event.charCode == "number" && event.charCode!=0) {
            return event.charCode;
        } else {
            return event.keyCode;
        }
    },
    getClipboardData: function (event) {
        var clipBoardData = event.clipboardData || window.clipboardData;
        return clipBoardData.getData("text");
    },
    setClipboardData: function (event, value) {
        if (event.clipboardData) {
            return event.clipboardData.setData("text/plain", value);
        }
        else if (window.clipboardData) {
            return window.clipboardData.setData("text",value);
        }
    }
};