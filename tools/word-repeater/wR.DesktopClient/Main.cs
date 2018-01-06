using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using wR.Core.Domain;
using wR.DAL;

namespace wR.DesktopClient
{
    public partial class Main : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public Main()
        {
            InitializeComponent();
            SetSelection();

            ChosenSource.SelectionChangeCommitted += new ListViewItemSelectionChangedEventHandler();
        }

        private void SetSelection()
        {
            ChosenSource.DataSource = GetLanguages();
            ChosenSource.DisplayMember = "Code";
            ChosenSource.ValueMember = "Id";
        }

        private IList<Language> GetLanguages()
        {
            return _context.Languages.ToList();
        }
    }
}
