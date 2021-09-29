
namespace MigrationsToolOberfläche
{
    partial class AuswahlFenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdOpenFile = new System.Windows.Forms.Button();
            this.CmdHelp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.LblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpenFile
            // 
            this.CmdOpenFile.Location = new System.Drawing.Point(596, 337);
            this.CmdOpenFile.Name = "CmdOpenFile";
            this.CmdOpenFile.Size = new System.Drawing.Size(135, 33);
            this.CmdOpenFile.TabIndex = 0;
            this.CmdOpenFile.Text = "Datei Öffnen";
            this.CmdOpenFile.UseVisualStyleBackColor = true;
            // 
            // CmdHelp
            // 
            this.CmdHelp.Location = new System.Drawing.Point(734, 27);
            this.CmdHelp.Name = "CmdHelp";
            this.CmdHelp.Size = new System.Drawing.Size(33, 32);
            this.CmdHelp.TabIndex = 1;
            this.CmdHelp.Text = "?";
            this.CmdHelp.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(30, 41);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(416, 17);
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Auswahl der XML Datei zur Migrierung in das XRechnungsformat";
            // 
            // AuswahlFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.CmdHelp);
            this.Controls.Add(this.CmdOpenFile);
            this.Name = "AuswahlFenster";
            this.Text = "AuswahlFenster";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOpenFile;
        private System.Windows.Forms.Button CmdHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label LblDescription;
    }
}

