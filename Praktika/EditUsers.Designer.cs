
namespace Praktika
{
    partial class EditUsers
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Studento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studento_vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studento_pavardė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Dalyko_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dalykas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_pavardė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Šalinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Įveskite studento id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Studento_id,
            this.Studento_vardas,
            this.Studento_pavardė,
            this.Grupė});
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(450, 226);
            this.dataGridView1.TabIndex = 3;
            // 
            // Studento_id
            // 
            this.Studento_id.DataPropertyName = "student_id";
            this.Studento_id.HeaderText = "Studento id";
            this.Studento_id.Name = "Studento_id";
            // 
            // Studento_vardas
            // 
            this.Studento_vardas.DataPropertyName = "FirstName";
            this.Studento_vardas.HeaderText = "Studento vardas";
            this.Studento_vardas.Name = "Studento_vardas";
            // 
            // Studento_pavardė
            // 
            this.Studento_pavardė.DataPropertyName = "LastName";
            this.Studento_pavardė.HeaderText = "Studento pavardė";
            this.Studento_pavardė.Name = "Studento_pavardė";
            // 
            // Grupė
            // 
            this.Grupė.DataPropertyName = "group_name";
            this.Grupė.HeaderText = "Grupė";
            this.Grupė.Name = "Grupė";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dalyko_id,
            this.Dalykas});
            this.dataGridView2.Location = new System.Drawing.Point(480, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(252, 226);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dėstytojo_id,
            this.Dėstytojo_vardas,
            this.Dėstytojo_pavardė});
            this.dataGridView3.Location = new System.Drawing.Point(738, 333);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(367, 226);
            this.dataGridView3.TabIndex = 5;
            // 
            // Dalyko_id
            // 
            this.Dalyko_id.DataPropertyName = "subject_id";
            this.Dalyko_id.HeaderText = "Dalyko id";
            this.Dalyko_id.Name = "Dalyko_id";
            // 
            // Dalykas
            // 
            this.Dalykas.DataPropertyName = "subject_name";
            this.Dalykas.HeaderText = "Dalykas";
            this.Dalykas.Name = "Dalykas";
            // 
            // Dėstytojo_id
            // 
            this.Dėstytojo_id.DataPropertyName = "lector_id";
            this.Dėstytojo_id.HeaderText = "Dėstytojo id";
            this.Dėstytojo_id.Name = "Dėstytojo_id";
            // 
            // Dėstytojo_vardas
            // 
            this.Dėstytojo_vardas.DataPropertyName = "FirstName";
            this.Dėstytojo_vardas.HeaderText = "Dėstytojo vardas";
            this.Dėstytojo_vardas.Name = "Dėstytojo_vardas";
            // 
            // Dėstytojo_pavardė
            // 
            this.Dėstytojo_pavardė.DataPropertyName = "LastName";
            this.Dėstytojo_pavardė.HeaderText = "Dėstytojo pavardė";
            this.Dėstytojo_pavardė.Name = "Dėstytojo_pavardė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(817, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Įveskite dėstytojo id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(817, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 23);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(940, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Šalinti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(511, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Įveskite dėstytojo id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(511, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(511, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Įveskite dalyko id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(511, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 23);
            this.textBox4.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Priskirti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(808, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dėstytojo šalinimas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(425, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dalyko priskirimas dėstytojui";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Studento šalinimas";
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studento_pavardė;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupė;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dalyko_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dalykas;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_pavardė;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}