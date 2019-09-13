using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using NewsReader.Models;

namespace NewsReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NewsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        // GET: api/News
        [HttpGet]
        public async Task<IEnumerable<Story>> Get()
        {
            try
            {
                List<Story> stories = new List<Story>();
                var client = _httpClientFactory.CreateClient();
                var result = await client.GetAsync("https://hacker-news.firebaseio.com/v0/showstories.json?print=pretty");
                var newsItems = await result.Content.ReadAsAsync<List<int>>();
                foreach (var item in newsItems)
                {
                    var res = await client.GetAsync("https://hacker-news.firebaseio.com/v0/item/" + item + ".json");
                    var story = await res.Content.ReadAsAsync<Story>();
                    stories.Add(story);
                }
                return stories;

            }
            catch
            {
                return null;
            }
        }

        // GET: api/News/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/News
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/News/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
