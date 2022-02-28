
namespace Vizsgaform0228
{
    partial class Keresform
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
            this.DGVkeres = new System.Windows.Forms.DataGridView();
            this.idopont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TBkeres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVkeres)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVkeres
            // 
            this.DGVkeres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVkeres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVkeres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVkeres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopont,
            this.nyelv,
            this.szint});
            this.DGVkeres.Location = new System.Drawing.Point(12, 84);
            this.DGVkeres.Name = "DGVkeres";
            this.DGVkeres.RowHeadersVisible = false;
            this.DGVkeres.Size = new System.Drawing.Size(497, 354);
            this.DGVkeres.TabIndex = 0;
            // 
            // idopont
            // 
            this.idopont.HeaderText = "Időpont";
            this.idopont.Name = "idopont";
            // 
            // nyelv
            // 
            this.nyelv.HeaderText = "Nyelv";
            this.nyelv.Name = "nyelv";
            // 
            // szint
            // 
            this.szint.HeaderText = "Szint";
            this.szint.Name = "szint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresés nyelv alapján";
            // 
            // TBkeres
            // 
            this.TBkeres.Location = new System.Drawing.Point(129, 10);
            this.TBkeres.Name = "TBkeres";
            this.TBkeres.Size = new System.Drawing.Size(221, 20);
            this.TBkeres.TabIndex = 4;
            this.TBkeres.TextChanged += new System.EventHandler(this.TBkeres_TextChanged);
            // 
            // Keresform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.TBkeres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVkeres);
            this.Name = "Keresform";
            this.Text = "Keresform";
            this.Load += new System.EventHandler(this.Keresform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVkeres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVkeres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopont;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBkeres;
    }
}