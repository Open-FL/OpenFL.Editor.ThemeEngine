using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using PluginSystem.FileSystem;

using ThemeEngine;
using ThemeEngine.Forms;

namespace OpenFL.Editor.ThemeEngine.Forms
{
    public partial class EditorThemeSettingsForm : Form
    {

        private readonly DataGridView dgvOptions;

        private readonly FileSystemWatcher fswStyles;

        private readonly bool NoSet;

        private readonly string StylePath;

        public EditorThemeSettingsForm(string stylePath)
        {
            StylePath = stylePath;
            fswStyles = new FileSystemWatcher(stylePath);

            InitializeComponent();

            InitializeThemes();


            StyleManager.RegisterControls(this);

            dgvOptions = StyleOptionsMenu.CreateGridView();
            panelGrid.Controls.Add(dgvOptions);
            panelGrid.Dock = DockStyle.Fill;
        }


        private void InitializeThemes()
        {
            cbStyle.Items.AddRange(
                                   Directory
                                       .GetFiles(StylePath, "*.style", SearchOption.TopDirectoryOnly)
                                       .Select(Path.GetFileNameWithoutExtension).Cast<object>().ToArray()
                                  );

            fswStyles.Filter = "*.style";
            fswStyles.Created += FswStyle_Created;
            fswStyles.Renamed += FswStyle_Renamed;
            fswStyles.Deleted += FswStyle_Deleted;
        }

        private void FswStyle_Deleted(object sender, FileSystemEventArgs e)
        {
            cbStyle.Items.Remove(Path.GetFileNameWithoutExtension(e.Name));
        }

        private void FswStyle_Renamed(object sender, RenamedEventArgs e)
        {
            cbStyle.Items.Remove(Path.GetFileNameWithoutExtension(e.OldName));
            cbStyle.Items.Add(Path.GetFileNameWithoutExtension(e.Name));
        }

        private void FswStyle_Created(object sender, FileSystemEventArgs e)
        {
            cbStyle.Items.Add(Path.GetFileNameWithoutExtension(e.Name));
        }

        private void btnLoadStyle_Click(object sender, EventArgs e)
        {
            if (cbStyle.SelectedIndex != -1)
            {
                StyleManager.ApplyThemeFile(
                                            Path.Combine(
                                                         StylePath,
                                                         cbStyle.SelectedItem + ".style"
                                                        )
                                           );
                File.WriteAllText(
                                  Path.Combine(PluginPaths.InternalSystemConfigPath, "last_style.txt"),
                                  Path.Combine(
                                               StylePath,
                                               cbStyle.SelectedItem + ".style"
                                              )
                                 );
            }
        }

    }
}