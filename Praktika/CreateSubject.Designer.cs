
namespace Praktika
{
    partial class CreateSubject
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dalyko_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dalykai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Grupės = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupės_dalyko_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupės_dalykai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupės_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Dėstytojo_Dalykai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dėstytojo_pavardė = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atgal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sukurti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Įveskite dalyko pavadinimą";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 23);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dalyko_id,
            this.Dalykai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(286, 284);
            this.dataGridView1.TabIndex = 5;
            // 
            // Dalyko_id
            // 
            this.Dalyko_id.DataPropertyName = "subject_id";
            this.Dalyko_id.HeaderText = "Dalyko id";
            this.Dalyko_id.Name = "Dalyko_id";
            // 
            // Dalykai
            // 
            this.Dalykai.DataPropertyName = "subject_name";
            this.Dalykai.HeaderText = "Dalykai";
            this.Dalykai.Name = "Dalykai";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Įveskite dalyko id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Šalinti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupės,
            this.Grupės_dalyko_id,
            this.Grupės_dalykai,
            this.Grupės_id});
            this.dataGridView2.Location = new System.Drawing.Point(333, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(315, 284);
            this.dataGridView2.TabIndex = 11;
            // 
            // Grupės
            // 
            this.Grupės.DataPropertyName = "group_name";
            this.Grupės.HeaderText = "Grupės";
            this.Grupės.Name = "Grupės";
            // 
            // Grupės_dalyko_id
            // 
            this.Grupės_dalyko_id.DataPropertyName = "group_subject_id";
            this.Grupės_dalyko_id.HeaderText = "Grupės dalyko id";
            this.Grupės_dalyko_id.Name = "Grupės_dalyko_id";
            // 
            // Grupės_dalykai
            // 
            this.Grupės_dalykai.DataPropertyName = "subject_name";
            this.Grupės_dalykai.HeaderText = "Grupės dalykai";
            this.Grupės_dalykai.Name = "Grupės_dalykai";
            // 
            // Grupės_id
            // 
            this.Grupės_id.DataPropertyName = "group_id";
            this.Grupės_id.HeaderText = "Grupės id";
            this.Grupės_id.Name = "Grupės_id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 23);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(340, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Įveskite dalyko id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(339, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(280, 23);
            this.textBox4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(339, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Įveskite grupės id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Priskirti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dėstytojo_Dalykai,
            this.Dėstytojo_id,
            this.Dėstytojo_vardas,
            this.Dėstytojo_pavardė});
            this.dataGridView3.Location = new System.Drawing.Point(654, 335);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(444, 284);
            this.dataGridView3.TabIndex = 18;
            // 
            // Dėstytojo_Dalykai
            // 
            this.Dėstytojo_Dalykai.DataPropertyName = "subject_name";
            this.Dėstytojo_Dalykai.HeaderText = "Dalykai";
            this.Dėstytojo_Dalykai.Name = "Dėstytojo_Dalykai";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sukurti/pašalinti dalyką";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(361, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Priskirti dalyką prie grupės";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(862, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Priskirti";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(657, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 23);
            this.textBox5.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(657, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "Įveskite grupės dalyko id";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(657, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(280, 23);
            this.textBox6.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(658, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 30);
            this.label8.TabIndex = 21;
            this.label8.Text = "Įveskite dėstytojo id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(653, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Priskirti dėstytoją prie grupės dalyko";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(756, 306);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(943, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Atgal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(862, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "Peržiūrėti";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dėstytojo id";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(544, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "Atgal";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(463, 305);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 32;
            this.button9.Text = "Peržiūrėti";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(415, 306);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(42, 23);
            this.textBox8.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Grupės id";
            // 
            // CreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 631);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CreateSubject";
            this.Text = "CreateSubject";
            this.Load += new System.EventHandler(this.CreateSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dalyko_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dalykai;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_Dalykai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dėstytojo_pavardė;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupės;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupės_dalyko_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupės_dalykai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupės_id;
    }
}