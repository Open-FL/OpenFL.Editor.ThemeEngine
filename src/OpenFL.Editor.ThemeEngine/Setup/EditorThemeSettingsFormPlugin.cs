using System.IO;
using System.Linq;
using System.Windows.Forms;

using OpenFL.Editor.ThemeEngine.Forms;
using OpenFL.Editor.Utils.Plugins;

using PluginSystem.Core.Pointer;
using PluginSystem.FileSystem;
using PluginSystem.Utility;

using ThemeEngine;
using ThemeEngine.Forms;
using ThemeEngine.Script.Options;

namespace OpenFL.Editor.ThemeEngine.Setup
{
    public class EditorThemeSettingsFormPlugin : APlugin<FLEditorPluginHost>
    {
        
        private EditorThemeSettingsForm f;
        private StyleOptionsMenu optionsForm;


        [ToolbarItem("File/Theme Options...", 3)]
        private void OnShowThemeOptions()
        {
            if (optionsForm == null || optionsForm.IsDisposed)
            {
                optionsForm = new StyleOptionsMenu();
                optionsForm.Show();
            }
        }


        [ToolbarItem("File/Appearance...", 2)]
        private void OnShowAppearance()
        {
            if (f == null || f.IsDisposed)
            {
                string stylePath = Path.Combine(PluginPaths.GetPluginConfigDirectory(PluginAssemblyData), "styles");
                f = new EditorThemeSettingsForm( stylePath);
                f.Show();
            }
        }

        public override void OnLoad(PluginAssemblyPointer ptr)
        {
            base.OnLoad(ptr);

            Application.ApplicationExit += Application_ApplicationExit;
            
            string styleDir = Path.Combine(PluginPaths.GetPluginConfigDirectory(PluginAssemblyData), "styles");
            
            Directory.CreateDirectory(styleDir);

            StyleManager_OnReload();
        }

        private void StyleManager_OnReload()
        {
            string styleDir = Path.Combine(PluginPaths.GetPluginConfigDirectory(PluginAssemblyData), "styles");
            if (File.Exists(Path.Combine(styleDir, "style.options")))
            {
                string[] file = File.ReadAllLines(
                                                  Path.Combine(styleDir, "style.options")
                                                 );
                foreach (string s in file)
                {
                    string[] parts = s.Split(':').Select(x => x.Trim()).ToArray();
                    StyleOption opt = StyleManager.StyleOptions.FirstOrDefault(x => x.Keyword == parts[0]);
                    if (opt != null)
                    {
                        opt.Value = parts[1];
                    }
                }
            }
        }

        private void Application_ApplicationExit(object sender, System.EventArgs e)
        {
            string styleDir = Path.Combine(PluginPaths.GetPluginConfigDirectory(PluginAssemblyData), "styles");
            string[] lines = StyleManager.StyleOptions.Where(x => x.HasChanged).Select(x => $"{x.Keyword}: {x.Value}")
                                         .ToArray();
            File.WriteAllLines(Path.Combine(styleDir, "style.options"), lines);
        }

    }
}