using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BigTycoon
{
    public partial class InserisciNomeUtente : Form
    {

        public InserisciNomeUtente()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Villaggio_amico vm = new Villaggio_amico(textBox1.Text);
            vm.Show();
        }
    }
}
