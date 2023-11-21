using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TGCLoyaltyApp.Web.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]/[action]")]
    public class InstallerController : Controller
    {
        private readonly IInstallerService installerService;
        public InstallerController(IInstallerService installerService)
        {
            this.installerService = installerService;
        }

        public async Task<ActionResult> Install()
        {
            await this.installerService.ConfigureInitialData();
            return Ok();
        }
    }
}

