using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music;
using music_web_aplication.Manager;

namespace music_web_aplication.Controllers
{
    public class RecordController : Controller
    {
        private readonly RecordsManager _manager = new (); //  new MessagesManagerList();

        [HttpGet]
        public IEnumerable<Record> Get([FromQuery] string user)
        {
            return _manager.GetAllRecords(user);
        }
    }
}
