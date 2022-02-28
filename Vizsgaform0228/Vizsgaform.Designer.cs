
namespace Vizsgaform0228
{
    partial class Vizsgaform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSZUL = new System.Windows.Forms.TextBox();
            this.tbTEL = new System.Windows.Forms.TextBox();
            this.tbNEV = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szülidő";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(76, 27);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 4;
            // 
            // tbSZUL
            // 
            this.tbSZUL.Location = new System.Drawing.Point(76, 168);
            this.tbSZUL.Name = "tbSZUL";
            this.tbSZUL.Size = new System.Drawing.Size(100, 20);
            this.tbSZUL.TabIndex = 5;
            // 
            // tbTEL
            // 
            this.tbTEL.Location = new System.Drawing.Point(76, 123);
            this.tbTEL.Name = "tbTEL";
            this.tbTEL.Size = new System.Drawing.Size(100, 20);
            this.tbTEL.TabIndex = 6;
            // 
            // tbNEV
            // 
            this.tbNEV.Location = new System.Drawing.Point(76, 76);
            this.tbNEV.Name = "tbNEV";
            this.tbNEV.Size = new System.Drawing.Size(100, 20);
            this.tbNEV.TabIndex = 7;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(216, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 51);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Törlés";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_new.Location = new System.Drawing.Point(216, 189);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(84, 51);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "Új";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_mod.Location = new System.Drawing.Point(216, 107);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(84, 51);
            this.btn_mod.TabIndex = 10;
            this.btn_mod.Text = "Módosít";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // Vizsgaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 285);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tbNEV);
            this.Controls.Add(this.tbTEL);
            this.Controls.Add(this.tbSZUL);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vizsgaform";
            this.Text = "Vizsgaform";
            this.Load += new System.EventHandler(this.Vizsgaform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_mod;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbSZUL;
        public System.Windows.Forms.TextBox tbTEL;
        public System.Windows.Forms.TextBox tbNEV;
    }
}