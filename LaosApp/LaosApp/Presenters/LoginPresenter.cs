using LaosApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Presenters
{
    class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginDataService _loginDataService;

       

        public LoginPresenter(ILoginDataService loginDataService)
        {
           
            _loginDataService = loginDataService;
        }
    }
}
