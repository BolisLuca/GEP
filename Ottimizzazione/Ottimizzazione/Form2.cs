using System.Windows.Forms;

namespace Ottimizzazione
{
    public partial class Form2 : Form
    {

        private static Label myLabel;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "";
            myLabel = label1;
            this.Height =  System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }
        public static void acquisisci(string passaggio)
        {
            myLabel.Text += passaggio + "\n\n";
            //    myLabel.Invalidate();
            myLabel.Update();
            //    myLabel.Refresh();
            //  Application.DoEvents();
        }

    }
}
