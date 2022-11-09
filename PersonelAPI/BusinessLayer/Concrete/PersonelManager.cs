using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDAL personeldal;
        public PersonelManager(IPersonelDAL personeldal)
        {
            this.personeldal = personeldal;
        }
        public int AddPersonel(Personel personel)
        {
            return personeldal.Add(personel);
        }

        public int DeletePersonel(Personel personel)
        {
            return personeldal.Delete(personel);
        }

        public Personel GetById(int id)
        {
            return personeldal.GetById(id);
        }

        public List<Personel> ListAllPersonels()
        {
            return personeldal.ListAll();
        }

        public int UpdatePersonel(Personel personel)
        {
            return personeldal.Update(personel);
        }
    }
}
