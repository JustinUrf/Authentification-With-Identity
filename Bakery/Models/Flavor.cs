using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    
    [Required(ErrorMessage = "You must name this flavor!")]
    public string FlavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }

  }
}