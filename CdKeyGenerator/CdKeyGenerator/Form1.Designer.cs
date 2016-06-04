namespace CdKeyGenerator
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
            this.create_button = new System.Windows.Forms.Button();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.Id_label = new System.Windows.Forms.Label();
            this.Key_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(51, 279);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(463, 33);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Id_textBox
            // 
            this.Id_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Id_textBox.Location = new System.Drawing.Point(51, 35);
            this.Id_textBox.MaxLength = 8;
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.ReadOnly = true;
            this.Id_textBox.Size = new System.Drawing.Size(207, 20);
            this.Id_textBox.TabIndex = 1;
            // 
            // Key_textBox
            // 
            this.Key_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Key_textBox.Location = new System.Drawing.Point(51, 77);
            this.Key_textBox.MaxLength = 19;
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.ReadOnly = true;
            this.Key_textBox.Size = new System.Drawing.Size(463, 20);
            this.Key_textBox.TabIndex = 2;
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Location = new System.Drawing.Point(10, 38);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(24, 13);
            this.Id_label.TabIndex = 3;
            this.Id_label.Text = "ID: ";
            // 
            // Key_label
            // 
            this.Key_label.AutoSize = true;
            this.Key_label.Location = new System.Drawing.Point(10, 80);
            this.Key_label.Name = "Key_label";
            this.Key_label.Size = new System.Drawing.Size(31, 13);
            this.Key_label.TabIndex = 4;
            this.Key_label.Text = "Key: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdX,
            this.KeyX});
            this.dataGridView1.Location = new System.Drawing.Point(51, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // IdX
            // 
            this.IdX.HeaderText = "Id";
            this.IdX.Name = "IdX";
            this.IdX.ReadOnly = true;
            // 
            // KeyX
            // 
            this.KeyX.HeaderText = "Key";
            this.KeyX.Name = "KeyX";
            this.KeyX.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Key_label);
            this.Controls.Add(this.Id_label);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.create_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.Label Key_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdX;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyX;
    }
}

