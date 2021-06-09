using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace WinCommandActions
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine speechRecognizer;

        private readonly Dictionary<Grammar, CommandAction> actions = new Dictionary<Grammar, CommandAction>();

        private AppSettings settings = new AppSettings();

        private GandalfForm gandalfForm;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            settings = AppSettings.Load() ?? settings;
            foreach (var commandAction in settings.Actions)
            {
                actionListBox.Items.Add(commandAction);
            }
            LaunchGandalf();
        }

        private void addActionButton_Click(object sender, EventArgs e)
        {
            var commandAction = new CommandAction();
            settings.Actions.Add(commandAction);
            actionListBox.Items.Add(commandAction);
            settings.Save();
        }

        private void removeActionButton_Click(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex < 0)
                return;
            settings.Actions.RemoveAt(actionListBox.SelectedIndex);
            actionListBox.Items.RemoveAt(actionListBox.SelectedIndex);
            settings.Save();
        }

        private void actionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex < 0)
            {
                actionEditPanel.Visible = false;
                return;
            }

            actionEditPanel.Visible = true;

            var item = (CommandAction) actionListBox.SelectedItem;
            titleTextBox.Text = item.Title;
            commandTextBox.Text = item.Command;
            fileNameLabel.Text = item.Filename;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex < 0)
                return;
            var item = (CommandAction) actionListBox.SelectedItem;
             item.Title = titleTextBox.Text;
             actionListBox.Items[actionListBox.SelectedIndex] = item;
             settings.Save();
        }

        private void commandTextBox_TextChanged(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex < 0)
                return;
            var item = (CommandAction) actionListBox.SelectedItem;
            item.Command = commandTextBox.Text;
            settings.Save();
        }

        private void fileNameLabel_TextChanged(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex < 0)
                return;
            var item = (CommandAction) actionListBox.SelectedItem;
            item.Filename = fileNameLabel.Text;
            settings.Save();
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameLabel.Text = browseFileDialog.FileName;
            }
        }

        private void OnCommandRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            var action = actions[e.Result.Grammar];

            var process = new Process();
            var info = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = action.Filename,
            };
            process.StartInfo = info;
            process.Start();
        }

        private void OnGandalfSummon(object sender, SpeechRecognizedEventArgs e)
        {
            var gandalf = (SpeechRecognitionEngine) sender;
            gandalf.Dispose();

            gandalfForm = new GandalfForm();
            gandalfForm.Show();
            gandalfForm.Closed += (_, __) =>
            {
                LaunchGandalf();
                gandalfForm.Dispose();
                speechRecognizer.Dispose();
            };

            LaunchRecognition();
        }

        private void LaunchGandalf()
        {
            var gandalf = new SpeechRecognitionEngine(new CultureInfo("en-US"));
            gandalf.SpeechRecognized += OnGandalfSummon;
            gandalf.SetInputToDefaultAudioDevice();
            gandalf.UnloadAllGrammars();
            
            var gb = new GrammarBuilder("hey gandalf") {Culture = new CultureInfo("en-US")};
            var gr=new Grammar(gb);
            gandalf.LoadGrammar(gr);
            gandalf.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void LaunchRecognition()
        {   
            speechRecognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
            speechRecognizer.SpeechRecognized += OnCommandRecognized;
            speechRecognizer.RecognizeCompleted += (_, __) => gandalfForm.Close();
            speechRecognizer.SetInputToDefaultAudioDevice();
            speechRecognizer.UnloadAllGrammars();
            actions.Clear();
            
            foreach (var obj in actionListBox.Items)
            {
                var commandAction = (CommandAction) obj;
                var gb = new GrammarBuilder(commandAction.Command) {Culture = new CultureInfo("en-US")};
                var gr=new Grammar(gb);
                speechRecognizer.LoadGrammar(gr);
                actions[gr] = commandAction.Copy();
            }
            if (actionListBox.Items.Count > 0)
                speechRecognizer.RecognizeAsync(RecognizeMode.Single);
            else
                gandalfForm.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = !Visible;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
