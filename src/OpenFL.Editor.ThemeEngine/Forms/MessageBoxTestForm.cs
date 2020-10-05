using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using ThemeEngine.Forms;

namespace OpenFL.Editor.ThemeEngine.Forms
{
    public partial class MessageBoxTestForm : Form
    {

        public MessageBoxTestForm()
        {
            InitializeComponent();

            cbBorderStyle.Items.AddRange(Enum.GetNames(typeof(FormBorderStyle)));
            cbContentStyle.Items.AddRange(Enum.GetNames(typeof(StyledMessageBox.MessageBoxContent)));
            cbIcon.Items.AddRange(GetIconNames());

            cbMessageBoxButtons.Items.AddRange(Enum.GetNames(typeof(MessageBoxButtons)));
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            StyledMessageBox.Show(
                                  tbTitle.Text,
                                  rtbContent.Text,
                                  (MessageBoxButtons) Enum.Parse(
                                                                 typeof(MessageBoxButtons),
                                                                 cbMessageBoxButtons.SelectedItem.ToString()
                                                                ),
                                  GetIcon(cbIcon.SelectedItem.ToString()),
                                  (StyledMessageBox.MessageBoxContent) Enum.Parse(
                                       typeof(StyledMessageBox.MessageBoxContent),
                                       cbContentStyle.SelectedItem.ToString()
                                      ),
                                  cbHasImage.Checked ? new Bitmap(512, 512) : null,
                                  (FormBorderStyle) Enum.Parse(
                                                               typeof(FormBorderStyle),
                                                               cbBorderStyle.SelectedItem.ToString()
                                                              ),
                                  new Size((int) nudSizeWidth.Value, (int) nudSizeHeight.Value)
                                 );
        }

        private string[] GetIconNames()
        {
            PropertyInfo[] propertyInfos = typeof(SystemIcons).GetProperties(BindingFlags.Public | BindingFlags.Static);
            return propertyInfos.Select(x => x.Name).ToArray();
        }

        private Icon GetIcon(string name)
        {
            PropertyInfo pi = typeof(SystemIcons).GetProperty(name);
            return (Icon) pi.GetValue(null);
        }

    }
}