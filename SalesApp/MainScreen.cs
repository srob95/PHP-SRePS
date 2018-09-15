using System.Windows.Forms;

namespace SalesApp
{
    public partial class MainScreen : Form
    {
        public MainScreen(Database db)
        {
            InitializeComponent();
            addSaleControl.setDatabase(db);
            monthlyReportControl.setDatabase(db);
        }
    }
}
