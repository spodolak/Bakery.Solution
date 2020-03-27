using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
    public virtual ApplicationUser User { get; set; }
  }
}