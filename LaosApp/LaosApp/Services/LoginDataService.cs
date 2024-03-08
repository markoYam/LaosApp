using LaosApp.Interfaces;
using MauiAppTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Services
{
    class LoginDataService : ILoginDataService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly DatabaseContextService _databaseContextService;

        public LoginDataService(IHttpClientService httpClientService, DatabaseContextService databaseContextService)
        {
            _httpClientService = httpClientService;
            _databaseContextService = databaseContextService;
        }
    }
}
