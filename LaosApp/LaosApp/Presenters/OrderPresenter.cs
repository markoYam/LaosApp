using LaosApp.Interfaces;
using LaosApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Presenters
{
    internal class OrderPresenter : IOrdersPresenter
    {
        private readonly IOrdersDataService _ordersDataService;
        private readonly IOrdersView _ordersView;

        public OrderPresenter(IOrdersDataService ordersDataService)
        {

            _ordersDataService = ordersDataService;
        }
    }
}
