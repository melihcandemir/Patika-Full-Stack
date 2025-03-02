using CrazyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrazyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusiciansController : ControllerBase
    {

        private static List<Musician> _musicians = new List<Musician>
        {
            new Musician{ Id = 1, Name = "Ahmet Çalgı", Job = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli"},
            new Musician{ Id = 2, Name = "Zeynep Melodi", Job = "Popüler Melodi Yazan", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler"},
            new Musician{ Id = 3, Name = "Cemil Akor", Job = "Çılgın Akorist", FunFeature = "Akorlan sık değiştirir, ama şaşırtıcı derecede yetenekli"},
            new Musician{ Id = 4, Name = "Fatma Nokta", Job = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar"},
            new Musician{ Id = 5, Name = "Hasan Ritim", Job = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir"},
            new Musician{ Id = 6, Name = "Elif Armoni", Job = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır"},
            new Musician{ Id = 7, Name = "Ali Perde", Job = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir"},
            new Musician{ Id = 8, Name = "Ayşe Rezonans", Job = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman ama bazen çok gürültü çıkarır"},
            new Musician{ Id = 9, Name = "Murat Ton", Job = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç"},
            new Musician{ Id = 10, Name = "Selin Akor", Job = "Akor Sihirbazı", FunFeature = "Akorlan değiştirdiğinde bazen sihirli bir hava yaratır"}
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_musicians.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movieMusician = _musicians.FirstOrDefault(x => x.Id == id);

            if (movieMusician == null)
                return NotFound($"{id} id'sine sahip bilgi bulunamadı!");

            return Ok(movieMusician);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Musician musicianData)
        {
            var id = _musicians.Max(x => x.Id) + 1;
            musicianData.Id = id;

            _musicians.Add(musicianData);

            return CreatedAtAction(nameof(Get), new { id = musicianData.Id }, musicianData);
        }

        [HttpPatch("{id}")]
        public IActionResult ChangeName(int id, MusicianUpdate musicianUpdate)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
                return NotFound($"Listede {id} id ye sahip müzisyen bulunamadı.");

            musician.Name = musicianUpdate.Name;

            return Ok("Müzisyen adı başarıyla güncellendi.");
        }

        [HttpPut("{id}")]
        public IActionResult ChangeMusician(int id, MusicianUpdate musicianUpdate)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
                return NotFound($"Listede {id} id ye sahip müzisyen bulunamadı");

            musician.Name = musicianUpdate.Name;
            musician.Job = musicianUpdate.Job;
            musician.FunFeature = musicianUpdate.FunFeature;

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
                return NotFound($"Listede {id} id ye sahip müzisyen bulunamadı");

            _musicians.Remove(musician);
            return Ok("Müzisyen başarıyla silindi.");
        }


        [HttpGet("search")]
        public IActionResult Searchd([FromQuery] string name)
        {
            var results = _musicians.Where(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(results);
        }
    }
}