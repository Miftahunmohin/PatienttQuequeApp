using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatienttQuequeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Patient aPatient = new Patient();
        Queue<Patient> aQueue = new Queue<Patient>();
        private int serial =1;
        private void Enqueuebutton_Click(object sender, EventArgs e)
        {

            if (NametextBox.Text=="" ||AgetextBox.Text=="" )
            {
                MessageBox.Show("Pls Entry Name");
            }

            aPatient.serial = serial.ToString();
            aPatient.name = NametextBox.Text;
            aPatient.age = Convert.ToInt32(AgetextBox.Text);
            aPatient.address = AddresstextBox.Text;
            aQueue.Enqueue(aPatient);
            serial++;
            ListViewItem item = new ListViewItem();
            item.Text = aPatient.serial;
            item.SubItems.Add(aPatient.name);
            item.SubItems.Add(aPatient.age.ToString());
            item.SubItems.Add(aPatient.address);
            listView1.Items.Add(item);

            NametextBox.Text = string.Empty;
            AgetextBox.Text = string.Empty;
            AddresstextBox.Text = string.Empty;


        }

        private void Dequeuebutton_Click(object sender, EventArgs e)
        {
            aPatient = aQueue.Dequeue();
            SerialtextBox.Text = aPatient.serial;
            NameshowtextBox.Text = aPatient.name;
            AgeshowtextBox.Text = aPatient.age.ToString();
            AddressshowtextBox.Text = aPatient.address;
            listView1.Items[0].Remove();
        }

       
    }
}
