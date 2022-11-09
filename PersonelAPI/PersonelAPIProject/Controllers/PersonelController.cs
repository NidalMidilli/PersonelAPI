using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PersonelAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : Controller
    {
        IPersonelService personelservice;

        public PersonelController(IPersonelService personelservice)
        {
            this.personelservice = personelservice;
        }
        [HttpGet]
       
        public List<Personel> Get()
        {
            return personelservice.ListAllPersonels();

        }
        [HttpPost]

        public int Post([FromBody] Personel hospital)
        {
            return personelservice.AddPersonel(hospital);
        }
        [HttpPut]
        public int Put([FromBody] Personel personel)
        {
            return personelservice.UpdatePersonel(personel);
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var result = personelservice.GetById(id);
            return personelservice.DeletePersonel(result);
            
        }
        [HttpGet("{id}")]
        public Personel Get(int id)
        {
            return personelservice.GetById(id);
        }
    }
}
