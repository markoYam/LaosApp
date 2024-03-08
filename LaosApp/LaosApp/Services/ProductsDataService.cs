﻿using LaosApp.Interfaces;
using MauiAppTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Services
{
    internal class ProductsDataService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly DatabaseContextService _databaseContextService;

        public ProductsDataService(IHttpClientService httpClientService, DatabaseContextService databaseContextService)
        {
            _httpClientService = httpClientService;
            _databaseContextService = databaseContextService;
        }
    }
}
