using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Planner.ToDo;

namespace Planner {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainScreen : Window {
    public MainScreen() {
      InitializeComponent();
      this.DataSet = new DataSet();
      this.DataContext = this;

    }
    public DataSet DataSet { get; set; }
    public List<string> ShortTermProjects { get { return this.DataSet.ShortTermProjects.Select(s => s.Name).ToList(); }  }
    public List<string> LongTermProjects { get { return this.DataSet.LongTermProjects.Select(l => l.Name).ToList(); }  }
    public List<string> Rules { get { return this.DataSet.Rules.Select(r => r.Description).ToList(); } }
  }
}
