using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLaboratory.Bridge
{
    class MainAppProcessor : AbstractProcessor
    {
        public MainAppProcessor(IFunctionalPlugin functionalPlugin, ISerializePlugin serializePlugin) :
            base(functionalPlugin, serializePlugin)
        { }

        public MainAppProcessor() { }

        public override void ShowMessage()
        {
            var message = Status == true ? "Data was processed successfully!" : "Data wasn't processed: there were some troubles!";
            var caption = "Operation Status";
            MessageBox.Show(message, caption);
        }
    }
}
