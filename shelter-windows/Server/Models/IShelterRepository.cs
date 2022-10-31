using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShelterProject.Shared.Models;


namespace ShelterProject.Server.Models{
    public class IShelterRepository{
        public IShelterRepository(){

            List<Shelter> GetAllItems();

            Shelter FindItem(int id);

            void AddItem(Shelter item);
            bool DeleteItem(int id);
            bool UpdateItem(Shelter item);
        }
    }
}

