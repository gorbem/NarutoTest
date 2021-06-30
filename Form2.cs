using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NarutoTest
{
    public partial class Form2 : Form { 
        NarutoTechnics nt;
        public Form2(List<Technique> duplicateTechnics, NarutoTechnics narutoTechics)
        {
            this.nt = narutoTechics;
            InitializeComponent();
            for(int i = 0; i < duplicateTechnics.Count; i++)
            {
                listBox1.Items.Add(duplicateTechnics[i].Name);
            }
            
        }
        void notDuplicaterTecnics(NarutoTechnics narutoTechnics)
        {
            narutoTechnics.nameTechnique.Text = listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            notDuplicateTechnic notDuplicateTechnic = new(notDuplicaterTecnics);
            notDuplicateTechnic(this.nt);
            this.Close();
        }
    }
}
