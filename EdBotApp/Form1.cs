using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace EdBotApp
{
    public partial class Form1 : Form
    {
        public string webServer;
        public Form1()
        {
            InitializeComponent();
            string promptValue = Prompt.ShowDialog("Web Server", "Please enter your EdBot Server Address");
            webServer = promptValue;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(webServer);
            string messageContent = txtChannel.Text + ":" + txtEntry.Text;
            // Console.WriteLine(messageContent);
            try
            {
                var responseString = webServer
                .PostStringAsync(messageContent).ReceiveString();
                lblMain.Text = "Message to EdBot Server successful: " + responseString.Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " You probably have an invalid web server address.  Restart EdBot.exe and try again");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public static class Prompt
    {
        //Ripped STRAIGHT from StackOverflow
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
