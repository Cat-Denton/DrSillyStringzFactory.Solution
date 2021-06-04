using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }

  }
}