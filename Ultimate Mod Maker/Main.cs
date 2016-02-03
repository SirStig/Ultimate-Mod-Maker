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
        //!!!!!Main Var for all the mods!!!!!
        string modificationsList = "//Made_with_Ultimate_Mod_Maker\n\n";
        string mods = "var Ultimate_Mod_Maker_Mod = {};\n(function () {\n" + "//Made_with_Ultimate_Mod_Maker\n\n" + "})();";
        string topics = "";
        string infoString = "";
        string modificationsCreated = "";

        public Main()
        {
            //Basic Init
            InitializeComponent();
            gdtCustomCodeBox.Text = mods;
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
        }

        //Shows the GDT Menu
        private void gdtShowHide(object sender, EventArgs e)
        {
            if (GDTPanel.Visible.Equals(false))
            {
                GDTPanel.Show();
            }
            else
            {
                GDTPanel.Hide();
                modifications.Hide();
                topicPanel.Hide();
                dMod.Hide();
                warningMod.Hide();
            }
        }

        //Shows the topic menu
        private void topicPanelShowHide(object sender, EventArgs e)
        {
            if (topicPanel.Visible.Equals(false))
            {
                topicPanel.Show();
                modifications.Hide();
                gdtCustomCodeBox.Hide();
                info.Hide();
                dMod.Hide();
                warningMod.Hide();
            }
            else
            {
                topicPanel.Hide();
            }
        }

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
            if (RPGBar.Value == 1)
            {
                rpgV = 0.3;
            }
            else if (RPGBar.Value == 2)
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
            if (!modificationsCreated.Contains(topicNameString))
            {
                ModificationsCustomCode = true;
                topics = topics + "//" + topicNameString + "		\n{\n" + "			" + "id: \"" + topicNameString + "\",\n" + "			" + "name: \"" + topicNameString + "\".localize(\"game topic\"),\n" + "			" + "genreWeightings: [" + actionV + ", " + adventureV + ", " + rpgV + ", " + simulationV + ", " + strategyV + ", " + casualV + "],\n" + "			" + "audienceWeightings: [" + youngV + ", " + everyoneV + ", " + matureV + "]\n" + "	}, //Ending" + topicNameString + " \n";
                string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
                mods = fullMod;
                gdtCustomCodeBox.Text = mods;
                TreeNode newMod = new TreeNode(topicNameString);
                modifications.Nodes[0].Nodes.Add(newMod);
                modificationsCreated = modificationsCreated + "\n" + topicNameString;
                ModificationsCustomCode = false;

            } else
            {
                MessageBox.Show("Topic with that name already created!");
            }
        }

        //Handles the GDT mod naming proccess

        string gdtModNameString = "Ultimate_Mod_Maker_Mod";
        private void changeGDTModName(object sender, EventArgs e)
        {
            ModificationsCustomCode = true;
            gdtModNameString = gdtModNameBox.Text;
            gdtModName.Text = gdtModNameString;
            string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
            mods = fullMod;
            gdtCustomCodeBox.Text = mods;
            ModificationsCustomCode = false;
        }

        //Handles Custom Code being added
        private void customCodeAdded(object sender, EventArgs e)
        {
            //Work in progress
        }

        //Generates the mod file
        //Currently only generates the topic and the basic folder and stuff.

        private void modificationsClicked(object sender, EventArgs e)
        {
            if (modifications.Visible.Equals(false))
            {
                modifications.Show();
                topicPanel.Hide();
                gdtCustomCodeBox.Hide();
                info.Hide();
                dMod.Show();
                warningMod.Show();
            }
            else
            {
                modifications.Hide();
                dMod.Hide();
                warningMod.Hide();
            }
        }
        bool ModificationsCustomCode = false;

        private void deleteModification(object sender, EventArgs e)
        {
            ModificationsCustomCode = true;
            string cc = gdtCustomCodeBox.Text;
            string modification = modifications.SelectedNode.Name;
            modifications.Nodes.Remove(modifications.SelectedNode);

            int v1 = cc.IndexOf("//" + modification);
            int v2 = cc.IndexOf("//Ending" + modification) + ("//Ending" + modification).Length;

            gdtCustomCodeBox.SelectionStart = v1;
            gdtCustomCodeBox.SelectionLength = v2 - v1;
            gdtCustomCodeBox.Cut();
            ModificationsCustomCode = false;
        }

        private void spaceNotAllowed(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }


        private void customCodeClicked(object sender, EventArgs e)
        {
            if (gdtCustomCodeBox.Visible.Equals(false))
            {
                gdtCustomCodeBox.Show();
                modifications.Hide();
                topicPanel.Hide();
                info.Hide();
                dMod.Hide();
                warningMod.Hide();
            }
            else
            {
                gdtCustomCodeBox.Hide();
            }
        }

        private void finishClicked(object sender, EventArgs e)
        {
            if (info.Visible.Equals(false))
            {
                info.Show();
                modifications.Hide();
                topicPanel.Hide();
                gdtCustomCodeBox.Hide();
                dMod.Hide();
                warningMod.Show();
            }
            else
            {
                info.Hide();
            }
        }

        private void finishedInfo(object sender, EventArgs e)
        {
            infoString = "{ \r\n 	\"id\" : \"" + gdtModNameString + "\", \r\n	\"name\" : \"" + gdtModNameString + "\", \r\n	\"version\":\"" + version.Text + "\", \r\n	\"author\":\"" + author.Text + "\", \r\n	\"url\":\"" + url.Text + "\", \r\n	\"description\" : \"" + description.Text + "\", \r\n	\"main\" : \"./properties.js\", \r\n	\"dependencies\" : {\"gdt-modAPI\":\"0.1.x\"} \r\n}";
            string runString = "var " + gdtModNameString + " = {};\n\n" + "(function() {\n" + "		" + gdtModNameString + ".path = GDT.getRelativePath();\n" + "var ready = function () {\n" + gdtModNameString + ".addTopic();" + "\n};\nvar error = function () {\n};\nGDT.loadJs([" + gdtModNameString + ".path + " + "'/" + gdtModNameString + ".js'], ready, error);\n\n})();";
            FolderBrowserDialog gdtFinishTest = new FolderBrowserDialog();
            gdtFinishTest.Description = "Select a directory to save your mod";
            gdtFinishTest.ShowNewFolderButton = false;
            if (gdtFinishTest.ShowDialog() == DialogResult.OK)
            {
                string FolderName = gdtModNameString;
                string folderPath = gdtFinishTest.SelectedPath + @"\" + gdtModNameString;
                string codePath = gdtFinishTest.SelectedPath + @"\" + gdtModNameString + @"\" + gdtModNameString + ".js";
                string infoPath = gdtFinishTest.SelectedPath + @"\" + gdtModNameString + @"\package.json";
                string runPath = gdtFinishTest.SelectedPath + @"\" + gdtModNameString + @"\properties.js";
                Directory.CreateDirectory(folderPath);
                File.WriteAllText(codePath, mods);
                File.WriteAllText(infoPath, infoString);
                File.WriteAllText(runPath, runString);
                info.Hide();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void loadClicked(object sender, EventArgs e)
        {
            loadGDTMod.ShowDialog();
        }

        private void openGDTMod(object sender, CancelEventArgs e)
        {
            System.IO.Stream fileStream = loadGDTMod.OpenFile();
            string modLoaction = Path.GetDirectoryName(loadGDTMod.FileName) + @"\package.json";
            using (FileStream stream = File.Open(modLoaction, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    System.Console.WriteLine("------------------");
                    System.Console.WriteLine(reader.ReadToEnd());
                    System.Console.WriteLine("------------------");
                    string infoPackage = reader.ReadToEnd();
                    int v1 = infoPackage.IndexOf("\"version\":\"") + "\"version\":\"".Length;
                    int v2 = infoPackage.IndexOf("\",//Version");
                    string version = infoPackage.Substring(v1 , v2);
                    Console.WriteLine("Version: " + version);
                }
            }
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            {
                // Read the first line from the file and write it the textbox.
                System.Console.WriteLine("------------------");
                System.Console.WriteLine(reader.ReadToEnd());
                System.Console.WriteLine("------------------");
                gdtModNameString = reader.ReadLine();
                gdtModNameBox.Text = gdtModNameString;
            }
            fileStream.Close();
        }

        private void customCodeChanged(object sender, EventArgs e)
        {
            if(ModificationsCustomCode == false)
            {
                string cc = gdtCustomCodeBox.Text;
                int v1 = cc.IndexOf("//Made_with_Ultimate_Mod_Maker");
                int v2 = cc.LastIndexOf("})();");
                modificationsList = cc.Substring(v1, v2 - v1);
            } else
            {

            }
        }

        /*private void saveDialogOK(object sender, CancelEventArgs e)
        {
            string FolderName = gdtModNameString;
            string folderPath = gdtFinishTest.SelectedPath + @"\" + gdtModNameString;
            Directory.CreateDirectory(folderPath);

        }*/

        private void addPlatformClicked(Object sender, EventArgs e)
        {
            if(addPlatform.Visible.Equals(false))
            {
                addPlatform.Show();
            } else
            {
                addPlatform.Hide();
            }
        }

    }

}