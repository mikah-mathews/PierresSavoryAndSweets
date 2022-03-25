using System.Collections.Generic;

namespace PierresSavoryAndSweet.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new Hashset<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
  }
}