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
    public partial class DressForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public DressForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public DressForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Dress item = (Dress)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tColor.Text = item.Color;
            tPrice.Text = item.Price.ToString();
            cbType.SelectedItem = item.Type;
            tLength.Text = item.Length.ToString();
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbType.Items.Add(DressType.BabyDoll);
            cbType.Items.Add(DressType.Bubble);
            cbType.Items.Add(DressType.Culotte);
            cbType.Items.Add(DressType.Kimono);
            cbType.Items.Add(DressType.ShirtDress);
            cbType.Items.Add(DressType.Smocked);
            cbType.Items.Add(DressType.Sundress);
            cbType.Items.Add(DressType.Trumpet);
            cbType.Items.Add(DressType.ALine);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tLength.TextLength > 0 && cbType.SelectedIndex != -1 && tColor.TextLength > 0)
            {
                var dress = new Dress(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), (DressType)cbType.SelectedItem, tColor.Text, Convert.ToDouble(tLength.Text));
                storage.AddItem(dress);
                this.Close();
            }
        }
    }
}
