using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBRegAuth
{
    public partial class seance_places : Form
    {
        MakeButtonsInHall MakeButtonsInHall;
        public seance_places(int s)
        {
            StartPosition = FormStartPosition.CenterScreen;
            MakeButtonsInHall = new MakeButtonsInHall(s);
            InitializeComponent();
            this.Controls.Add(MakeButtonsInHall);
        }
    }
}
