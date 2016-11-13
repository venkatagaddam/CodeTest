String.prototype.capitalise = function () {
    return this.replace(/^[a-z]/, l => l.toUpperCase());
}

String.prototype.camelCaseToSpineCase = function () {
    var noCamel = this.replace(/(\B[A-Z])/g, ' $1');
    var newSpine = noCamel.replace(/\s|_/g, "-");
    return newSpine.toLowerCase();
}

String.prototype.spineCaseToCamelCase = function () {
    var str = this.replace(/([-][a-z])/g, function ($1) { return $1.toUpperCase().replace('/[-]/', ''); });
    str = str.replace(/(^|\s)[a-z]/g, function (f) { return f.toUpperCase(); })
    str = str.replace(/-/g, '').replace(/ /g, function ($1) { return $1.toUpperCase().replace(/ /g, ''); });
    return str.replace(/^(.)/, function ($1) { return $1.toLowerCase(); })
}

String.prototype.format = function () {
    var args = arguments;
    return this.replace(/{(\d+)}/g, function (match, number) {
        return typeof args[number] != 'undefined'
          ? args[number]
          : match
        ;
    });
}