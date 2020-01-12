// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function listenForServerSideEvents(url){
        let source = new EventSource(url)

        source.onmessage = function (event){
            document.getElementById('targetDiv').innerHTML += "<ul>" + "<li>" + event.data + "</li>" + "</ul>" + '<br>';
        };

        source.onopen = function (event){
            document.getElementById('targetDiv').innerHTML = '<b>Connection Oppened.<b> <br><br>';
        };

        source.onerror = function (event){
            document.getElementById('targetDiv').innerHTML = '<b>Connection Closed.<b> <br><br>';
            // setTimeout(function(){
            //     window.location.reload();
            // }, 2000);
            source.close();
        };
}

document.getElementById("clickme").addEventListener("click", function(){
    listenForServerSideEvents('api/ServerSideEvent');
});