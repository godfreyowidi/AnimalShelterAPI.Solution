using System.Text;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using OrphanagePark.Configuration;
using OrphanagePark.Models.Dtos.Requests;
using OrphanagePark.Models.Dtos.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;

namespace OrphanagePark.Controllers
{
  //api/authManagement
  [Route("api/[controller]")]
  public class AuthManagementController : ControllerBase
  {
    private readonly UserManager<IdentityUser> _userManager;
    private readonly JwtConfig _jwtConfig;

    public AuthManagementController(
        UserManager<IdentityUser> userManager, 
        IOptionsMonitor<JwtConfig> optionsMonitor)
    {
      _userManager = userManager;
      _jwtConfig = optionsMonitor.CurrentValue;
    }
  }
}