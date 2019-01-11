using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTemplate.Repositories;

namespace AspNetCoreTemplate.Services
{
    public interface IHomeService
    {
        string GetAboutMessage();

        string GetContactMessage();
    }

    public class HomeService : IHomeService
    {
        private readonly IValuesRepository _valuesRepository;

        public HomeService(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public string GetAboutMessage()
        {
            return "Your application description page.";
        }
        public string GetContactMessage()
        {
            return "Your contact page.";
        }
    }
}
