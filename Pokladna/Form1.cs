﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PokladniZaznam> pokladna;
        IRepos repositar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            //jsonRepos.VytvorTestData();
            SqlRepos sqlRepos = new SqlRepos();
            //sqlRepos.VytvorTestData();
            repositar = sqlRepos;

            cBoxRok.SelectedIndex = cBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            cBoxMesic.SelectedIndex = DateTime.Now.Month - 1;




            //repositar = new SqlRepos();
            //repositar = new XmlRepos();
            //pokladna = repositar.NactiVse();
            //foreach (var p in pokladna)
            //{
            // lvData.Items.Add(p.DoLvItem());
            //}
        }

        private void cBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            NactiDataAktMesic();
        }
        private void NactiDataAktMesic()
        {
            if (cBoxRok.SelectedIndex >= 0 && cBoxMesic.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiVse();
                pokladna = repositar.NactiMesic(int.Parse(cBoxRok.SelectedItem.ToString()), cBoxMesic.SelectedIndex + 1);
                LvData.Items.Clear();
                foreach (var p in pokladna)
                {
                    LvData.Items.Add(p.DoLvItem());
                }
            }
        }

        private void txtCDoklad_TextChanged(object sender, EventArgs e)
        {
            btnUlozit.Enabled = txtCDoklad.Text != "";
        }

        private void txtPopis_TextChanged(object sender, EventArgs e)
        {
            btnUlozitJako.Enabled = txtPopis.Text.Trim() != "" && numCastka.Value != 0;
        }

        private void numCastka_ValueChanged(object sender, EventArgs e)
        {
            btnUlozitJako.Enabled = txtPopis.Text.Trim() != "" && numCastka.Value != 0;
        }

        private void btnUlozitJako_Click(object sender, EventArgs e)
        {
            PokladniZaznam novyZaznam = new PokladniZaznam(dateRok.Value, txtPopis.Text, (double)numCastka.Value, txtPoznamka.Text);
            repositar.VytvorZaznam(novyZaznam);
            NactiDataAktMesic();
            txtPopis.Text = "";
            numCastka.Value =0;
            txtPopis.Text = "";
        }
    }
}
