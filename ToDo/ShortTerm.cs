using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.ToDo {
  public class ShortTerm {
    public ShortTerm() {    }
    public ShortTerm(string name, string description, DateTime DueBy) {
      this.Name = name;
      this.Description = description;
      this.DueBy = DueBy;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueBy { get; set; }
  }
}
