function generateQuerySelector(el) {
    if (el.tagName.toLowerCase() == "html")
        return "HTML";
    var str = el.tagName;
    str += (el.id != "") ? "#" + el.id : "";
    if (el.className) {
        var classes = el.className.split(/\s/);
        for (var i = 0; i < classes.length; i++) {
            str += "." + classes[i]
        }
    }
    if (document.querySelector(str) == el) return str;

    return generateQuerySelector(el.parentNode) + " > " + str;
}

(function () {
    var head = document.getElementsByTagName('head')[0];

    var style = document.createElement('style');
    style.setAttribute('type', 'text/css');
    style.innerHTML = `{style}`;

    var script1 = document.createElement('script');
    script1.setAttribute('type', 'text/javascript');
    script1.innerHTML = `{script1}`;

    (head ? head : document.body).appendChild(style);
    (head ? head : document.body).appendChild(script1);

}).call(this);