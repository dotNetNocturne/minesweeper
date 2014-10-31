using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormTestTimer : Form
    {
        private System.Timers.Timer _timer = new System.Timers.Timer();
        private int _seconds=0;

        public FormTestTimer()
        {
            InitializeComponent();

            _timer.Elapsed += _timer_Elapsed;
            _timer.Interval = 1000;
            _timer.Enabled = true;
        }

        private void SetTime( int seconds)
        {
            var ts = new TimeSpan(0,0,seconds);
            label1.Text = ts.ToString("hh:mm:ss");
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _seconds += 1000;
        }


    }
}
