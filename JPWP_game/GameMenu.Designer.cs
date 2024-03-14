
namespace JPWP_game
{
    partial class GameMenu
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
            this.resume = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.Transparent;
            this.resume.BackgroundImage = global::JPWP_game.Properties.Resources.resume;
            this.resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resume.Location = new System.Drawing.Point(214, 157);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(469, 181);
            this.resume.TabIndex = 1;
            this.resume.TabStop = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            this.resume.MouseLeave += new System.EventHandler(this.resume_MouseLeave);
            this.resume.MouseHover += new System.EventHandler(this.resume_MouseHover);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.BackgroundImage = global::JPWP_game.Properties.Resources.help;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.help.Location = new System.Drawing.Point(214, 380);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(469, 170);
            this.help.TabIndex = 2;
            this.help.TabStop = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            this.help.MouseLeave += new System.EventHandler(this.help_MouseLeave);
            this.help.MouseHover += new System.EventHandler(this.help_MouseHover);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::JPWP_game.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(214, 615);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(469, 163);
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JPWP_game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 930);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.resume);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(914, 977);
            this.MinimumSize = new System.Drawing.Size(914, 977);
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.resume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox resume;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.PictureBox exit;
    }
}