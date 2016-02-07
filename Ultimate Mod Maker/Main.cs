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
using ICSharpCode.TextEditor;
using ICSharpCode;
using System.Timers;
using System.Deployment.Application;

namespace Ultimate_Mod_Maker
{

    public partial class Main : Form
    {
        //!!!!!Main Var for all the mods!!!!!
        string modificationsList = "//Made_with_Ultimate_Mod_Maker\n\n";
        string mods = "var Ultimate_Mod_Maker_Mod = {};\n(function () {\n" + "//Made_with_Ultimate_Mod_Maker\n\n" + "})();";
        string topics = "";
        string platforms = "";
        string infoString = "";
        string modificationsCreated = "";
        int modsAmount = 0;
        bool modifyingTopic = false;
        int photosAmount = 0;

        string resourcesB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"UltimateMM\Resources");
        string ummFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UltimateMM");
        string settings = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"UltimateMM\Settings.txt");

        bool customBackgroundEnabled = false;

        public Main()
        {
            string resources = string.Join("", resourcesB);
            //Basic Init
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 15000; //15 Seconds
            aTimer.Enabled = true;
            InitializeComponent();
            gdtCustomCodeBox.Text = mods;

            string NewSettings = "CustomImages=false,";
            if (!Directory.Exists(ummFolder))
            {
                Directory.CreateDirectory(ummFolder);
                Directory.CreateDirectory(resources);
                File.WriteAllText(settings, NewSettings);
                customBackgroundEnabled = false;
            }
            else
            {
                if (!File.Exists(settings))
                {
                    File.WriteAllText(settings, NewSettings);
                    customBackgroundEnabled = false;
                    if (!Directory.Exists(resources))
                    {
                        Directory.CreateDirectory(resources);
                    }
                }
                else
                {
                    if (!Directory.Exists(resources))
                    {
                        Directory.CreateDirectory(resources);
                    }
                    using (FileStream stream = File.Open(settings, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string settings = reader.ReadToEnd();

                            int n1 = settings.IndexOf("CustomImages=") + ("CustomImages=").Length;
                            int n2 = settings.IndexOf(",");

                            string ImageEnabled = settings.Substring(n1, n2 - n1);
                            int count = Directory.GetFiles(resources).Length;
                            if (ImageEnabled == "true")
                            {
                                addBckgImage.Enabled = true;
                                useCustomImages.Checked = true;
                                customBackgroundEnabled = true;

                                photosAmount = count;
                            } else
                            {
                                addBckgImage.Enabled = false;
                                useCustomImages.Checked = false;
                                customBackgroundEnabled = false;

                                photosAmount = count;
                            }
                        }
                    }
                }
            }
            if (customBackgroundEnabled == false)
            {
                Random r = new Random();
                int rInt = r.Next(1, 9);
                if (rInt == 1)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.KXJzdk5_6878786_lrg;
                }
                else if (rInt == 2)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.maxresdefault;
                }
                else if (rInt == 3)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.minecraft_shaders_sunset172_sonic_ethers_unbelievable_shaders_and_glsl_shaders_mod_neojp64v;
                }
                else if (rInt == 4)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Lh1uC;
                }
                else if (rInt == 5)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources._635527313118483321;
                }
                else if (rInt == 6)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources._35ScreenN;
                }
                else if (rInt == 7)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Poster2;
                }
                else if (rInt == 8)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Screen13;
                }
                else if (rInt == 9)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.screen66;
                }

            } else
            {
                if (photosAmount != 0)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, photosAmount);
                    string path = resourcesB + @"\" + rInt.ToString() + ".png";
                    try
                    {
                        GDTPanel.BackgroundImage = Image.FromFile(path);
                    }
                    catch
                    {
                        GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.BackGround;
                    }
                } else
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.BackGround;
                }
            }

            if (photosAmount != 0)
            {
                int currentPhoto = 1;
                while (currentPhoto != photosAmount + 1)
                {
                    var btn = new Button { Name = currentPhoto.ToString(), Text = "", BackColor = TransparencyKey, Image = Image.FromFile(Path.Combine(resourcesB + @"\" + currentPhoto + ".png")), Width = 50, Height = 50 };
                    btn.Click += new EventHandler(customImageClicked);
                    backgoundImages.Controls.Add(btn);
                    currentPhoto = currentPhoto + 1;
                }
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (customBackgroundEnabled == false)
            {
                Random r = new Random();
                int rInt = r.Next(1, 9);
                if (rInt == 1)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.KXJzdk5_6878786_lrg;
                }
                else if (rInt == 2)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.maxresdefault;
                }
                else if (rInt == 3)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.minecraft_shaders_sunset172_sonic_ethers_unbelievable_shaders_and_glsl_shaders_mod_neojp64v;
                }
                else if (rInt == 4)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Lh1uC;
                }
                else if (rInt == 5)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources._635527313118483321;
                }
                else if (rInt == 6)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources._35ScreenN;
                }
                else if (rInt == 7)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Poster2;
                }
                else if (rInt == 8)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.Screen13;
                }
                else if (rInt == 9)
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.screen66;
                }

            }
            else
            {
                if (photosAmount != 0)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, photosAmount);
                    string path = resourcesB + @"\" + rInt.ToString() + ".png";
                    try
                    {
                        GDTPanel.BackgroundImage = Image.FromFile(path);
                    }
                    catch
                    {
                        GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.BackGround;
                    }
                }
                else
                {
                    GDTPanel.BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.BackGround;
                }
            }
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
                gdtModName.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
                modifications.Show();
                modsLabel.Show();
                settingsButton.Show();
            }
            else
            {
                GDTPanel.Hide();
                modifications.Hide();
                topicPanel.Hide();
                gdtCustomCodeBox.Hide();
                ccBack.Hide();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                addModButton.Hide();
                modsLabel.Hide();
                settingsButton.Hide();

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
                ccBack.Show();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                addModButton.Hide();
                addModPanel.Hide();
                addModButton.Enabled = true;
                saveButton.Enabled = true;
                modificationsButton.Enabled = true;
                customCodeButton.Enabled = true;
                backGDT.Enabled = true;
                modsLabel.Hide();
                settingsButton.Hide();
            }
            else
            {
                topicPanel.Hide();
                ccBack.Hide();
                gdtModName.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                settingsButton.Show();
                modifications.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
                modsLabel.Show();
            }
        }

        //Creates the Variales for topic
        string ID = "";

        string actionV = "0.9";
        string adventureV = "0.9";
        string rpgV = "0.9";
        string simulationV = "0.9";
        string strategyV = "0.9";
        string casualV = "0.9";

        string youngV = "0.9";
        string everyoneV = "0.9";
        string matureV = "0.9";

        string topicNameString = "Random Topic";

        // Handles Topic Making

        private void actionValueSet(object sender, EventArgs e)
        {
            // Checks to see what the action bar value equals then converts it for GDT modding
            if (actionBar.Value == 1)
            {
                actionV = "0.6";
            }
            else if (actionBar.Value == 2)
            {
                actionV = "0.9";
            }
            else
            {
                actionV = "1.0";
            }
        }

        private void adventureValueSet(object sender, EventArgs e)
        {
            // Checks to see what the adventure bar value equals then converts it for GDT modding
            if (adventureBar.Value == 1)
            {
                adventureV = "0.6";
            }
            else if (adventureBar.Value == 2)
            {
                adventureV = "0.9";
            }
            else
            {
                adventureV = "1.0";
            }
        }

        private void rpgValueSet(object sender, EventArgs e)
        {
            // Checks to see what the rpg bar value equals then converts it for GDT modding
            if (RPGBar.Value == 1)
            {
                rpgV = "0.6";
            }
            else if (RPGBar.Value == 2)
            {
                rpgV = "0.9";
            }
            else
            {
                rpgV = "1.0";
            }
        }

        private void simulationValueSet(object sender, EventArgs e)
        {

            // Checks to see what the simulation bar value equals then converts it for GDT modding
            if (simulationBar.Value == 1)
            {
                simulationV = "0.6";
            }
            else if (simulationBar.Value == 2)
            {
                simulationV = "0.9";
            }
            else
            {
                simulationV = "1.0";
            }
        }

        private void strategyValueSet(object sender, EventArgs e)
        {
            // Checks to see what the stratgey bar value equals then converts it for GDT modding
            if (strategyBar.Value == 1)
            {
                strategyV = "0.6";
            }
            else if (strategyBar.Value == 2)
            {
                strategyV = "0.9";
            }
            else
            {
                strategyV = "1.0";
            }
        }

        private void casualValueSet(object sender, EventArgs e)
        {
            // Checks to see what the casual bar value equals then converts it for GDT modding
            if (casualBar.Value == 1)
            {
                casualV = "0.6";
            }
            else if (casualBar.Value == 2)
            {
                casualV = "0.9";
            }
            else
            {
                casualV = "1.0";
            }
        }

        private void youngValueSet(object sender, EventArgs e)
        {
            if (young.Text == "Bad")
            {
                youngV = "0.6";
            }
            else if (young.Text == "Good")
            {
                youngV = "0.9";
            }
            else
            {
                youngV = "1.0";
            }
        }

        private void everyoneValueSet(object sender, EventArgs e)
        {
            if (everyone.Text == "Bad")
            {
                everyoneV = "0.6";
            }
            else if (everyone.Text == "Good")
            {
                everyoneV = "0.9";
            }
            else
            {
                everyoneV = "1.0";
            }
        }

        private void matureValueSet(object sender, EventArgs e)
        {
            if (mature.Text == "Bad")
            {
                matureV = "0.6";
            }
            else if (mature.Text == "Good")
            {
                matureV = "0.9";
            }
            else
            {
                matureV = "1.0";
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
            Random rnd = new Random();
            ModificationsCustomCode = true;
            string randomID = "";
            if (modifyingTopic == true)
            {
                randomID = ID;
            }
            else
            {
                int random = rnd.Next(1, 10000);
                int random2 = rnd.Next(1, 10000);
                int random3 = rnd.Next(1, 10000);
                int random4 = rnd.Next(1, 10000);
                int random5 = rnd.Next(1, 10000);
                randomID = random.ToString() + "-" + random2.ToString() + "-" + random3.ToString() + "-" + random4.ToString() + "-" + random5.ToString();
            }
                topics = topics + "\n		//" + topicNameString + "		\n		{\n" + "			" + "id: \"" + randomID + "\",//ID\n" + "			" + "name: \"" + topicNameString + "\".localize(\"game topic\"),//Name\n" + "			" + "genreWeightings: [" + actionV + ", " + adventureV + ", " + rpgV + ", " + simulationV + ", " + strategyV + ", " + casualV + "],//Genre\n" + "			" + "audienceWeightings: [" + youngV + ", " + everyoneV + ", " + matureV + "]//Audience\n" + "		}, //Ending" + topicNameString + " \n";
                string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
                mods = fullMod;
                gdtCustomCodeBox.Text = mods;
                TreeNode newMod = new TreeNode(topicNameString);

            //Old Code

            //modifications.Nodes[0].Nodes.Add(newMod);

            //New Code
            var btn = new Button() { Name = topicNameString, BackColor = TransparencyKey, Text = "", BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.topic, BackgroundImageLayout = ImageLayout.Zoom, FlatStyle = FlatStyle.Flat, Height = 75, Width = 75, ForeColor = Color.White };
            btn.Click += new EventHandler(topicClicked);
            var label = new Label() { Name = topicNameString + "Label", Text = topicNameString, AutoSize = true, ForeColor = Color.White, Image = Ultimate_Mod_Maker.Properties.Resources.backOfText};
            var box = new TableLayoutPanel() { Name = topicNameString + "Box", AutoSize = true, ColumnCount = 1, RowCount = 2 };
            box.Controls.Add(label, 0, 1);
            box.Controls.Add(btn, 0, 2);
            modifications.Controls.Add(box);
            //Rest
            modificationsCreated = modificationsCreated + "\n" + topicNameString;
                ModificationsCustomCode = false;
                topicPanel.Hide();
                topicPart2.Hide();
                topicPanelPart3.Hide();
                gdtModName.Show();
                modifications.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
                modsLabel.Show();
            settingsButton.Show();

            topicName.Text = "Random Topic";

            actionBar.Value = 2;
            adventureBar.Value = 2;
            RPGBar.Value = 2;
            simulationBar.Value = 2;
            strategyBar.Value = 2;
            casualBar.Value = 2;
            young.Text = "Good";
            everyone.Text = "Good";
            mature.Text = "Good";

        }

        //Handles the GDT mod naming proccess

        string gdtModNameString = "Ultimate_Mod_Maker_Mod";
        private void changeGDTModName(object sender, EventArgs e)
        {
            ModificationsCustomCode = true;
            /*gdtModNameString = gdtModNameBox.Text;
            gdtModName.Text = gdtModNameString;
            string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
            mods = fullMod;
            gdtCustomCodeBox.Text = mods;*/

            gdtModNameString = gdtModNameBox.Text;
            string newName = gdtModNameBox.Text;
            topics = topics.Replace(gdtModName.Text, newName);
            string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
            mods = fullMod;
            gdtCustomCodeBox.Text = mods;
            gdtModName.Text = newName;
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
            /*if (modifications.Visible.Equals(false))
            {
                modifications.Show();
                topicPanel.Hide();
                gdtCustomCodeBox.Hide();
                info.Hide();
                dMod.Show();
                ccBack.Show();
                warningMod.Show();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                addModButton.Hide();
            }
            else
            {
                modifications.Hide();
                dMod.Hide();
                ccBack.Hide();
                warningMod.Hide();
                gdtModName.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
            }*/
        }
        bool ModificationsCustomCode = false;


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
                ccBack.Show();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                settingsButton.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                addModButton.Hide();
                modsLabel.Hide();
            }
            else
            {
                gdtCustomCodeBox.Hide();
                ccBack.Hide();
                gdtModName.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                settingsButton.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
                modifications.Show();
                modsLabel.Show();
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
                ccBack.Show();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                modsLabel.Hide();
                addModButton.Hide();
                settingsButton.Hide();
            }
            else
            {
                info.Hide();
                gdtModName.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                backGDT.Show();
                saveButton.Show();
                loadButton.Show();
                modificationsButton.Show();
                settingsButton.Show();
                customCodeButton.Show();
                modifications.Show();
                modsLabel.Show();
                addModButton.Show();
            }
        }

        private void finishedInfo(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 10000);
            int random2 = rnd.Next(1, 10000);
            int random3 = rnd.Next(1, 10000);
            int random4 = rnd.Next(1, 10000);
            int random5 = rnd.Next(1, 10000);
            string randomID = random.ToString() + "-" + random2.ToString() + "-" + random3.ToString() + "-" + random4.ToString() + "-" + random5.ToString();
            infoString = "{ \r\n 	\"id\" : \"" + randomID + "\", \r\n	\"name\" : \"" + gdtModNameString + "\", \r\n	\"version\":\"" + version.Text + "\", \r\n	\"author\":\"" + author.Text + "\", \r\n	\"url\":\"" + url.Text + "\", \r\n	\"description\" : \"" + description.Text + "\", \r\n	\"main\" : \"./properties.js\", \r\n	\"dependencies\" : {\"gdt-modAPI\":\"0.1.x\"} \r\n}";
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

            topicName.Text = "Random Topic";

            actionBar.Value = 2;
            adventureBar.Value = 2;
            RPGBar.Value = 2;
            simulationBar.Value = 2;
            strategyBar.Value = 2;
            casualBar.Value = 2;
            young.Text = "Good";
            everyone.Text = "Good";
            mature.Text = "Good";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void nextClicked1(object sender, EventArgs e)
        {
            if (!modificationsCreated.Contains(topicNameString))
            {
                topicPanel.Hide();
                topicPart2.Show();
            }
            else
            {
                MessageBox.Show("Topic with that name already created!");
            }
        }

        private void nextClicked2(object sender, EventArgs e)
        {
            topicPanel.Hide();
            topicPart2.Hide();
            topicPanelPart3.Show();
        }

        private void cancelTopic(object sender, EventArgs e)
        {
            if (modifyingTopic == true)
            {
                Random rnd = new Random();
                ModificationsCustomCode = true;
                string randomID = "";
                topics = topics + "\n		//" + topicNameString + "		\n		{\n" + "			" + "id: \"" + randomID + "\",//ID\n" + "			" + "name: \"" + topicNameString + "\".localize(\"game topic\"),//Name\n" + "			" + "genreWeightings: [" + actionV + ", " + adventureV + ", " + rpgV + ", " + simulationV + ", " + strategyV + ", " + casualV + "],//Genre\n" + "			" + "audienceWeightings: [" + youngV + ", " + everyoneV + ", " + matureV + "]//Audience\n" + "		}, //Ending" + topicNameString + " \n";
                string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + topics + "\n      ]);" + "\n	};" + "\n})();";
                mods = fullMod;
                gdtCustomCodeBox.Text = mods;
                TreeNode newMod = new TreeNode(topicNameString);

                //Old Code

                //modifications.Nodes[0].Nodes.Add(newMod);

                //New Code
                var btn = new Button() { Name = topicNameString, BackColor = TransparencyKey, Text = "", BackgroundImage = Ultimate_Mod_Maker.Properties.Resources.topic, BackgroundImageLayout = ImageLayout.Zoom, FlatStyle = FlatStyle.Flat, Height = 75, Width = 75, ForeColor = Color.White };
                btn.Click += new EventHandler(topicClicked);
                var label = new Label() { Name = topicNameString + "Label", Text = topicNameString, AutoSize = true, ForeColor = Color.White, Image = Ultimate_Mod_Maker.Properties.Resources.backOfText };
                var box = new TableLayoutPanel() { Name = topicNameString + "Box", AutoSize = true, ColumnCount = 1, RowCount = 2 };
                box.Controls.Add(label, 0, 1);
                box.Controls.Add(btn, 0, 2);
                modifications.Controls.Add(box);
                //Rest
                modificationsCreated = modificationsCreated + "\n" + topicNameString;
                ModificationsCustomCode = false;
                modifyingTopic = false;
            }
            topicPanel.Hide();
            topicPart2.Hide();
            ccBack.Hide();
            topicPanelPart3.Hide();
            info.Hide();
            topicPanel.Hide();
            gdtCustomCodeBox.Hide();
            gdtModName.Show();
            settingsButton.Show();
            gdtModNameBox.Show();
            modifications.Show();
            modNameLabel.Show();
            backGDT.Show();
            saveButton.Show();
            loadButton.Show();
            modsLabel.Show();
            modificationsButton.Show();
            customCodeButton.Show();
            addModButton.Show();

                        topicName.Text = "Random Topic";

            actionBar.Value = 2;
            adventureBar.Value = 2;
            RPGBar.Value = 2;
            simulationBar.Value = 2;
            strategyBar.Value = 2;
            casualBar.Value = 2;
            young.Text = "Good";
            everyone.Text = "Good";
            mature.Text = "Good";
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

        private void customCodeChanged(object sender, KeyEventArgs e)
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

        private void addPlatformClicked(object sender, EventArgs e)
        {
            if(addPlatform.Visible.Equals(false))
            {
                addPlatform.Show();
                info.Hide();
                modifications.Hide();
                topicPanel.Hide();
                gdtCustomCodeBox.Hide();
                ccBack.Hide();
                gdtModName.Hide();
                gdtModNameBox.Hide();
                modNameLabel.Hide();
                backGDT.Hide();
                saveButton.Hide();
                loadButton.Hide();
                modificationsButton.Hide();
                customCodeButton.Hide();
                addModButton.Hide();
                modsLabel.Hide();
                settingsButton.Hide();
            } else
            {
                addPlatform.Hide();
                gdtModName.Show();
                modifications.Show();
                gdtModNameBox.Show();
                modNameLabel.Show();
                modsLabel.Show();
                backGDT.Show();
                settingsButton.Show();
                saveButton.Show();
                loadButton.Show();
                modificationsButton.Show();
                customCodeButton.Show();
                addModButton.Show();
            }
        }

        private void addImagePathClicked(object sender, EventArgs e)
        {
            OpenFileDialog gdtGetImagePath = new OpenFileDialog();
            gdtGetImagePath.Title = "Select a file to use for an icon.";
            if (gdtGetImagePath.ShowDialog() == DialogResult.OK)
            {
                string imageSource = gdtGetImagePath.FileName;
                imagePathLabel.Text = imageSource;
            }
        }

        private void finishPlatformClicked(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addMod(object sender, EventArgs e)
        {
            addModPanel.Show();
            modifications.Hide();
            addModButton.Enabled = false;
            saveButton.Enabled = false;
            modificationsButton.Enabled = false;
            customCodeButton.Enabled = false;
            backGDT.Enabled = false;
        }

        private void cancelAddMod(object sender, EventArgs e)
        {
            addModPanel.Hide();
            modifications.Show();
            addModButton.Enabled = true;
            saveButton.Enabled = true;
            modificationsButton.Enabled = true;
            customCodeButton.Enabled = true;
            backGDT.Enabled = true;
        }

        string topicLastClickedName = "";

        private void modifyTopic(object sender, EventArgs e)
        {
            //Turns on topic editing mode

            modifyingTopic = true;

            string cc = gdtCustomCodeBox.Text;
            string modification = topicLastClickedName;

            int m1 = cc.IndexOf("GDT.addTopics([") + "GDT.addTopics([".Length;
            int m2 = cc.IndexOf("]);");
            string allMods = cc.Substring(m1, m2 - m1);

            int v1 = allMods.IndexOf("//" + modification);
            int v2 = allMods.IndexOf("//Ending" + modification) + ("//Ending" + modification).Length;
            string mod = allMods.Substring(v1, v2 - v1);

            int id1 = mod.IndexOf("id: \"") + ("id: \"").Length;
            int id2 = mod.IndexOf("\",//ID");

            ID = mod.Substring(id1, id2 - id1);

            int name1 = mod.IndexOf("name: \"") + ("name: \"").Length;
            int name2 = mod.IndexOf("\".localize(\"game topic\"),");

            string Name = mod.Substring(name1, name2 - name1);

            int genre1 = mod.IndexOf("genreWeightings: [") + ("genreWeightings: [").Length;
            int genre2 = mod.IndexOf("],//Genre");

            string genre = mod.Substring(genre1, genre2 - genre1);

            int audience1 = mod.IndexOf("audienceWeightings: [") + ("audienceWeightings: [").Length;
            int audience2 = mod.IndexOf("]//Audience");

            string audience = mod.Substring(audience1, audience2 - audience1);
            string action = genre.Substring(0, 3);
            string adventure = genre.Substring(5, 3);
            string rpg = genre.Substring(10, 3);
            string simulation = genre.Substring(15, 3);
            string strategy = genre.Substring(20, 3);
            string casual = genre.Substring(25, 3);
            string youngSet = audience.Substring(0, 3);
            string everyoneSet = audience.Substring(5, 3);
            string matureSet = audience.Substring(10, 3);

            int actionCon = 1;
            if (action == "0.6")
            {
                actionCon = 1;
            } else if (action == "0.9")
            {
                actionCon = 2;
            } else if (action == "1.0")
            {
                actionCon = 3;
            }
            int adventureCon = 1;
            if (adventure == "0.6")
            {
                adventureCon = 1;
            }
            else if (adventure == "0.9")
            {
                adventureCon = 2;
            }
            else if (adventure == "1.0")
            {
                adventureCon = 3;
            }
            int rpgCon = 1;
            if (rpg == "0.6")
            {
                rpgCon = 1;
            }
            else if (rpg == "0.9")
            {
                rpgCon = 2;
            }
            else if (rpg == "1.0")
            {
                rpgCon = 3;
            }
            int simulationCon = 1;
            if (simulation == "0.6")
            {
                simulationCon = 1;
            }
            else if (simulation == "0.9")
            {
                simulationCon = 2;
            }
            else if (simulation == "1.0")
            {
                simulationCon = 3;
            }
            int strategyCon = 1;
            if (strategy == "0.6")
            {
                strategyCon = 1;
            }
            else if (strategy == "0.9")
            {
                strategyCon = 2;
            }
            else if (strategy == "1.0")
            {
                strategyCon = 3;
            }
            int casualCon = 1;
            if (casual == "0.6")
            {
                casualCon = 1;
            }
            else if (casual == "0.9")
            {
                casualCon = 2;
            }
            else if (casual == "1.0")
            {
                casualCon = 3;
            }
            string youngCon = "Bad";
            if (youngSet == "0.6")
            {
                youngCon = "Bad";
            }
            else if (youngSet == "0.9")
            {
                youngCon = "Good";
            }
            else if (youngSet == "1.0")
            {
                youngCon = "Amazing";
            }
            string everyoneCon = "Bad";
            if (everyoneSet == "0.6")
            {
                everyoneCon = "Bad";
            }
            else if (everyoneSet == "0.9")
            {
                everyoneCon = "Good";
            }
            else if (everyoneSet == "1.0")
            {
                everyoneCon = "Amazing";
            }
            string matureCon = "Bad";
            if (matureSet == "0.6")
            {
                matureCon = "Bad";
            }
            else if (matureSet == "0.9")
            {
                matureCon = "Good";
            }
            else if (matureSet == "1.0")
            {
                matureCon = "Amazing";
            }

            //Delets Topic Completely
            ModificationsCustomCode = true;

            //Deletes Button and Label

            modifications.Controls.RemoveByKey(topicLastClickedName + "Box");

            //Deletes Name

            modificationsCreated = modificationsCreated.Replace(modification, string.Empty);

            //Deletes Code

            allMods = allMods.Replace(mod, string.Empty);
            topics = allMods;
            string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + allMods + "\n      ]);" + "\n	};" + "\n})();";
            mods = fullMod;
            gdtCustomCodeBox.Text = mods;

            //Old Delete Code for TextBox

            /*gdtCustomCodeBox.Select = v1;
            gdtCustomCodeBox.SelectionLength = v2 - v1;
            gdtCustomCodeBox.Cut();
            ModificationsCustomCode = false;*/

            //Sets values

            topicName.Text = Name;

            actionBar.Value = actionCon;
            adventureBar.Value = adventureCon;
            RPGBar.Value = rpgCon;
            simulationBar.Value = simulationCon;
            strategyBar.Value = strategyCon;
            casualBar.Value = casualCon;
            young.Text = youngCon;
            everyone.Text = everyoneCon;
            mature.Text = matureCon;

            //Shows Topc Panel

            topicPanel.Show();
            modifications.Hide();
            gdtCustomCodeBox.Hide();
            info.Hide();
            ccBack.Show();
            gdtModName.Hide();
            gdtModNameBox.Hide();
            modNameLabel.Hide();
            backGDT.Hide();
            saveButton.Hide();
            loadButton.Hide();
            modificationsButton.Hide();
            customCodeButton.Hide();
            addModButton.Hide();
            settingsButton.Hide();
            addModPanel.Hide();
            addModButton.Enabled = true;
            saveButton.Enabled = true;
            modificationsButton.Enabled = true;
            customCodeButton.Enabled = true;
            backGDT.Enabled = true;
            modsLabel.Hide();
        }
        private void deleteTopic(object sender, EventArgs e)
        {
            
            ModificationsCustomCode = true;

            string cc = gdtCustomCodeBox.Text;
            string modification = topicLastClickedName;

            int m1 = cc.IndexOf("GDT.addTopics([") + "GDT.addTopics([".Length;
            int m2 = cc.IndexOf("]);");
            string allMods = cc.Substring(m1, m2 - m1);

            //Deletes Button and Label

            modifications.Controls.RemoveByKey(topicLastClickedName + "Box");

            //Deletes Name

            modificationsCreated = modificationsCreated.Replace(modification, string.Empty);

            //Deletes Code

            int v1 = allMods.IndexOf("//" + modification);
            int v2 = allMods.IndexOf("//Ending" + modification) + ("//Ending" + modification).Length;
            string mod = allMods.Substring(v1, v2 - v1);

            //Old Delete Code for TextBox

            /*gdtCustomCodeBox.Select = v1;
            gdtCustomCodeBox.SelectionLength = v2 - v1;
            gdtCustomCodeBox.Cut();
            ModificationsCustomCode = false;*/

            //New Delet Code for CodingTextBox

            allMods = allMods.Replace(mod, string.Empty);
            topics = allMods;
            string fullMod = "var " + gdtModNameString + " = {};\n(function (){\n" + "	" + gdtModNameString + ".addTopic = function () {\n" + "		GDT.addTopics([ \n" + allMods + "\n      ]);" + "\n	};" + "\n})();";
            mods = fullMod;
            gdtCustomCodeBox.Text = mods;
            ModificationsCustomCode = false;
        }

        private void topicClicked(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Point ptLowerLeft = new Point(0, control.Height);
            ptLowerLeft = control.PointToScreen(ptLowerLeft);
            modsRightClicked.Show(ptLowerLeft);
            topicLastClickedName = control.Name;
        }

        private void settingsClicked(object sender, EventArgs e)
        {
            if (settingsPanel.Visible == false)
            {
                settingsPanel.Show();
            } else
            {
                settingsPanel.Hide();
            }
        }

        private void addImageChecked(object sender, EventArgs e)
        {
            if (useCustomImages.Checked == true)
            {
                addBckgImage.Enabled = true;
                customBackgroundEnabled = true;
                string NewSettings = "CustomImages=true,";
                File.WriteAllText(settings, NewSettings);

            }
            else
            {
                addBckgImage.Enabled = false;
                customBackgroundEnabled = false;
                string NewSettings = "CustomImages=false,";
                File.WriteAllText(settings, NewSettings);
            }
        }

        private void addImageButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog gdtGetImagePath = new OpenFileDialog();
            gdtGetImagePath.Title = "Select a Image to Add";
            gdtGetImagePath.Filter = "png |*.png";
            if (gdtGetImagePath.ShowDialog() == DialogResult.OK)
            {
                string path = gdtGetImagePath.FileName;
                string newPath = resourcesB + @"\" + (photosAmount + 1).ToString() + ".png";
                System.IO.File.Copy(path, newPath);
                photosAmount = photosAmount + 1;
                backgoundImages.Controls.Add(new Button { Name = photosAmount.ToString() ,Text = "", BackColor = TransparencyKey,Image = Image.FromFile(Path.Combine(resourcesB + @"\" + photosAmount + ".png")), Width = 50, Height = 50 });
            }
        }

        string imageNumber = "";
        private void customImageClicked(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Point ptLowerLeft = new Point(0, control.Height);
            ptLowerLeft = control.PointToScreen(ptLowerLeft);
            imageClicked.Show(ptLowerLeft);
            imageNumber = control.Name;
        }

        private void deleteImageClicked(Object sender, EventArgs e)
        {
            //backgoundImages.Controls.RemoveByKey(imageNumber);
            //File.Delete();
        }

        private void imageClicked_Opening(object sender, CancelEventArgs e)
        {

        }

        private void changeGDTModName(object sender, KeyEventArgs e)
        {

        }
    }

}