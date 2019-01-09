using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApiTemplate.Repositories;

namespace AspNetCoreApiTemplate.Services
{
    public interface IValuesService
    {
        string[] Get();
    }

    public class ValuesService : IValuesService
    {
        private readonly IValuesRepository _valuesRepository;

        public ValuesService(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public string[] Get()
        {
            return new string[] { "Hello", "World" };
        }
    }
}
