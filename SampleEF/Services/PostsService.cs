using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using SampleEF.Models;

namespace SampleEF.Services
{
    public class PostsService
    {
        private RestClient _client;
        public PostsService()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com/");
        }

        public IEnumerable<Posts> GetAll()
        {
            var request = new RestRequest("api/posts", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            var response = _client.Execute<List<Posts>>(request);
            if (response.Data == null)
                throw new Exception("Error: Data tidak ditemukan");

            return response.Data;
        }
    }
}