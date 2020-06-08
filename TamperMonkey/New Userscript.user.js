// ==UserScript==
// @name         New Userscript
// @namespace    http://tampermonkey.net/
// @version      0.1
// @description  try to take over the world!
// @author       You
// @match        https://www.codewars.com/kata/*
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

    document.getElementById('code').getElementsByClassName('expand')[0].getElementsByTagName('a')[0].click();
    document.getElementById('code').getElementsByClassName('shrink')[0].getElementsByTagName('a')[0].click();
    document.getElementById('fixture').getElementsByClassName('expand')[0].getElementsByTagName('a')[0].click();
    document.getElementById('fixture').getElementsByClassName('shrink')[0].getElementsByTagName('a')[0].click();


    var codeCont = document.getElementsByClassName('CodeMirror-code');

    var title = document.getElementsByClassName('game-title')[0].getElementsByTagName('h4')[0].innerText;

    navigator.clipboard.writeText("KATACODE:" + title + "\n"+codeCont[0].innerText+"\n"+codeCont[1].innerText).then(function() {

  }, function() {
    alert('fail');
  });

}




})();