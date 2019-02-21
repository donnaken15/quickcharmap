using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace quickcharmap
{
    public partial class form : Form
    {
        [DllImport("GetUName.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetUName(int x, [MarshalAs(UnmanagedType.LPWStr)]string lpBuffer);

        public static string charactername = new string('*',127);

        public static bool cancel = false;

        public form()
        {
            InitializeComponent();
            for (int j = 0; j < 256; j++)
                charmap.Items.Add(((char)j).ToString());
            if (Environment.GetCommandLineArgs().Length > 1)
                for (int j = 256; j < Convert.ToInt32(Environment.GetCommandLineArgs()[1]) + 256; j++)
                    charmap.Items.Add(((char)j).ToString());
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hoveritem(object sender, ListViewItemMouseHoverEventArgs e)
        {
            if (e.Item.Text != string.Empty)
            {
                GetUName(e.Item.Text.ToCharArray()[0], charactername);
                charname.Text = "U+" + ((int)e.Item.Text.ToCharArray()[0]).ToString("X4") + ": " + charactername.Substring(0, charactername.IndexOf('*') - 1);
            }
        }

        private void selectchar(object sender, MouseEventArgs e)
        {
            if (charmap.SelectedItems.Count > 0 && !cancel)
            {
                Hide();
                if (charmap.SelectedItems[0].Text[0] > (char)0x20 && charmap.SelectedItems[0].Text[0] < (char)0x7f)
                    SendKeys.Send("{" + charmap.SelectedItems[0].Text + "}");
                else
                    SendKeys.Send(charmap.SelectedItems[0].Text);
                Close();
            }
        }

        private void movedmouse(object sender, MouseEventArgs e)
        {
            cancel = true;
        }

        private void click(object sender, EventArgs e)
        {
            cancel = false;
        }
    }
}
