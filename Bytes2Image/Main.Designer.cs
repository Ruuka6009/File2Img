namespace Bytes2Image
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.liveView = new System.Windows.Forms.PictureBox();
            this.selBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rwbytes = new System.Windows.Forms.Button();
            this.pbRBytes = new System.Windows.Forms.ProgressBar();
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.imgsize = new System.Windows.Forms.Label();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.basePixels = new System.Windows.Forms.Label();
            this.maxPixels = new System.Windows.Forms.Label();
            this.nullPixels = new System.Windows.Forms.Label();
            this.livePreview = new System.Windows.Forms.CheckBox();
            this.switchRW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liveView)).BeginInit();
            this.SuspendLayout();
            // 
            // liveView
            // 
            this.liveView.Image = global::Bytes2Image.Properties.Resources.empty_folder;
            this.liveView.Location = new System.Drawing.Point(412, 12);
            this.liveView.Name = "liveView";
            this.liveView.Size = new System.Drawing.Size(150, 150);
            this.liveView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveView.TabIndex = 0;
            this.liveView.TabStop = false;
            // 
            // selBtn
            // 
            this.selBtn.Location = new System.Drawing.Point(331, 12);
            this.selBtn.Name = "selBtn";
            this.selBtn.Size = new System.Drawing.Size(75, 23);
            this.selBtn.TabIndex = 1;
            this.selBtn.Text = "Select";
            this.selBtn.UseVisualStyleBackColor = true;
            this.selBtn.Click += new System.EventHandler(this.selBtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTxt.Location = new System.Drawing.Point(12, 12);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.ReadOnly = true;
            this.pathTxt.Size = new System.Drawing.Size(313, 23);
            this.pathTxt.TabIndex = 2;
            this.pathTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pathTxt.Click += new System.EventHandler(this.pathTxt_Click);
            // 
            // rwbytes
            // 
            this.rwbytes.Location = new System.Drawing.Point(331, 41);
            this.rwbytes.Name = "rwbytes";
            this.rwbytes.Size = new System.Drawing.Size(52, 23);
            this.rwbytes.TabIndex = 3;
            this.rwbytes.Text = "Read";
            this.rwbytes.UseVisualStyleBackColor = true;
            this.rwbytes.Click += new System.EventHandler(this.rbytes_Click);
            // 
            // pbRBytes
            // 
            this.pbRBytes.Location = new System.Drawing.Point(12, 41);
            this.pbRBytes.Name = "pbRBytes";
            this.pbRBytes.Size = new System.Drawing.Size(275, 23);
            this.pbRBytes.TabIndex = 4;
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Location = new System.Drawing.Point(293, 45);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(32, 15);
            this.currentProgressLabel.TabIndex = 5;
            this.currentProgressLabel.Text = "---%";
            // 
            // imgsize
            // 
            this.imgsize.AutoSize = true;
            this.imgsize.Location = new System.Drawing.Point(12, 67);
            this.imgsize.Name = "imgsize";
            this.imgsize.Size = new System.Drawing.Size(59, 15);
            this.imgsize.TabIndex = 6;
            this.imgsize.Text = "???? x ????";
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Location = new System.Drawing.Point(12, 82);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(50, 15);
            this.coordsLabel.TabIndex = 7;
            this.coordsLabel.Text = "????;????";
            // 
            // basePixels
            // 
            this.basePixels.AutoSize = true;
            this.basePixels.Location = new System.Drawing.Point(98, 67);
            this.basePixels.Name = "basePixels";
            this.basePixels.Size = new System.Drawing.Size(42, 15);
            this.basePixels.TabIndex = 8;
            this.basePixels.Text = "???????";
            // 
            // maxPixels
            // 
            this.maxPixels.AutoSize = true;
            this.maxPixels.Location = new System.Drawing.Point(98, 82);
            this.maxPixels.Name = "maxPixels";
            this.maxPixels.Size = new System.Drawing.Size(42, 15);
            this.maxPixels.TabIndex = 9;
            this.maxPixels.Text = "???????";
            // 
            // nullPixels
            // 
            this.nullPixels.AutoSize = true;
            this.nullPixels.Location = new System.Drawing.Point(187, 75);
            this.nullPixels.Name = "nullPixels";
            this.nullPixels.Size = new System.Drawing.Size(17, 15);
            this.nullPixels.TabIndex = 10;
            this.nullPixels.Text = "??";
            // 
            // livePreview
            // 
            this.livePreview.AutoSize = true;
            this.livePreview.Location = new System.Drawing.Point(315, 71);
            this.livePreview.Name = "livePreview";
            this.livePreview.Size = new System.Drawing.Size(91, 19);
            this.livePreview.TabIndex = 11;
            this.livePreview.Text = "Live preview";
            this.livePreview.UseVisualStyleBackColor = true;
            // 
            // switchRW
            // 
            this.switchRW.Location = new System.Drawing.Point(383, 41);
            this.switchRW.Name = "switchRW";
            this.switchRW.Size = new System.Drawing.Size(23, 23);
            this.switchRW.TabIndex = 12;
            this.switchRW.Text = "🔀";
            this.switchRW.UseVisualStyleBackColor = true;
            this.switchRW.Click += new System.EventHandler(this.switchRW_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 170);
            this.Controls.Add(this.switchRW);
            this.Controls.Add(this.livePreview);
            this.Controls.Add(this.nullPixels);
            this.Controls.Add(this.maxPixels);
            this.Controls.Add(this.basePixels);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.imgsize);
            this.Controls.Add(this.currentProgressLabel);
            this.Controls.Add(this.pbRBytes);
            this.Controls.Add(this.rwbytes);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.selBtn);
            this.Controls.Add(this.liveView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liveView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox liveView;
        private Button selBtn;
        private TextBox pathTxt;
        private OpenFileDialog fileDialog;
        private Button rwbytes;
        private ProgressBar pbRBytes;
        private Label currentProgressLabel;
        private Label imgsize;
        private Label coordsLabel;
        private Label maxPixels;
        private Label basePixels;
        private Label nullPixels;
        private CheckBox livePreview;
        private Button switchRW;
    }
}