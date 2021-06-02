using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLaboratory
{
    public partial class BeltForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public BeltForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public BeltForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Belt item = (Belt)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tBuckleMaterial.Text = item.BuckleMaterial;
            tPrice.Text = item.Price.ToString();
            cbBuckleType.SelectedItem = item.BuckleType;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbBuckleType.Items.Add(Buckle.Classical);
            cbBuckleType.Items.Add(Buckle.Butterfly);
            cbBuckleType.Items.Add(Buckle.Clipse);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if(tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 && 
               tPrice.TextLength > 0 && tBuckleMaterial.TextLength > 0 && cbBuckleType.SelectedIndex != -1)
            {
                var belt = new Belt(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), tBuckleMaterial.Text, (Buckle)cbBuckleType.SelectedItem);
                storage.AddItem(belt);
                this.Close();
            }
        }
    }
}
