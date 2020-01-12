using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static sse_eventsource.Helpers.RandomText;

namespace sse_eventsource.Controllers.Api
{
    [Route("api/ServerSideEvent")]
    [ApiController]
    public class ServerSideEventController : Controller
    {
        [HttpGet]
        public async Task Get()
        {
            int[] RandomTextArraySize = new int[30];
            
            var response  = Response;
            response.Headers.Add("Content-Type", "text/event-stream");

            for (int i = 0; i < RandomTextArraySize.Length; i++)
            {
                     System.Threading.Thread.Sleep(1000);

                    await response.WriteAsync($"data: {GetRandomSentence(15)} <b>Created at {DateTime.Now.ToString().ToString()}<b>\r\r\r");

                    await response.Body.FlushAsync();
            }
        }
    }
}