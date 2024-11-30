namespace AsciiArt
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGen = new Button();
            btnClear = new Button();
            ofdChoose = new OpenFileDialog();
            sfdSave = new SaveFileDialog();
            btnChoose = new Button();
            btnSave = new Button();
            txtPath = new TextBox();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // btnGen
            // 
            btnGen.Location = new Point(943, 449);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(134, 54);
            btnGen.TabIndex = 0;
            btnGen.Text = "Generate";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(943, 389);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 54);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(943, 269);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(134, 54);
            btnChoose.TabIndex = 2;
            btnChoose.Text = "Choose File";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(943, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 54);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 12);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(1065, 30);
            txtPath.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(12, 48);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(925, 464);
            lstOut.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 515);
            Controls.Add(lstOut);
            Controls.Add(txtPath);
            Controls.Add(btnSave);
            Controls.Add(btnChoose);
            Controls.Add(btnClear);
            Controls.Add(btnGen);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMain";
            Text = "Ascii Art Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGen;
        private Button btnClear;
        private OpenFileDialog ofdChoose;
        private SaveFileDialog sfdSave;
        private Button btnChoose;
        private Button btnSave;
        private TextBox txtPath;
        private ListBox lstOut;
    }
}
