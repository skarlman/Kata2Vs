// ==UserScript==
// @name         New Userscript
// @namespace    http://tampermonkey.net/
// @version      0.1
// @description  try to take over the world!
// @author       You
// @match        https://www.codewars.com/kata/515e188a311df01cba000003/train/csharp
// @grant        none
// ==/UserScript==

(function() {


//     var codeCont = document.getElementById('code_container');

    var zNode = document.createElement ('div');

    zNode.innerHTML = '<button id="myButton" type="button">'
                + 'Open in VS</button>'
                ;

    zNode.setAttribute ('id', 'myContainer');

    document.getElementsByClassName('page-title')[0].appendChild (zNode);

//--- Activate the newly added button.
document.getElementById ("myButton").addEventListener (
    "click", ButtonClickAction, false
);

function ButtonClickAction (zEvent) {

    var codeCont = document.getElementsByClassName('CodeMirror-code');


    navigator.clipboard.writeText("KATACODE:\n"+codeCont[0].innerText+"\n"+codeCont[1].innerText).then(function() {
    alert('success');
  }, function() {
    alert('fail');
  });

}




})();