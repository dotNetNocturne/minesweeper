using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();



            var presenter = new BoardPresenter(new Board(10, 10));

            userControl11.SetBoardPresenter(presenter);

        }
    }
}
