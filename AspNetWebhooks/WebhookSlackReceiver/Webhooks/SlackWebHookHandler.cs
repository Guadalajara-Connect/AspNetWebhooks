using Microsoft.AspNet.WebHooks;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebhookSlackReceiver.Webhooks
{
    public class SlackWebHookHandler : WebHookHandler
    {
        public SlackWebHookHandler()
        {
            //this.Receiver = SlackWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            NameValueCollection nvc;

            if (context.TryGetData<NameValueCollection>(out nvc))
            {
                string question = nvc["subtext"];
                string msg = string.Format("The answer to '{0}' is '{1}'.", question, "Often");

                SlackResponse reply = new SlackResponse(msg);
                context.Response = context.Request.CreateResponse(reply);
            }

            return Task.FromResult(true);
        }
    }
}