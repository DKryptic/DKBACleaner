
namespace DKBACleaner
{
    partial class frmMain
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
            this.btn_CleanTraces = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtModernWarfareDirectory = new System.Windows.Forms.RichTextBox();
            this.btnSetMWDirectory = new System.Windows.Forms.Button();
            this.lblModernWarfareDirectoryDesc = new System.Windows.Forms.Label();
            this.lblSetColdWarDirectoryDesc = new System.Windows.Forms.Label();
            this.btnSetCWDirectory = new System.Windows.Forms.Button();
            this.txtColdWarDirectory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_CleanTraces
            // 
            this.btn_CleanTraces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CleanTraces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CleanTraces.FlatAppearance.BorderSize = 3;
            this.btn_CleanTraces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanTraces.Location = new System.Drawing.Point(12, 16);
            this.btn_CleanTraces.Name = "btn_CleanTraces";
            this.btn_CleanTraces.Size = new System.Drawing.Size(503, 39);
            this.btn_CleanTraces.TabIndex = 0;
            this.btn_CleanTraces.Text = "Clean My Machine!";
            this.btn_CleanTraces.UseVisualStyleBackColor = false;
            this.btn_CleanTraces.Click += new System.EventHandler(this.btn_CleanTraces_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(12, 218);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(503, 118);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // txtModernWarfareDirectory
            // 
            this.txtModernWarfareDirectory.BackColor = System.Drawing.Color.Black;
            this.txtModernWarfareDirectory.ForeColor = System.Drawing.Color.White;
            this.txtModernWarfareDirectory.Location = new System.Drawing.Point(12, 158);
            this.txtModernWarfareDirectory.Name = "txtModernWarfareDirectory";
            this.txtModernWarfareDirectory.Size = new System.Drawing.Size(503, 23);
            this.txtModernWarfareDirectory.TabIndex = 2;
            this.txtModernWarfareDirectory.Text = "";
            // 
            // btnSetMWDirectory
            // 
            this.btnSetMWDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetMWDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetMWDirectory.FlatAppearance.BorderSize = 0;
            this.btnSetMWDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMWDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMWDirectory.Location = new System.Drawing.Point(328, 187);
            this.btnSetMWDirectory.Name = "btnSetMWDirectory";
            this.btnSetMWDirectory.Size = new System.Drawing.Size(187, 22);
            this.btnSetMWDirectory.TabIndex = 3;
            this.btnSetMWDirectory.Text = "... Set Modern Warfare Directory ...";
            this.btnSetMWDirectory.UseVisualStyleBackColor = false;
            // 
            // lblModernWarfareDirectoryDesc
            // 
            this.lblModernWarfareDirectoryDesc.AutoSize = true;
            this.lblModernWarfareDirectoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModernWarfareDirectoryDesc.Location = new System.Drawing.Point(12, 142);
            this.lblModernWarfareDirectoryDesc.Name = "lblModernWarfareDirectoryDesc";
            this.lblModernWarfareDirectoryDesc.Size = new System.Drawing.Size(132, 13);
            this.lblModernWarfareDirectoryDesc.TabIndex = 4;
            this.lblModernWarfareDirectoryDesc.Text = "Modern Warfare Directory:";
            // 
            // lblSetColdWarDirectoryDesc
            // 
            this.lblSetColdWarDirectoryDesc.AutoSize = true;
            this.lblSetColdWarDirectoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetColdWarDirectoryDesc.Location = new System.Drawing.Point(12, 75);
            this.lblSetColdWarDirectoryDesc.Name = "lblSetColdWarDirectoryDesc";
            this.lblSetColdWarDirectoryDesc.Size = new System.Drawing.Size(99, 13);
            this.lblSetColdWarDirectoryDesc.TabIndex = 7;
            this.lblSetColdWarDirectoryDesc.Text = "Cold War Directory:";
            // 
            // btnSetCWDirectory
            // 
            this.btnSetCWDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetCWDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetCWDirectory.FlatAppearance.BorderSize = 0;
            this.btnSetCWDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCWDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCWDirectory.Location = new System.Drawing.Point(328, 120);
            this.btnSetCWDirectory.Name = "btnSetCWDirectory";
            this.btnSetCWDirectory.Size = new System.Drawing.Size(187, 22);
            this.btnSetCWDirectory.TabIndex = 6;
            this.btnSetCWDirectory.Text = "... Set Cold War Directory ...";
            this.btnSetCWDirectory.UseVisualStyleBackColor = false;
            this.btnSetCWDirectory.Click += new System.EventHandler(this.btnSetCWDirectory_Click);
            // 
            // txtColdWarDirectory
            // 
            this.txtColdWarDirectory.BackColor = System.Drawing.Color.Black;
            this.txtColdWarDirectory.ForeColor = System.Drawing.Color.White;
            this.txtColdWarDirectory.Location = new System.Drawing.Point(12, 91);
            this.txtColdWarDirectory.Name = "txtColdWarDirectory";
            this.txtColdWarDirectory.Size = new System.Drawing.Size(503, 23);
            this.txtColdWarDirectory.TabIndex = 5;
            this.txtColdWarDirectory.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 348);
            this.Controls.Add(this.lblSetColdWarDirectoryDesc);
            this.Controls.Add(this.btnSetCWDirectory);
            this.Controls.Add(this.txtColdWarDirectory);
            this.Controls.Add(this.lblModernWarfareDirectoryDesc);
            this.Controls.Add(this.btnSetMWDirectory);
            this.Controls.Add(this.txtModernWarfareDirectory);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btn_CleanTraces);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKBACleaner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleanTraces;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.RichTextBox txtModernWarfareDirectory;
        private System.Windows.Forms.Button btnSetMWDirectory;
        private System.Windows.Forms.Label lblModernWarfareDirectoryDesc;
        private System.Windows.Forms.Label lblSetColdWarDirectoryDesc;
        private System.Windows.Forms.Button btnSetCWDirectory;
        private System.Windows.Forms.RichTextBox txtColdWarDirectory;
    }
}

