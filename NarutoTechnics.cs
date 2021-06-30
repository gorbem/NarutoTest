using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NarutoTest
{
    delegate void notDuplicateTechnic(NarutoTechnics narutoTechnics);
    public partial class NarutoTechnics : Form
    {   
        private static string json = File.ReadAllText("techniques.json", Encoding.UTF8);
        private static Root root = JsonConvert.DeserializeObject<Root>(json);
        private static List<Technique> techniques = root.Techniques;

        public NarutoTechnics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cast_Click(object sender, EventArgs e)
        {
            List<Technique> duplicateTechnics = new List<Technique>();
            int count = 0;
            for (int i = 0; i < techniques.Count; i++)
            {
                if (castList.Items.Count == techniques[i].SealList.Count)
                    for (int j = 0; j < castList.Items.Count; j++)
                        if (castList.Items[j].ToString() == techniques[i].SealList[j])
                            count++;
                        else
                            break;
                if (count == techniques[i].SealList.Count)
                {
                    duplicateTechnics.Add(techniques[i]);
                }
                count = 0;
            }
            if (duplicateTechnics.Count > 1)
            {
                Form2 chooseTechnics = new(duplicateTechnics, this);
                chooseTechnics.Activate();
                chooseTechnics.Visible = true;
            }
            else if(duplicateTechnics.Count > 0)
                nameTechnique.Text = duplicateTechnics[0].Name;
            castList.Items.Clear();
        }

        private void boar_Click(object sender, EventArgs e)
        {
            castList.Items.Add("boar");
        }//

        private void rat_Click(object sender, EventArgs e)
        {
            castList.Items.Add("rat");
        }//

        private void snake_Click(object sender, EventArgs e)
        {
            castList.Items.Add("snake");
        }//

        private void tiger_Click(object sender, EventArgs e)
        {
            castList.Items.Add("tiger");
        }//

        private void dog_Click(object sender, EventArgs e)
        {
            castList.Items.Add("dog");
        }//

        private void horse_Click(object sender, EventArgs e)
        {
            castList.Items.Add("horse");
        }//

        private void monkey_Click(object sender, EventArgs e)
        {
            castList.Items.Add("monkey");
        }

        private void rabbit_Click(object sender, EventArgs e)
        {
            castList.Items.Add("rabbit");
        }//

        private void inconcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("inconcent");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            castList.Items.Clear();
        }

        private void sheep_Click(object sender, EventArgs e)
        {
            castList.Items.Add("sheep");
        }//

        private void brokenMonkey_Click(object sender, EventArgs e)
        {
            castList.Items.Add("broken Monkey");
        }

        private void common_Click(object sender, EventArgs e)
        {
            castList.Items.Add("common");
        }

        private void cooconcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("cooconcent");
        }

        private void denseconcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("denseconcent");
        }

        private void dragon_Click(object sender, EventArgs e)
        {
            castList.Items.Add("dragon");
        }//

        private void duplicate_Click(object sender, EventArgs e)
        {
            castList.Items.Add("duplicate");
        }

        private void eel_Click(object sender, EventArgs e)
        {
            castList.Items.Add("eel");
        }

        private void elephant_Click(object sender, EventArgs e)
        {
            castList.Items.Add("elephant");
        }

        private void handBreadth_Click(object sender, EventArgs e)
        {
            castList.Items.Add("handnreadth");
        }

        private void handConcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("handconcent");
        }

        private void magnetism_Click(object sender, EventArgs e)
        {
            castList.Items.Add("magnetism");
        }

        private void ox_Click(object sender, EventArgs e)
        {
            castList.Items.Add("ox");
        }//

        private void permConcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("perm Concent");
        }

        private void plexus_Click(object sender, EventArgs e)
        {
            castList.Items.Add("plexus");
        }

        private void rooster_Click(object sender, EventArgs e)
        {
            castList.Items.Add("rooster");
        }//

        private void ship_Click(object sender, EventArgs e)
        {
            castList.Items.Add("ship");
        }

        private void shoulderConcent_Click(object sender, EventArgs e)
        {
            castList.Items.Add("shoulderconcent");
        }

        private void spiderHeal_Click(object sender, EventArgs e)
        {
            castList.Items.Add("spiderheal");
        }

        private void volform_Click(object sender, EventArgs e)
        {
            castList.Items.Add("volform");
        }

        readonly ToolTip tip = new();
        private void MyMouseHover(object sender, EventArgs e)
        {
            StringBuilder builder = new((sender as PictureBox).Name);
            builder[0] = builder[0].ToString().ToUpper().ToCharArray()[0];
            tip.SetToolTip(sender as PictureBox, builder.ToString());
        }
    }
}