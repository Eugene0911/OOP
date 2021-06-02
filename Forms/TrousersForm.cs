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
    public partial class TrousersForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public TrousersForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public TrousersForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Trousers item = (Trousers)storage.GetItem(itemName);
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
            cbType.Items.Add(TrousersType.Baggy);
            cbType.Items.Add(TrousersType.Cargo);
            cbType.Items.Add(TrousersType.Classical);
            cbType.Items.Add(TrousersType.Flare);
            cbType.Items.Add(TrousersType.Jeans);
            cbType.Items.Add(TrousersType.Palazzo);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && tColor.TextLength > 0 && cbType.SelectedIndex != -1)
            {
                var trousers = new Trousers(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), tColor.Text, (TrousersType)cbType.SelectedItem);
                storage.AddItem(trousers);
                this.Close();
            }
        }
    }
}
