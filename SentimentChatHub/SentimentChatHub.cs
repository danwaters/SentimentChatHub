using Microsoft.AspNetCore.SignalR;
namespace SentimentChatHub
{
    public class SentimentChatHub : Hub
    {
        public void NewAnalyzedMessage(string username, string message, double sentiment)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.InvokeAsync("NewAnalyzedMessage", username, message, sentiment);
        }
    }
}