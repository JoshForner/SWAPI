using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Models;

namespace SWAPI.Controllers
{
    public class SWController : Controller
    {
        private readonly DAL dAL = new DAL();
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SearchPerson(int id)
        {
            Person p = await dAL.GetPerson(id);
            return View(p);
        }

        public async Task<IActionResult> SearchPlanet(int id)
        {
            Planet p = await dAL.GetPlanet(id);
            return View(p);
        }

        public async Task<IActionResult> PersonForm()
        {
            List<Person> lp = new List<Person>();
            var client = dAL.GetHttpClient();
            for(int i = 1; i < 10; i++)
            {
                var response = await client.GetAsync($"people/?page={i}");
                var people = await response.Content.ReadAsAsync<PersonList>();
                lp.AddRange(people.results);
            }
               
            
            return View(lp);
        }

        
    }
}
