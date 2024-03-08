using LaosApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Presenters 
{
    internal class RegisterPresenter : IRegisterPresenter
    {
        private readonly IRegisterDataService _registerDataService;



        public RegisterPresenter(IRegisterDataService registerDataService)
        {

            _registerDataService = registerDataService;
        }
    }
}
