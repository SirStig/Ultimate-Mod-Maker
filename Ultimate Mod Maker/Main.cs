using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Ultimate_Mod_Maker
{

    public partial class Main : Form
    {
        public Main()
        {
            //Basic Init
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Handles what happens when the app is loaded
        }

        /*//Handles settings button being pushed
        private void settingsPushed(object sender, EventArgs e)
        {
            if (settings.Visible.Equals(false))
            {
                settings.Show();
            }
            else
            {
                settings.Hide();
            }

        }*/

        //If quit is clicked the app closes
        private void quitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }/*

        //Shows the GDT Menu
        private void gdtShowHide(object sender, EventArgs e)
        {
            if (GDT.Visible.Equals(false))
            {
                GDT.Show();
            }
            else
            {
                GDT.Hide();
            }
        }

        //Shows the topic menu
        private void topicPanelShowHide(object sender, EventArgs e)
        {
            if (topicPanel.Visible.Equals(false))
            {
                topicPanel.Show();
            }
            else
            {
                topicPanel.Hide();
            }
        }

        //!!!!!Main Var for all the mods!!!!!
        string mods = "";

        //Creates the Variales for topic
        double actionV = 0.6;
        double adventureV = 0.6;
        double rpgV = 0.6;
        double simulationV = 0.6;
        double strategyV = 0.6;
        double casualV = 0.6;

        double youngV = 0.6;
        double everyoneV = 0.6;
        double matureV = 0.6;

        string topicNameString = "Random Topic";

        // Handles Topic Making

        private void actionValueSet(object sender, EventArgs e)
        {
            // Checks to see what the action bar value equals then converts it for GDT modding
            if (actionBar.Value == 1)
            {
                actionV = 0.3;
            }
            else if (actionBar.Value == 2)
            {
                actionV = 0.6;
            }
            else
            {
                actionV = 1;
            }
        }

        private void adventureValueSet(object sender, EventArgs e)
        {
            // Checks to see what the adventure bar value equals then converts it for GDT modding
            if (adventureBar.Value == 1)
            {
                adventureV = 0.3;
            }
            else if (adventureBar.Value == 2)
            {
                adventureV = 0.6;
            }
            else
            {
                adventureV = 1;
            }
        }

        private void rpgValueSet(object sender, EventArgs e)
        {
            // Checks to see what the rpg bar value equals then converts it for GDT modding
            if (rpgBar.Value == 1)
            {
                rpgV = 0.3;
            }
            else if (rpgBar.Value == 2)
            {
                rpgV = 0.6;
            }
            else
            {
                rpgV = 1;
            }
        }

        private void simulationValueSet(object sender, EventArgs e)
        {

            // Checks to see what the simulation bar value equals then converts it for GDT modding
            if (simulationBar.Value == 1)
            {
                simulationV = 0.3;
            }
            else if (simulationBar.Value == 2)
            {
                simulationV = 0.6;
            }
            else
            {
                simulationV = 1;
            }
        }

        private void strategyValueSet(object sender, EventArgs e)
        {
            // Checks to see what the stratgey bar value equals then converts it for GDT modding
            if (strategyBar.Value == 1)
            {
                strategyV = 0.3;
            }
            else if (strategyBar.Value == 2)
            {
                strategyV = 0.6;
            }
            else
            {
                strategyV = 1;
            }
        }

        private void casualValueSet(object sender, EventArgs e)
        {
            // Checks to see what the casual bar value equals then converts it for GDT modding
            if (casualBar.Value == 1)
            {
                casualV = 0.3;
            }
            else if (casualBar.Value == 2)
            {
                casualV = 0.6;
            }
            else
            {
                casualV = 1;
            }
        }

        private void youngValueSet(object sender, EventArgs e)
        {
            if (young.Text == "Bad")
            {
                youngV = 0.3;
            }
            else if (young.Text == "Good")
            {
                youngV = 0.6;
            }
            else
            {
                youngV = 1;
            }
        }

        private void everyoneValueSet(object sender, EventArgs e)
        {
            if (everyone.Text == "Bad")
            {
                everyoneV = 0.3;
            }
            else if (everyone.Text == "Good")
            {
                everyoneV = 0.6;
            }
            else
            {
                everyoneV = 1;
            }
        }

        private void matureValueSet(object sender, EventArgs e)
        {
            if (mature.Text == "Bad")
            {
                matureV = 0.3;
            }
            else if (mature.Text == "Good")
            {
                matureV = 0.6;
            }
            else
            {
                matureV = 1;
            }
        }

        private void topicChangeName(object sender, EventArgs e)
        {
            //Changes the topic name if the topic textbox has changed text
            topicNameString = topicName.Text;
        }

        //Adds the topic to the mods string if the Add Topic button is pushed
        private void addTopicToMods(object sender, EventArgs e)
        {
            mods = mods + "\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		" + "GDT.addTopics([ \n" + "		{" + "			" + "id: \"" + topicNameString + "\",\n" + "			" + "name: \"" + topicNameString + "\".localize(\"game topic\"),\n" + "			" + "genreWeightings: [" + actionV + ", " + adventureV + ", " + rpgV + ", " + simulationV + ", " + strategyV + ", " + casualV + "]," + "			" + "audienceWeightings: [" + youngV + ", " + everyoneV + ", " + matureV + "]\n" + "		}\n" + "		]);\n" + "	};";
        }

        //Handles the GDT mod naming proccess


        string gdtModNameString = "Example";

        private void changeGDTModName(object sender, EventArgs e)
        {
            gdtModNameString = gdtModName.Text;
        }

        //Generates the mod file
        //Currently only generates the topic and the basic folder and stuff.

        private void finishClicked(object sender, EventArgs e)
        {

        }
        */
        private void Main_Load(object sender, EventArgs e)
        {

        }

        /*private void saveDialogOK(object sender, CancelEventArgs e)
        {
            string FolderName = gdtModNameString;
            string folderPath = System.IO.Path.GetDirectoryName(saveGDTFile.FileName);
            string modFile = "var." + gdtModNameString + " = {}; \n (function () { \n" + mods + "\n})();";
            System.IO.Directory.CreateDirectory(folderPath);
        }*/

    }

}