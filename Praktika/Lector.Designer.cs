
namespace Praktika
{
    partial class Lector
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grupės_dalyko_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dalykas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Studento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studento_vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studento_pavardė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Pažymio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pažymys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupės_dalyko_id,
            this.Grupė,
            this.Dalykas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(358, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // Grupės_dalyko_id
            // 
            this.Grupės_dalyko_id.DataPropertyName = "group_subject_id";
            this.Grupės_dalyko_id.HeaderText = "Grupės dalyko id";
            this.Grupės_dalyko_id.Name = "Grupės_dalyko_id";
            this.Grupės_dalyko_id.ReadOnly = true;
            // 
            // Grupė
            // 
            this.Grupė.DataPropertyName = "group_name";
            this.Grupė.HeaderText = "Grupė";
            this.Grupė.Name = "Grupė";
            this.Grupė.ReadOnly = true;
            // 
            // Dalykas
            // 
            this.Dalykas.DataPropertyName = "subject_name";
            this.Dalykas.HeaderText = "Dalykas";
            this.Dalykas.Name = "Dalykas";
            this.Dalykas.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Įveskite grupės dalyko id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Patvirtinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Studento_id,
            this.Studento_vardas,
            this.Studento_pavardė});
            this.dataGridView2.Location = new System.Drawing.Point(376, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(356, 254);
            this.dataGridView2.TabIndex = 4;
            // 
            // Studento_id
            // 
            this.Studento_id.DataPropertyName = "student_id";
            this.Studento_id.HeaderText = "Studento id";
            this.Studento_id.Name = "Studento_id";
            this.Studento_id.ReadOnly = true;
            // 
            // Studento_vardas
            // 
            this.Studento_vardas.DataPropertyName = "FirstName";
            this.Studento_vardas.HeaderText = "Studento vardas";
            this.Studento_vardas.Name = "Studento_vardas";
            this.Studento_vardas.ReadOnly = true;
            // 
            // Studento_pavardė
            // 
            this.Studento_pavardė.DataPropertyName = "LastName";
            this.Studento_pavardė.HeaderText = "Studento pavardė";
            this.Studento_pavardė.Name = "Studento_pavardė";
            this.Studento_pavardė.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Patvirtinti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Įveskite studento id";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pažymio_id,
            this.Tipas,
            this.Pažymys});
            this.dataGridView3.Location = new System.Drawing.Point(738, 386);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(356, 254);
            this.dataGridView3.TabIndex = 8;
            // 
            // Pažymio_id
            // 
            this.Pažymio_id.DataPropertyName = "Mark_id";
            this.Pažymio_id.HeaderText = "Pažymio id";
            this.Pažymio_id.Name = "Pažymio_id";
            this.Pažymio_id.ReadOnly = true;
            // 
            // Tipas
            // 
            this.Tipas.DataPropertyName = "Marktype";
            this.Tipas.HeaderText = "Tipas";
            this.Tipas.Name = "Tipas";
            this.Tipas.ReadOnly = true;
            // 
            // Pažymys
            // 
            this.Pažymys.DataPropertyName = "Mark";
            this.Pažymys.HeaderText = "Pažymys";
            this.Pažymys.Name = "Pažymys";
            this.Pažymys.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Pakeisti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(738, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(738, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Įveskite pažymio id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(873, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Įvesti naują pažymį";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(896, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(896, 300);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pažymys";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(738, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(258, 23);
            this.textBox6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(738, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Įveskite naują pažymį";
            // 
            // Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 652);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lector";
            this.Text = "Lector";
            this.Load += new System.EventHandler(this.Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupės_dalyko_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupė;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dalykas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_pavardė;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pažymio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pažymys;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
    }
}