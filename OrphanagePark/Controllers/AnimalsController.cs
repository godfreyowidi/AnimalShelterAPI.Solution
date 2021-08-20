using Microsoft.AspNetCore.Mvc;
using OrphanagePark.Models;

namespace CretaceousPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly OrphanageParkContext _db;

    public AnimalsController(OrphanageParkContext db)
    {
      _db = db;
    }
  }
}