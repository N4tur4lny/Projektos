using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Projekt_angielski
{
    class Window : Form
    {
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"Word", "słowo" },
            {"Car", "auto" }
        };

        public Window()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, words.Count);
            Height = 600;
            Width = 800;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Projektos";

            Button submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new Point(350, 320);
            this.Controls.Add(submitButton);

            TextBox outText = new TextBox();
            outText.Width = 200;
            outText.Height = 50;
            outText.Location = new Point(300, 200);
            this.Controls.Add(outText);

            TextBox inText = new TextBox();
            inText.Width = 200;
            inText.Height = 50;
            inText.Location = new Point(300, 300);
            this.Controls.Add(inText);

            outText.Text = words.Keys.ElementAt(randomNumber);
            string value = outText.Text;
            string corrAnswer = words[value];

            submitButton.Click += (o, i) =>
            {
                string answer = inText.Text;
                if (answer != null)
                {
                    if (answer == corrAnswer)
                    {
                        outText.Text = "Correct";
                    }

                    else if (answer != corrAnswer)
                    {
                        outText.Text = "Incorrect";
                    }
                }
            };
        }
    }
}
