using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Music;
using music_web_aplication.Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace music_web_aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        // GET: api/<SongsController>
        private readonly SongManager _songManager = new SongManager();
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _songManager.getAll();
        }

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return _songManager.GetById(id);
        }

        // POST api/<BeerController>
        [HttpPost]
        public Song Post([FromBody] Song value)
        {
            return _songManager.Add(value);
        }

        // PUT api/<BeerController>/5
        [HttpPut("{id}")]
        public Song Put(int id, [FromBody] Song value)
        {
            return _songManager.Update(id, value);
        }


        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public Song Delete(int id)
        {
            return _songManager.Delete(id);
        }
    }
}
