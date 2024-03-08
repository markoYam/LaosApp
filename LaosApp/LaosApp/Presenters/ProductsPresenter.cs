using LaosApp.Interfaces;
using LaosApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Presenters
{
    internal class ProductsPresenter : IProductsPresenter
    {
        private readonly IProductsDataService _productsDataService;
        private readonly IProductsView _productsView;


        public ProductsPresenter(IProductsDataService productsDataService)
        {

            _productsDataService = productsDataService;
        }
    }
}
