using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using Emgu.CV;
using Livesplit.HavenLoadRemover;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{

    public partial class SettingsMenu : UserControl
    {
        public LiveSplitState State;
        public List<WindowInfo> Windows { get; set; } = new List<WindowInfo>();
        public WindowInfo SelectedWindow { get; set; }
        public int CropTop { get; set; }
        public int CropBottom { get; set; }
        public int CropLeft { get; set; }
        public int CropRight { get; set; }
        public float Sensitivity { get; set; }

        public SettingsMenu(LiveSplitState state)
        {
            InitializeComponent();
            State = state;
            Sensitivity = 90f;
            Windows = GetWindows();
            processCombo.DisplayMember = "Title";
            CropLeft = 0;
            CropRight = 0;
            CropTop = 0;
            CropBottom = 0;
            SelectedWindow = null;

            processCombo.DataBindings.Add(new Binding("SelectedItem", this, "SelectedWindow"));
            processCombo.DataBindings.Add(new Binding("DataSource", this, "Windows"));
            sensitivityControl.DataBindings.Add(new Binding("Value", this, "Sensitivity"));
            cropLeftInput.DataBindings.Add(new Binding("Value", this, "CropLeft"));
            cropRightInput.DataBindings.Add(new Binding("Value", this, "CropRight"));
            cropTopInput.DataBindings.Add(new Binding("Value", this, "CropTop"));
            cropBottomInput.DataBindings.Add(new Binding("Value", this, "CropBottom"));

            Load += SettingsMenu_Load;
        }
        
        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            
            var element = document.CreateElement(ToString());
            element.InnerText = "HCOTK Load Remover";
            parent.AppendChild(element);
            
            element = document.CreateElement("Sensitivity");
            element.InnerText = Sensitivity.ToString(CultureInfo.InvariantCulture);
            parent.AppendChild(element);

            element = document.CreateElement("CropLeft");
            element.InnerText = CropLeft.ToString(CultureInfo.InvariantCulture);
            parent.AppendChild(element);

            element = document.CreateElement("CropRight");
            element.InnerText = CropRight.ToString(CultureInfo.InvariantCulture);
            parent.AppendChild(element);

            element = document.CreateElement("CropTop");
            element.InnerText = CropTop.ToString(CultureInfo.InvariantCulture);
            parent.AppendChild(element);

            element = document.CreateElement("CropBottom");
            element.InnerText = CropBottom.ToString(CultureInfo.InvariantCulture);
            parent.AppendChild(element);

            element = document.CreateElement("SelectedWindow");
            element.InnerText = SelectedWindow == null ? "" : SelectedWindow.Title;
            parent.AppendChild(element);

            return parent;
        }

        public void SetSettings(XmlNode settings)
        {
            if (settings["Sensitivity"].InnerText != null)
                Sensitivity = float.Parse(settings["Sensitivity"].InnerText);

            if (settings["CropTop"].InnerText != null)
                CropTop = int.Parse(settings["CropTop"].InnerText);

            if (settings["CropBottom"].InnerText != null)
                CropBottom = int.Parse(settings["CropBottom"].InnerText);

            if (settings["CropLeft"].InnerText != null)
                CropLeft = int.Parse(settings["CropLeft"].InnerText);

            if (settings["CropRight"].InnerText != null)
                CropRight= int.Parse(settings["CropRight"].InnerText);

            if (settings["SelectedWindow"].InnerText != null)
            {
                if (settings["SelectedWindow"].InnerText == "")
                    SelectedWindow = null;
                else
                    SelectedWindow = new WindowInfo(FindWindow(null, settings["SelectedWindow"].InnerText), settings["SelectedWindow"].InnerText);
            }
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            Sensitivity = (float)sensitivityControl.Value;
            CropLeft = (int)cropLeftInput.Value;
            CropRight = (int)cropRightInput.Value;
            CropTop = (int)cropTopInput.Value;
            CropBottom = (int)cropBottomInput.Value;
            SelectedWindow = processCombo.SelectedItem as WindowInfo;
        }

        private void sensitivityControl_ValueChanged(object sender, EventArgs e)
        {
            Sensitivity = (float)sensitivityControl.Value;
        }

        private void processCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedWindow = processCombo.SelectedItem as WindowInfo;
        }

        private void cropTopInput_ValueChanged(object sender, EventArgs e)
        {
            CropTop = (int)cropTopInput.Value;
            UpdatePreview();
        }

        private void cropBottomInput_ValueChanged(object sender, EventArgs e)
        {
            CropBottom = (int)cropBottomInput.Value;
            UpdatePreview();
        }

        private void cropLeftInput_ValueChanged(object sender, EventArgs e)
        {
            CropLeft = (int)cropLeftInput.Value;
            UpdatePreview();
        }

        private void cropRightInput_ValueChanged(object sender, EventArgs e)
        {
            CropRight = (int)cropRightInput.Value;
            UpdatePreview();
        }

        public void UpdateSimilarity(double value)
        {
            similarityValue.Text = value.ToString();
        }

        private void updatePreviewButton_Click(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            try
            {
                if (SelectedWindow == null)
                    return;

                var mat = Livesplit.HavenLoadRemover.VideoCapture.Capture(SelectedWindow.hWnd, CropLeft, CropRight, CropTop, CropBottom);
                if (mat != null)
                {
                    imageView.Image = mat.ToBitmap();
                    mat.Dispose();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void processCombo_MouseDown(object sender, MouseEventArgs e)
        {
            Windows = GetWindows();
            processCombo.DisplayMember = "Title";
            processCombo.DataSource = Windows;
        }

        private List<WindowInfo> GetWindows()
        {
            var windows = new List<WindowInfo>();
            var processes = Process.GetProcesses();
            foreach( var process in processes )
            {
                EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
                {
                    GetWindowThreadProcessId(hWnd, out int processId);
                    if (processId == process.Id && IsWindowVisible(hWnd))
                    {
                        System.Text.StringBuilder title = new System.Text.StringBuilder(256);
                        GetWindowText(hWnd, title, 256);
                        if (!string.IsNullOrEmpty(title.ToString()) && !windows.Exists(w => w.Title == title.ToString()))
                            windows.Add(new WindowInfo(hWnd, title.ToString()));
                    }
                    return true;
                }, IntPtr.Zero);
            }
            return windows;
        }


        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            Process.Start("https://github.com/xMcacutt/Livesplit.HavenLoadRemover");
        }
    }

    public class WindowInfo
    {
        public IntPtr hWnd { get; set; }
        public string Title { get; set; }

        public WindowInfo(IntPtr hWnd, string title)
        {
            this.hWnd = hWnd;
            Title = title;
        }
    }
}