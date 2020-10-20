namespace Pokladna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxMesic = new System.Windows.Forms.ComboBox();
            this.cBoxRok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateRok = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCDoklad = new System.Windows.Forms.TextBox();
            this.txtPopis = new System.Windows.Forms.TextBox();
            this.numCastka = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoznamka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.btnUlozitJako = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(443, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 560);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxMesic);
            this.groupBox1.Controls.Add(this.cBoxRok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Účetní období";
            // 
            // cBoxMesic
            // 
            this.cBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMesic.FormattingEnabled = true;
            this.cBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.cBoxMesic.Location = new System.Drawing.Point(47, 60);
            this.cBoxMesic.Name = "cBoxMesic";
            this.cBoxMesic.Size = new System.Drawing.Size(121, 21);
            this.cBoxMesic.TabIndex = 3;
            this.cBoxMesic.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // cBoxRok
            // 
            this.cBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRok.FormattingEnabled = true;
            this.cBoxRok.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cBoxRok.Location = new System.Drawing.Point(47, 30);
            this.cBoxRok.Name = "cBoxRok";
            this.cBoxRok.Size = new System.Drawing.Size(121, 21);
            this.cBoxRok.TabIndex = 2;
            this.cBoxRok.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok";
            // 
            // LvData
            // 
            this.LvData.AllowColumnReorder = true;
            this.LvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvData.FullRowSelect = true;
            this.LvData.GridLines = true;
            this.LvData.HideSelection = false;
            this.LvData.Location = new System.Drawing.Point(0, 0);
            this.LvData.Name = "LvData";
            this.LvData.Size = new System.Drawing.Size(443, 560);
            this.LvData.TabIndex = 1;
            this.LvData.UseCompatibleStateImageBehavior = false;
            this.LvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Číslo Dokladu";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUlozitJako);
            this.groupBox2.Controls.Add(this.btnUlozit);
            this.groupBox2.Controls.Add(this.txtPoznamka);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numCastka);
            this.groupBox2.Controls.Add(this.txtPopis);
            this.groupBox2.Controls.Add(this.txtCDoklad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateRok);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(444, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Položka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Popis";
            // 
            // dateRok
            // 
            this.dateRok.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRok.Location = new System.Drawing.Point(83, 20);
            this.dateRok.Name = "dateRok";
            this.dateRok.Size = new System.Drawing.Size(135, 20);
            this.dateRok.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Č. dokladu";
            // 
            // txtCDoklad
            // 
            this.txtCDoklad.Location = new System.Drawing.Point(83, 59);
            this.txtCDoklad.Name = "txtCDoklad";
            this.txtCDoklad.ReadOnly = true;
            this.txtCDoklad.Size = new System.Drawing.Size(135, 20);
            this.txtCDoklad.TabIndex = 6;
            this.txtCDoklad.TextChanged += new System.EventHandler(this.txtCDoklad_TextChanged);
            // 
            // txtPopis
            // 
            this.txtPopis.Location = new System.Drawing.Point(83, 85);
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(150, 20);
            this.txtPopis.TabIndex = 7;
            this.txtPopis.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // numCastka
            // 
            this.numCastka.Location = new System.Drawing.Point(83, 121);
            this.numCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.numCastka.Name = "numCastka";
            this.numCastka.Size = new System.Drawing.Size(135, 20);
            this.numCastka.TabIndex = 8;
            this.numCastka.ValueChanged += new System.EventHandler(this.numCastka_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Částka";
            // 
            // txtPoznamka
            // 
            this.txtPoznamka.Location = new System.Drawing.Point(83, 159);
            this.txtPoznamka.Name = "txtPoznamka";
            this.txtPoznamka.Size = new System.Drawing.Size(150, 20);
            this.txtPoznamka.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Poznámka";
            // 
            // btnUlozit
            // 
            this.btnUlozit.Enabled = false;
            this.btnUlozit.Location = new System.Drawing.Point(158, 200);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(75, 23);
            this.btnUlozit.TabIndex = 12;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.UseVisualStyleBackColor = true;
            // 
            // btnUlozitJako
            // 
            this.btnUlozitJako.Enabled = false;
            this.btnUlozitJako.Location = new System.Drawing.Point(77, 200);
            this.btnUlozitJako.Name = "btnUlozitJako";
            this.btnUlozitJako.Size = new System.Drawing.Size(75, 23);
            this.btnUlozitJako.TabIndex = 13;
            this.btnUlozitJako.Text = "Uložit jako nový";
            this.btnUlozitJako.UseVisualStyleBackColor = true;
            this.btnUlozitJako.Click += new System.EventHandler(this.btnUlozitJako_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LvData);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxMesic;
        private System.Windows.Forms.ComboBox cBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUlozitJako;
        private System.Windows.Forms.Button btnUlozit;
        private System.Windows.Forms.TextBox txtPoznamka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCastka;
        private System.Windows.Forms.TextBox txtPopis;
        private System.Windows.Forms.TextBox txtCDoklad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateRok;
        private System.Windows.Forms.Label label3;
    }
}

