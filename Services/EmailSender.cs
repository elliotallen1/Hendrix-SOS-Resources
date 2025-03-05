using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph.Me.SendMail;

public class GraphMailService
{
    private readonly GraphServiceClient _graphClient;

    public GraphMailService(IConfiguration configuration)
    {
        // var tenantId = configuration["AzureAd:TenantId"];
        // var clientId = configuration["AzureAd:ClientId"];
        // var clientSecret = configuration["AzureAd:ClientSecret"];

        // if (string.IsNullOrEmpty(tenantId) || string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        // {
        //     throw new InvalidOperationException("Azure AD credentials are missing in configuration.");
        // }

        DefaultAzureCredential credentials = new DefaultAzureCredential(true); //(new DefaultAzureCredentialOptions
        // {
        //     ExcludeEnvironmentCredential = true,
        //     ExcludeInteractiveBrowserCredential = true,
        //     ExcludeAzurePowerShellCredential = true,
        //     ExcludeSharedTokenCacheCredential = true,
        //     ExcludeVisualStudioCodeCredential = true,
        //     ExcludeVisualStudioCredential = true,
        //     ExcludeAzureCliCredential = true,
        //     ExcludeManagedIdentityCredential = false,
        // });

        var tokenCredential = new ManagedIdentityCredential(); //new DefaultAzureCredential(); //new ClientSecretCredential(tenantId, clientId, clientSecret);
        
        _graphClient = new GraphServiceClient(credentials, ["https://graph.microsoft.com/.default"]);

        
    }

    public async Task SendAsync(string toEmail, string subject, string body)
    {
        Console.WriteLine("SendAsync is called");
        var emailMessage = new Message
        {
            Subject = subject,
            Body = new ItemBody
            {
                ContentType = BodyType.Text,
                Content = body
            },
            ToRecipients = new List<Recipient>
            {
                new Recipient { EmailAddress = new EmailAddress { Address = toEmail } }
            }
        };

        await _graphClient.Me.SendMail.PostAsync(new SendMailPostRequestBody
        {
            Message = emailMessage,
            SaveToSentItems = true
        });
        Console.WriteLine("SendAsync is finished");
    }
}
