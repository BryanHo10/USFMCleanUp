namespace USFMGroom
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
            this.Btn_Groom = new System.Windows.Forms.Button();
            this.Btn_AddFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPath = new System.Windows.Forms.Label();
            this.Msg_Complete = new System.Windows.Forms.Label();
            this.Msg_Runtime = new System.Windows.Forms.TextBox();
            this.Btn_Groom_Sync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Groom
            // 
            this.Btn_Groom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Groom.Location = new System.Drawing.Point(980, 172);
            this.Btn_Groom.Name = "Btn_Groom";
            this.Btn_Groom.Size = new System.Drawing.Size(233, 108);
            this.Btn_Groom.TabIndex = 0;
            this.Btn_Groom.Text = "Groom Async";
            this.Btn_Groom.UseVisualStyleBackColor = true;
            this.Btn_Groom.Click += new System.EventHandler(this.Btn_Groom_Click);
            // 
            // Btn_AddFiles
            // 
            this.Btn_AddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddFiles.Location = new System.Drawing.Point(76, 172);
            this.Btn_AddFiles.Name = "Btn_AddFiles";
            this.Btn_AddFiles.Size = new System.Drawing.Size(246, 108);
            this.Btn_AddFiles.TabIndex = 1;
            this.Btn_AddFiles.Text = "Open folder";
            this.Btn_AddFiles.UseVisualStyleBackColor = true;
            this.Btn_AddFiles.Click += new System.EventHandler(this.Btn_AddFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder:";
            // 
            // FolderPath
            // 
            this.FolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderPath.Location = new System.Drawing.Point(76, 84);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(1137, 54);
            this.FolderPath.TabIndex = 3;
            // 
            // Msg_Complete
            // 
            this.Msg_Complete.AutoSize = true;
            this.Msg_Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg_Complete.Location = new System.Drawing.Point(544, 734);
            this.Msg_Complete.Name = "Msg_Complete";
            this.Msg_Complete.Size = new System.Drawing.Size(216, 44);
            this.Msg_Complete.TabIndex = 4;
            this.Msg_Complete.Text = "Completed!";
            this.Msg_Complete.Visible = false;
            // 
            // Msg_Runtime
            // 
            this.Msg_Runtime.BackColor = System.Drawing.SystemColors.Control;
            this.Msg_Runtime.Location = new System.Drawing.Point(76, 316);
            this.Msg_Runtime.Multiline = true;
            this.Msg_Runtime.Name = "Msg_Runtime";
            this.Msg_Runtime.ReadOnly = true;
            this.Msg_Runtime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Msg_Runtime.Size = new System.Drawing.Size(1136, 381);
            this.Msg_Runtime.TabIndex = 5;
            // 
            // Btn_Groom_Sync
            // 
            this.Btn_Groom_Sync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Groom_Sync.Location = new System.Drawing.Point(690, 172);
            this.Btn_Groom_Sync.Name = "Btn_Groom_Sync";
            this.Btn_Groom_Sync.Size = new System.Drawing.Size(233, 108);
            this.Btn_Groom_Sync.TabIndex = 6;
            this.Btn_Groom_Sync.Text = "Groom Sync";
            this.Btn_Groom_Sync.UseVisualStyleBackColor = true;
            this.Btn_Groom_Sync.Click += new System.EventHandler(this.Btn_Groom_Sync_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 804);
            this.Controls.Add(this.Btn_Groom_Sync);
            this.Controls.Add(this.Msg_Runtime);
            this.Controls.Add(this.Msg_Complete);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_AddFiles);
            this.Controls.Add(this.Btn_Groom);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Groom;
        private System.Windows.Forms.Button Btn_AddFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FolderPath;
        private System.Windows.Forms.Label Msg_Complete;
        private System.Windows.Forms.TextBox Msg_Runtime;
        private System.Windows.Forms.Button Btn_Groom_Sync;
    }
}

