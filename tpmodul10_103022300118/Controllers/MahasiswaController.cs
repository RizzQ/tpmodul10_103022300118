using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_103022300118
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>{ 
            new("Rizqie Ahmad Zakaria Hende", "103023300118"),
            new("Sidqi Athallah AR", "103022300108"),
            new("Nicholas Putra Irawan", "103022330091"),
            new("Nur Ilmi Mufidah", "103022300005"),
            new("Yudha Harwanto Putra", "103022300010"),
            new("Benaya Giuseppe Linggaputra Sinulingga", "103022330122")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public List<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody]Mahasiswa m)
        {
            mahasiswas.Add(m);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}
