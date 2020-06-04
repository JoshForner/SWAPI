using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWAPI.Models
{
    public class DAL
    {
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.dev/api/");
            return client;
        }

        public async Task<Person> GetPerson(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"people/{id}/");
            var person = await response.Content.ReadAsAsync<Person>();
            return person;
        }

        public async Task<Planet> GetPlanet(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"planets/{id}/");
            var planet = await response.Content.ReadAsAsync<Planet>();
            return planet;
        }
    }
}
