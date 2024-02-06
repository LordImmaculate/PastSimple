using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PastSimple
{
    public partial class Form1 : Form
    {
        string solution;
        bool audio = true;
        public Form1()
        {
            InitializeComponent();
            randomVerb();
        }
        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            checkVerb();
        }

        void randomVerb()
        {
            List<(string, string)> irregularVerbs = new List<(string, string)>
            {
    ("arise", "arose"),
    ("bear", "bore"),
    ("beat", "beat"),
    ("bend", "bent"),
    ("bet", "bet"),
    ("bid", "bid"),
    ("bite", "bit"),
    ("blow", "blew"),
    ("bring", "brought"),
    ("build", "built"),
    ("burst", "burst"),
    ("buy", "bought"),
    ("cast", "cast"),
    ("catch", "caught"),
    ("choose", "chose"),
    ("come", "came"),
    ("cost", "cost"),
    ("cut", "cut"),
    ("deal", "dealt"),
    ("dig", "dug"),
    ("do", "did"),
    ("draw", "drew"),
    ("drink", "drank"),
    ("drive", "drove"),
    ("eat", "ate"),
    ("fall", "fell"),
    ("feed", "fed"),
    ("feel", "felt"),
    ("fight", "fought"),
    ("find", "found"),
    ("fly", "flew"),
    ("forget", "forgot"),
    ("forgive", "forgave"),
    ("freeze", "froze"),
    ("get", "got"),
    ("give", "gave"),
    ("go", "went"),
    ("grow", "grew"),
    ("hang", "hung"),
    ("have", "had"),
    ("hear", "heard"),
    ("hide", "hid"),
    ("hit", "hit"),
    ("hold", "held"),
    ("hurt", "hurt"),
    ("keep", "kept"),
    ("know", "knew"),
    ("lay", "laid"),
    ("lead", "led"),
    ("leave", "left"),
    ("lend", "lent"),
    ("let", "let"),
    ("lie", "lay"),
    ("light", "lit"),
    ("lose", "lost"),
    ("make", "made"),
    ("mean", "meant"),
    ("meet", "met"),
    ("pay", "paid"),
    ("prove", "proved"),
    ("put", "put"),
    ("quit", "quit"),
    ("read", "read"),
    ("ride", "rode"),
    ("ring", "rang"),
    ("rise", "rose"),
    ("run", "ran"),
    ("say", "said"),
    ("see", "saw"),
    ("seek", "sought"),
    ("sell", "sold"),
    ("send", "sent"),
    ("set", "set"),
    ("shake", "shook"),
    ("shine", "shone"),
    ("shoot", "shot"),
    ("show", "showed"),
    ("shut", "shut"),
    ("sing", "sang"),
    ("sink", "sank"),
    ("sit", "sat"),
    ("sleep", "slept"),
    ("slide", "slid"),
    ("speak", "spoke"),
    ("spend", "spent"),
    ("split", "split"),
    ("spread", "spread"),
    ("stand", "stood"),
    ("steal", "stole"),
    ("stick", "stuck"),
    ("strike", "struck"),
    ("swear", "swore"),
    ("swim", "swam"),
    ("take", "took"),
    ("teach", "taught"),
    ("tear", "tore"),
    ("tell", "told"),
    ("think", "thought"),
    ("throw", "threw"),
    ("understand", "understood"),
    ("undertake", "undertook"),
    ("upset", "upset"),
    ("wake", "woke"),
    ("wear", "wore"),
    ("win", "won"),
    ("wind", "wound"),
    ("write", "wrote")
};

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, irregularVerbs.Count);
            string randomKey = irregularVerbs[randomIndex].Item1; // Accessing the first item of the tuple
            solution = irregularVerbs[randomIndex].Item2;

            labelVerb.Text = randomKey;
        }
        void checkVerb()
        {
            if (textBoxVerb.Text == solution)
            {
                labelCorrect.Visible = true;
                labelCorrect.Text = "Correct!";
                labelCorrect.ForeColor = System.Drawing.Color.Green;
                labelSolution.Visible = false;
                textBoxVerb.Text = "";
                soundPlayer("correctSound.wav");
                randomVerb();
            }
            else
            {
                labelCorrect.Visible = true;
                labelCorrect.Text = "Incorrect";
                labelCorrect.ForeColor = System.Drawing.Color.Red;
                labelSolution.Visible = true;
                labelSolution.Text = "The correct answer is: " + solution;
                textBoxVerb.Text = "";
            }
        }
        private void textBoxVerb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                checkVerb();
            }
        }

        void soundPlayer(string sound)
        {
            if (audio)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:/Windows/Media/tada.wav";
                player.Play();
            }
        }

        private void toolStripButtonMute_Click(object sender, EventArgs e)
        {
            if (audio)
            {
                audio = false;
                toolStripButtonMute.Image = PastSimple.Properties.Resources.unmuted;
            }
            else
            {
                audio = true;
                toolStripButtonMute.Image = PastSimple.Properties.Resources.muted;
            }
        }
    }
}