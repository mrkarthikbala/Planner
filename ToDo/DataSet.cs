using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.ToDo {
  public class DataSet {
    public DataSet() {
      this.ShortTermProjects = new List<ShortTerm>(){
        new ShortTerm(){Name="Work Out", Description = "Run", DueBy = DateTime.Today}
      };
      this.LongTermProjects = new List<LongTerm>(){
        new LongTerm(){Name = "Run Half Marathon", Description = "13.1 miles"}
      };
      this.Rules = new List<Rule>(){
        new Rule(){Description = "Review all Classes", Frequency = "2nd and 4th weekend of month"}
      };
    }

    public List<ShortTerm> ShortTermProjects { get; set; }
    public List<LongTerm> LongTermProjects { get; set; }
    public List<Rule> Rules { get; set; }
  }
}
