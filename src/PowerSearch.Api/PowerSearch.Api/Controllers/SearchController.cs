using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PowerSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        //https://docs.microsoft.com/pt-br/dotnet/api/overview/azure/search.documents-readme
        //https://www.youtube.com/watch?v=Mj9h9LHSunw
        [HttpGet("{data}")]
        public async Task<IActionResult> Get(string data)
        {

            try
            {
                string indexName = "powersearch-indice";
                Uri endpoint = new Uri("https://teadit.search.windows.net");
                string key = "A1AB68E478F2089680BD242271E622F4";

                // Create a client
                AzureKeyCredential credential = new AzureKeyCredential(key);
                SearchClient client = new SearchClient(endpoint, indexName, credential);
                SearchResults<SearchDocument> response = client.Search<SearchDocument>(data, 
                    new SearchOptions
                    {
                        HighlightFields = { "content" },
                        HighlightPreTag = "<em>",
                        HighlightPostTag = "</em>",
                        Size = 5//,
                        //OrderBy = { "Rating desc" }
                    });

                return Ok(response.GetResults());
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
