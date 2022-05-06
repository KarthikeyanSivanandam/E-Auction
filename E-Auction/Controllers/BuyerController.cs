using BuyerAPI.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Auction
{    
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/seller")]
    public class BuyerController : ControllerBase
    {
        #region Declarations
        private readonly ILogger<BuyerController> _logger;
        private readonly IBuyerService _buyerService;
        #endregion

        #region Constructor
        public BuyerController(ILogger<BuyerController> logger, IBuyerService buyerService)
        {
            _logger = logger;
            _buyerService = buyerService;
        }
        #endregion

        #region Operations

        #endregion
    }
}
