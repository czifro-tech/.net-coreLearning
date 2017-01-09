var element = function (id) {
    return document.getElementById(id);
};
var loopVar = 10;

for (var c = 0; c < loopVar; c++) {
    element('test').innerHTML += '<div>I am number ' + c + ' of ' + loopVar + ' lines in this file</div>';
}