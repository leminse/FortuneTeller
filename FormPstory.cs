using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class FormPstory : Form
    {
        List<string> history;
        Form form;

        public FormPstory(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }
    }
}
