using System;
using ShelterProject.Shared.Models;
namespace ShelterProject.Client.Services{
    public interface IShelterService{

        Task<Shelter[]?> GetAllItems();

        Task<int> AddItem(Shelter item);
        Task<int> DeleteItem(string id);
        Task<Shelter> GetItem(string id);
        Task<int> UpdateItem(Shelter item);

    }
}

