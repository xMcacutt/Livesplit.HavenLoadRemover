using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Livesplit.HavenLoadRemover;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public class HavenLoadRemoverComponent : IComponent
    {
        public SettingsMenu SettingsMenu;
        public LiveSplitState State;

        public HavenLoadRemoverComponent(LiveSplitState state)
        {
            State = state;
            SettingsMenu = new SettingsMenu(state);
            HorizontalWidth = 0;
            VerticalHeight = 0;
            GameName = state.Run.GameName;

            State.OnStart += OnStart;
        }

        private void OnStart(object sender, EventArgs e)
        {
            State.IsGameTimeInitialized = true;
        }

        public string ComponentName => "HCOTK Load Remover";
        public string GameName { get; }
        public float HorizontalWidth { get; }
        public float MinimumHeight { get; }
        public float VerticalHeight { get; }
        public float MinimumWidth { get; }
        public float PaddingTop { get; }
        public float PaddingBottom { get; }
        public float PaddingLeft { get; }
        public float PaddingRight { get; }
        public IDictionary<string, Action> ContextMenuControls { get; }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return SettingsMenu;
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return SettingsMenu.GetSettings(document);
        }

        public void SetSettings(XmlNode settings)
        {
            SettingsMenu.SetSettings(settings);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (GameName != "Haven: Call of the King")
                return;

           
            try
            {
                if (SettingsMenu.SelectedWindow == null || SettingsMenu.SelectedWindow.hWnd == (IntPtr)0)
                    return;
                var feedImage = VideoCapture.Capture(SettingsMenu.SelectedWindow.hWnd, SettingsMenu.CropLeft, SettingsMenu.CropRight, SettingsMenu.CropTop, SettingsMenu.CropBottom);
                if (feedImage == null) 
                    return;
                var similarity = ImageComparison.CompareImages("./Components/HCOTKLR/Load.bmp", feedImage);
                var match = similarity > SettingsMenu.Sensitivity;
                if (match != State.IsGameTimePaused)
                    State.IsGameTimePaused = !State.IsGameTimePaused;
                SettingsMenu.UpdateSimilarity(similarity);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }
        
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}