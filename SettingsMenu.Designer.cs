using System.ComponentModel;

namespace LiveSplit.UI.Components
{
    partial class SettingsMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processCombo = new System.Windows.Forms.ComboBox();
            this.sensitivityControl = new System.Windows.Forms.NumericUpDown();
            this.sensitivityLabel = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatePreviewButton = new System.Windows.Forms.Button();
            this.cropRightLabel = new System.Windows.Forms.Label();
            this.cropLeftLabel = new System.Windows.Forms.Label();
            this.cropBottomLabel = new System.Windows.Forms.Label();
            this.cropTopLabel = new System.Windows.Forms.Label();
            this.cropRightInput = new System.Windows.Forms.NumericUpDown();
            this.cropLeftInput = new System.Windows.Forms.NumericUpDown();
            this.cropBottomInput = new System.Windows.Forms.NumericUpDown();
            this.cropTopInput = new System.Windows.Forms.NumericUpDown();
            this.imageView = new System.Windows.Forms.PictureBox();
            this.similarityLabel = new System.Windows.Forms.Label();
            this.similarityValue = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropRightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropLeftInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBottomInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropTopInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // processCombo
            // 
            this.processCombo.FormattingEnabled = true;
            this.processCombo.Location = new System.Drawing.Point(26, 117);
            this.processCombo.Name = "processCombo";
            this.processCombo.Size = new System.Drawing.Size(300, 21);
            this.processCombo.TabIndex = 0;
            this.processCombo.SelectedValueChanged += new System.EventHandler(this.processCombo_SelectedValueChanged);
            this.processCombo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.processCombo_MouseDown);
            // 
            // sensitivityControl
            // 
            this.sensitivityControl.AutoSize = true;
            this.sensitivityControl.DecimalPlaces = 2;
            this.sensitivityControl.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.sensitivityControl.Location = new System.Drawing.Point(26, 68);
            this.sensitivityControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sensitivityControl.Name = "sensitivityControl";
            this.sensitivityControl.Size = new System.Drawing.Size(120, 20);
            this.sensitivityControl.TabIndex = 1;
            this.sensitivityControl.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.sensitivityControl.ValueChanged += new System.EventHandler(this.sensitivityControl_ValueChanged);
            // 
            // sensitivityLabel
            // 
            this.sensitivityLabel.AutoSize = true;
            this.sensitivityLabel.Location = new System.Drawing.Point(14, 52);
            this.sensitivityLabel.Name = "sensitivityLabel";
            this.sensitivityLabel.Size = new System.Drawing.Size(54, 13);
            this.sensitivityLabel.TabIndex = 2;
            this.sensitivityLabel.Text = "Sensitivity";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(14, 101);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(111, 13);
            this.processLabel.TabIndex = 3;
            this.processLabel.Text = "Application to Capture";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.link);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.similarityValue);
            this.panel1.Controls.Add(this.similarityLabel);
            this.panel1.Controls.Add(this.updatePreviewButton);
            this.panel1.Controls.Add(this.cropRightLabel);
            this.panel1.Controls.Add(this.cropLeftLabel);
            this.panel1.Controls.Add(this.cropBottomLabel);
            this.panel1.Controls.Add(this.cropTopLabel);
            this.panel1.Controls.Add(this.cropRightInput);
            this.panel1.Controls.Add(this.cropLeftInput);
            this.panel1.Controls.Add(this.cropBottomInput);
            this.panel1.Controls.Add(this.cropTopInput);
            this.panel1.Controls.Add(this.imageView);
            this.panel1.Controls.Add(this.sensitivityLabel);
            this.panel1.Controls.Add(this.processLabel);
            this.panel1.Controls.Add(this.processCombo);
            this.panel1.Controls.Add(this.sensitivityControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 527);
            this.panel1.TabIndex = 4;
            // 
            // updatePreviewButton
            // 
            this.updatePreviewButton.Location = new System.Drawing.Point(229, 400);
            this.updatePreviewButton.Name = "updatePreviewButton";
            this.updatePreviewButton.Size = new System.Drawing.Size(108, 23);
            this.updatePreviewButton.TabIndex = 13;
            this.updatePreviewButton.Text = "Update Preview";
            this.updatePreviewButton.UseVisualStyleBackColor = true;
            this.updatePreviewButton.Click += new System.EventHandler(this.updatePreviewButton_Click);
            // 
            // cropRightLabel
            // 
            this.cropRightLabel.AutoSize = true;
            this.cropRightLabel.Location = new System.Drawing.Point(269, 443);
            this.cropRightLabel.Name = "cropRightLabel";
            this.cropRightLabel.Size = new System.Drawing.Size(57, 13);
            this.cropRightLabel.TabIndex = 12;
            this.cropRightLabel.Text = "Crop Right";
            // 
            // cropLeftLabel
            // 
            this.cropLeftLabel.AutoSize = true;
            this.cropLeftLabel.Location = new System.Drawing.Point(186, 443);
            this.cropLeftLabel.Name = "cropLeftLabel";
            this.cropLeftLabel.Size = new System.Drawing.Size(50, 13);
            this.cropLeftLabel.TabIndex = 11;
            this.cropLeftLabel.Text = "Crop Left";
            // 
            // cropBottomLabel
            // 
            this.cropBottomLabel.AutoSize = true;
            this.cropBottomLabel.Location = new System.Drawing.Point(98, 443);
            this.cropBottomLabel.Name = "cropBottomLabel";
            this.cropBottomLabel.Size = new System.Drawing.Size(65, 13);
            this.cropBottomLabel.TabIndex = 10;
            this.cropBottomLabel.Text = "Crop Bottom";
            // 
            // cropTopLabel
            // 
            this.cropTopLabel.AutoSize = true;
            this.cropTopLabel.Location = new System.Drawing.Point(14, 443);
            this.cropTopLabel.Name = "cropTopLabel";
            this.cropTopLabel.Size = new System.Drawing.Size(51, 13);
            this.cropTopLabel.TabIndex = 9;
            this.cropTopLabel.Text = "Crop Top";
            // 
            // cropRightInput
            // 
            this.cropRightInput.Location = new System.Drawing.Point(271, 459);
            this.cropRightInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cropRightInput.Name = "cropRightInput";
            this.cropRightInput.Size = new System.Drawing.Size(66, 20);
            this.cropRightInput.TabIndex = 8;
            this.cropRightInput.ValueChanged += new System.EventHandler(this.cropRightInput_ValueChanged);
            // 
            // cropLeftInput
            // 
            this.cropLeftInput.Location = new System.Drawing.Point(189, 459);
            this.cropLeftInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cropLeftInput.Name = "cropLeftInput";
            this.cropLeftInput.Size = new System.Drawing.Size(66, 20);
            this.cropLeftInput.TabIndex = 7;
            this.cropLeftInput.ValueChanged += new System.EventHandler(this.cropLeftInput_ValueChanged);
            // 
            // cropBottomInput
            // 
            this.cropBottomInput.Location = new System.Drawing.Point(101, 459);
            this.cropBottomInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cropBottomInput.Name = "cropBottomInput";
            this.cropBottomInput.Size = new System.Drawing.Size(66, 20);
            this.cropBottomInput.TabIndex = 6;
            this.cropBottomInput.ValueChanged += new System.EventHandler(this.cropBottomInput_ValueChanged);
            // 
            // cropTopInput
            // 
            this.cropTopInput.Location = new System.Drawing.Point(17, 459);
            this.cropTopInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cropTopInput.Name = "cropTopInput";
            this.cropTopInput.Size = new System.Drawing.Size(66, 20);
            this.cropTopInput.TabIndex = 5;
            this.cropTopInput.ValueChanged += new System.EventHandler(this.cropTopInput_ValueChanged);
            // 
            // imageView
            // 
            this.imageView.BackColor = System.Drawing.Color.Lime;
            this.imageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageView.Location = new System.Drawing.Point(17, 154);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(320, 240);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView.TabIndex = 4;
            this.imageView.TabStop = false;
            // 
            // similarityLabel
            // 
            this.similarityLabel.AutoSize = true;
            this.similarityLabel.Location = new System.Drawing.Point(272, 55);
            this.similarityLabel.Name = "similarityLabel";
            this.similarityLabel.Size = new System.Drawing.Size(47, 13);
            this.similarityLabel.TabIndex = 14;
            this.similarityLabel.Text = "Similarity";
            // 
            // similarityValue
            // 
            this.similarityValue.Location = new System.Drawing.Point(229, 68);
            this.similarityValue.Name = "similarityValue";
            this.similarityValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.similarityValue.Size = new System.Drawing.Size(100, 23);
            this.similarityValue.TabIndex = 15;
            this.similarityValue.Text = "0.00";
            this.similarityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(21, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(308, 27);
            this.Title.TabIndex = 16;
            this.Title.Text = "Haven: COTK Load Remover";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(14, 497);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(33, 13);
            this.link.TabIndex = 17;
            this.link.TabStop = true;
            this.link.Text = "help?";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(358, 533);
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropRightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropLeftInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBottomInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropTopInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox processCombo;
        private System.Windows.Forms.Label sensitivityLabel;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cropRightLabel;
        private System.Windows.Forms.Label cropLeftLabel;
        private System.Windows.Forms.Label cropBottomLabel;
        private System.Windows.Forms.Label cropTopLabel;
        private System.Windows.Forms.NumericUpDown cropRightInput;
        private System.Windows.Forms.NumericUpDown cropLeftInput;
        private System.Windows.Forms.NumericUpDown cropBottomInput;
        private System.Windows.Forms.NumericUpDown cropTopInput;
        private System.Windows.Forms.PictureBox imageView;
        private System.Windows.Forms.Button updatePreviewButton;
        private System.Windows.Forms.NumericUpDown sensitivityControl;
        private System.Windows.Forms.Label similarityValue;
        private System.Windows.Forms.Label similarityLabel;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label Title;
    }
}