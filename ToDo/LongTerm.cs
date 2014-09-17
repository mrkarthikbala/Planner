using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.ToDo {
  public class LongTerm {
    public LongTerm() { }
    public LongTerm(string name, string description) {
      this.Name = name;
      this.Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
  }
}
