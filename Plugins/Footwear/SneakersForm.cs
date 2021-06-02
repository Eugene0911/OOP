using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdLaboratory;

namespace Footwear
{
    public partial class SneakersForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public SneakersForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public SneakersForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Sneakers item = (Sneakers)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tColor.Text = item.Color;
            tPrice.Text = item.Price.ToString();
            cbShoelaces.SelectedItem = item.HasShoelaces;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbShoelaces.Items.Add(true);
            cbShoelaces.Items.Add(false);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tColor.TextLength > 0 && cbShoelaces.SelectedIndex != -1)
            {
                var sneakers = new Sneakers(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), tColor.Text, (bool)cbShoelaces.SelectedItem);
                storage.AddItem(sneakers);
                this.Close();
            }
        }
    }
}
