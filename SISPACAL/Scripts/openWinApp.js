function openCalc() {
    var shell = new ActiveXObject("Wscript.shell");
    shell.run("c:\\Windows\\System32\\calc.exe");
}

function openWithParameters() {
    var shell = new ActiveXObject("Wscript.shell");
    var inputParams = "M|1111111|03|1234567|";
    shell.run("c:\\Windows\\System32\\TheCoolestProgramEver.exe " + inputParams);
}