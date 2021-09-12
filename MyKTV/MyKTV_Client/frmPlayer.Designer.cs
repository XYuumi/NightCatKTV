namespace MyKtv_Client
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.wmpSongPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSongPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSongPlayer
            // 
            this.wmpSongPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpSongPlayer.Enabled = true;
            this.wmpSongPlayer.Location = new System.Drawing.Point(0, 0);
            this.wmpSongPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.wmpSongPlayer.Name = "wmpSongPlayer";
            this.wmpSongPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSongPlayer.OcxState")));
            this.wmpSongPlayer.Size = new System.Drawing.Size(528, 422);
            this.wmpSongPlayer.TabIndex = 0;
            this.wmpSongPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 422);
            this.Controls.Add(this.wmpSongPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlayer";
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSongPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer wmpSongPlayer;
    }
}