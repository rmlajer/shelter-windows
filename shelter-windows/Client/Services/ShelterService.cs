﻿using System;
using System.Net.Http.Json;
using ShelterProject.Shared.Models;

namespace ShelterProject.Client.Services{

    public class ShelterServices : IShelterService{

        private readonly HttpClient httpClient;

        public ShelterServices(HttpClient httpClient)
        {

            this.httpClient = httpClient;
        }


        public async Task<Shelter> GetItem(string id)
        {
            var result = await httpClient.GetFromJsonAsync<Shelter>("api/shopapi/" + id);
            return result!;
        }

        public Task<Shelter[]?> GetAllItems()
        {
            //var result = httpClient.GetFromJsonAsync<ShoppingItem[]>("sample-data/shoppingdata.json");
            var result = httpClient.GetFromJsonAsync<Shelter[]>("api/shopapi");
            return result;
        }


        public async Task<int> AddItem(Shelter item)
        {
            var response = await httpClient.PostAsJsonAsync("api/shopapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> DeleteItem(string id)
        {
            var response = await httpClient.DeleteAsync("api/shopapi/" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> UpdateItem(Shelter item)
        {
            var response = await httpClient.PutAsJsonAsync("api/shopapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;

        }



    }
}

