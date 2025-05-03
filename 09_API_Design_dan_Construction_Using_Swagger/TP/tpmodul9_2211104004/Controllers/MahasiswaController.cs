using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul9_NIM.Models;

namespace tpmodul9_NIM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // Static list to simulate a database
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Kholifahdina", Nim = "2211104004" },
            new Mahasiswa { Nama = "Byeon Woo Seok", Nim = "2211109560" },
            new Mahasiswa { Nama = "Lee Jong Suk", Nim = "2211110987" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak ditemukan");

            return daftarMahasiswa[index];
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok("Mahasiswa ditambahkan");
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak ditemukan");

            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa dihapus");
        }
    }
}
