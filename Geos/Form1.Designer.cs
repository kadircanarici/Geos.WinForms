namespace Geos
{
    partial class Form1
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
            this.btnAddMultiply = new System.Windows.Forms.Button();
            this.btnZagzig = new System.Windows.Forms.Button();
            this.btnMTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMultiply
            // 
            this.btnAddMultiply.Location = new System.Drawing.Point(27, 54);
            this.btnAddMultiply.Name = "btnAddMultiply";
            this.btnAddMultiply.Size = new System.Drawing.Size(103, 73);
            this.btnAddMultiply.TabIndex = 0;
            this.btnAddMultiply.Text = "Topla ve Çarp";
            this.btnAddMultiply.UseVisualStyleBackColor = true;
            this.btnAddMultiply.Click += new System.EventHandler(this.btnAddMultiply_Click);
            // 
            // btnZagzig
            // 
            this.btnZagzig.Location = new System.Drawing.Point(171, 54);
            this.btnZagzig.Name = "btnZagzig";
            this.btnZagzig.Size = new System.Drawing.Size(103, 73);
            this.btnZagzig.TabIndex = 1;
            this.btnZagzig.Text = "Zigzag";
            this.btnZagzig.UseVisualStyleBackColor = true;
            this.btnZagzig.Click += new System.EventHandler(this.btnZagzig_Click);
            // 
            // btnMTable
            // 
            this.btnMTable.Location = new System.Drawing.Point(321, 54);
            this.btnMTable.Name = "btnMTable";
            this.btnMTable.Size = new System.Drawing.Size(103, 73);
            this.btnMTable.TabIndex = 2;
            this.btnMTable.Text = "Çarpım Tablosu";
            this.btnMTable.UseVisualStyleBackColor = true;
            this.btnMTable.Click += new System.EventHandler(this.btnMTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 172);
            this.Controls.Add(this.btnMTable);
            this.Controls.Add(this.btnZagzig);
            this.Controls.Add(this.btnAddMultiply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMultiply;
        private System.Windows.Forms.Button btnZagzig;
        private System.Windows.Forms.Button btnMTable;
    }
}

