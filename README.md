# ServerSentEvent_Demo
This is a demo for [server-sent events](https://developer.mozilla.org/en/docs/WebSockets), which runs on an Asp.NetCore server, sends data over its stream every second to the listener. The listener uses [EventSource](https://developer.mozilla.org/en-US/docs/Web/API/EventSource) to subscribe to the server-sent events, and renders the data received on the page.

### LiveDemo : 

This demo is deployed on Azure @ https://sse-eventsource-demo.azurewebsites.net/

```javascript
var evtSource = new EventSource('api/ServerSentEvent');
var eventList = document.querySelector('ul');

evtSource.onmessage = function(e) {
  var newElement = document.createElement("li");

  newElement.textContent = "message: " + e.data;
  eventList.appendChild(newElement);
}
```

## Pre-requisites

1. [.Net core 3.1 SDK](https://www.microsoft.com/net/core#windows)
2. [Visual studio 2019](https://www.visualstudio.com/) OR [VSCode](https://code.visualstudio.com/) with [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) extension


## Trying out the demo

 1. Clone the Repo
 1. `git clone https://github.com/Chibuikekenneth/ServerSentEvent.git`
 1. Navigate to the Project folder
 1. `cd ServerSentEvent`
 1. Restore and build Project
    ```bash
    dotnet restore
    
    dotnet build
    ```
 1. Run Project
 1. `dotnet run`

