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
    public partial class SocksForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public SocksForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public SocksForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Socks item = (Socks)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tColor.Text = item.Color;
            tPrice.Text = item.Price.ToString();
            cbType.SelectedItem = item.Length;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbType.Items.Add(LengthType.Golf);
            cbType.Items.Add(LengthType.Liner);
            cbType.Items.Add(LengthType.MidCalf);
            cbType.Items.Add(LengthType.NoShow);
            cbType.Items.Add(LengthType.Ped);
            cbType.Items.Add(LengthType.Quarter);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tColor.TextLength > 0 && cbType.SelectedIndex != -1)
            {
                var socks = new Socks(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), tColor.Text, (LengthType)cbType.SelectedItem);
                storage.AddItem(socks);
                this.Close();
            }
        }
    }
}
