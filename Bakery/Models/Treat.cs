using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    
    [Required(ErrorMessage = "You must name this treat!")]
    public string TreatName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}