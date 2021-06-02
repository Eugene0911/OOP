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
    public partial class ShoesForm : Form
    {
        StorageService storage = StorageService.GetInstance();

        public ShoesForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ShoesForm(string itemName)
        {
            InitializeComponent();
            InitializeForm();

            Shoes item = (Shoes)storage.GetItem(itemName);
            tName.Text = item.Name;
            tProducer.Text = item.Producer;
            tMaterial.Text = item.MainMaterial;
            tPrice.Text = item.Price.ToString();
            cbType.SelectedItem = item.Heel;
            tName.Enabled = false;
        }

        private void InitializeForm()
        {
            tName.Enabled = true;
            cbType.Items.Add(HeelType.Default);
            cbType.Items.Add(HeelType.High);
            cbType.Items.Add(HeelType.None);
            cbType.Items.Add(HeelType.Short);
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (tName.TextLength > 0 && tProducer.TextLength > 0 && tMaterial.TextLength > 0 &&
               tPrice.TextLength > 0 && cbType.SelectedIndex != -1)
            {
                var shoes = new Shoes(tName.Text, tProducer.Text, tMaterial.Text, Convert.ToDouble(tPrice.Text), (HeelType)cbType.SelectedItem);
                storage.AddItem(shoes);
                this.Close();
            }
        }
    }
}
