using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using OpenAI_API;

namespace EasyReqAssist.API
{
    public class OpenAIChatClient
    {
        private readonly string ApiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User);

        public async Task<string> GetChatRatingResponse(string korisnikovZahtjev)
        {
            OpenAIAPI api = new OpenAIAPI(ApiKey);

            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("Vi ste iskusni mentor sistemskog inženjeringa specijaliziran za softverske zahtjeve. Vaš cilj je pružiti točne smjernice i pomoći studentu da napiše sveobuhvatne i usklađene softverske zahtjeve slijedeći ove tri karakteristike INCOSE smjernica: " +
                "C3 - Need statements must be written such that the stakeholder intent is clear. Requirement statements must be stated such that the requirement can be interpreted in only one way by all the intended readers. " +
                "C4 - The requirement statement sufficiently describes the necessary capability, characteristic, constraint, or quality factor to meet the need without needing other information to understand the requirement. " +
                "C5 - The stakeholder need or requirement statement should state a single capability, characteristic, constraint, or quality factor.");

            chat.AppendUserInput("Molim provjeri mi ovaj zahtjev: " + korisnikovZahtjev);

            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }

        public async Task<string> GetChatRatingResponseV2(string korisnikovZahtjev)
        {
            using (HttpClient klijent = new HttpClient()) //slanje HTTP zahtjeva web servisu
            {
                try
                {
                    //stavlja da Authorization header zahtjeva uključuje API ključ kao Bearer token
                    klijent.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);

                    //anoniman objekt koji sadrži podatke za slanje API-u
                    //messages predstavljaju stvarne razgovore, "role" je za simuliranje uloge u razgovoru, a "content" je ono što se šalje
                    var requestData = new {
                        model = "gpt-3.5-turbo",
                        messages = new[]
                        {
                        new
                        {
                            role = "system",
                            content = "Vi ste iskusni mentor sistemskog inženjeringa specijaliziran za softverske zahtjeve. Vaš cilj je pružiti točne smjernice i pomoći studentu da napiše sveobuhvatne i usklađene softverske zahtjeve slijedeći ove tri karakteristike INCOSE smjernica: " +
                            " C3 - Need statements must be written such that the stakeholder intent is clear. Requirement statements must be stated such that the requirement can be interpreted in only one way by all the intended readers." +
                            " C4 - The requirement statement sufficiently describes the necessary capability, characteristic, constraint, or quality factor to meet the need without needing other information to understand the requirement." +
                            " C5 - The stakeholder need or requirement statement should state a single capability, characteristic, constraint, or quality factor."
                        },
                        new
                        {
                            role = "user",
                            content = "Molim provjeri mi ovaj zahtjev: " + korisnikovZahtjev
                        }
                    }
                    };

                    //pretvara requestData u JSON i šalje ga kao sadržaj zahtjeva
                    var requestJson = JsonSerializer.Serialize(requestData);
                    //StringContent stvara text prikladan za klijent/server komunikaciju
                    var sadrzaj = new StringContent(requestJson, Encoding.UTF8, "application/json");

                    //šalje POST zahtjev na API
                    var odgovor = await klijent.PostAsync("https://api.openai.com/v1/chat/completions", sadrzaj);

                    if (odgovor.IsSuccessStatusCode)
                    {
                        var responseContent = await odgovor.Content.ReadAsStringAsync();
                        return responseContent;
                    }
                    else
                    {
                        var errorMessage = $"Neuspješan zahtjev na API sa statusnim kodom: {odgovor.StatusCode}";
                        return errorMessage;
                    }
                }
                catch (Exception ex)
                {
                    return $"Greška: {ex.Message}";
                }
            }
        }

        public async Task<string> GetChatAlternativeFormulations(string korisnikovZahtjev)
        {
            OpenAIAPI api = new OpenAIAPI(ApiKey);

            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("Vi ste iskusni mentor sistemskog inženjeringa specijaliziran za softverske zahtjeve. Vaš cilj je pružiti točne smjernice i pomoći studentu da napiše sveobuhvatne i usklađene softverske zahtjeve.");

            chat.AppendUserInput("Napiši mi nekoliko alternativne formulacije za sljedeći zahtjev: " + korisnikovZahtjev);

            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }

        public async Task<string> GetChatRelatedRequirements(string korisnikovZahtjev)
        {
            OpenAIAPI api = new OpenAIAPI(ApiKey);

            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("Vi ste iskusni mentor sistemskog inženjeringa specijaliziran za softverske zahtjeve. Vaš cilj je pružiti točne smjernice i pomoći studentu da napiše sveobuhvatne i usklađene softverske zahtjeve.");

            chat.AppendUserInput("Napiši mi nekoliko drugih zahtjeva koji bi bili povezani s ovim: " + korisnikovZahtjev);

            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }
    }
}
