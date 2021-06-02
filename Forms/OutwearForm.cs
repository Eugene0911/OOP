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
    public partial class OutwearForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public OutwearForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public OutwearForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Outwear item = (Outwear)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tColor.Text = item.Color;
            tPrice.Text = item.Price.ToString();
            cbType.SelectedItem = item.Type;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbType.Items.Add(OutwearTypes.Coat);
            cbType.Items.Add(OutwearTypes.Denim);
            cbType.Items.Add(OutwearTypes.Jacket);
            cbType.Items.Add(OutwearTypes.Windbreaker);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tColor.TextLength > 0 && cbType.SelectedIndex != -1)
            {
                var outwear = new Outwear(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), tColor.Text, (OutwearTypes)cbType.SelectedItem);
                storage.AddItem(outwear);
                this.Close();
            }
        }
    }
}
