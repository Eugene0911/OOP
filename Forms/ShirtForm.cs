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
    public partial class ShirtForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public ShirtForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ShirtForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Shirt item = (Shirt)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tColor.Text = item.Color;
            tPrice.Text = item.Price.ToString();
            cbCufflink.SelectedItem = item.Cufflink;
            cbType.SelectedItem = item.CollarType;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbCufflink.Items.Add(true);
            cbCufflink.Items.Add(false);
            cbType.Items.Add(Collar.Butterfly);
            cbType.Items.Add(Collar.Classical);
            cbType.Items.Add(Collar.Kent);
            cbType.Items.Add(Collar.Mandarin);
            cbType.Items.Add(Collar.Tab);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tColor.TextLength > 0 && cbType.SelectedIndex != -1 && cbCufflink.SelectedIndex != -1)
            {
                var shirt = new Shirt((Collar)cbType.SelectedItem, (bool)cbCufflink.SelectedItem, tColor.Text, tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text));
                storage.AddItem(shirt);
                this.Close();
            }
        }
    }
}
