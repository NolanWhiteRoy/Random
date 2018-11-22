using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

Random randGen = new Random();
        int randomNumberHolder1;
        int randomNumberHolder2;
        int randomNumberHolder3;
        int randomNumberHolder4;
        int randomNumberHolder5;
        int randomNumberHolder6;

        int Number1;
        int Number2;
        int Number3;
        int Number4;
        int Number5;
        int Number6;
        
        private void button1_Click(object sender, EventArgs e)
        {
            randomNumberHolder1 = randGen.Next(0, 50);
            randomNumberHolder2 = randGen.Next(0, 50);
            randomNumberHolder3 = randGen.Next(0, 50);
            randomNumberHolder4 = randGen.Next(0, 50);
            randomNumberHolder5 = randGen.Next(0, 50);
            randomNumberHolder6 = randGen.Next(0, 50);

            while (randomNumberHolder2 == randomNumberHolder1)
            {
                randomNumberHolder2 = randGen.Next(0, 50);
            }
            while ((randomNumberHolder3 == randomNumberHolder1) || (randomNumberHolder3 == randomNumberHolder2))
            {
                randomNumberHolder3 = randGen.Next(0, 50);
            }
            while ((randomNumberHolder4 == randomNumberHolder1) || (randomNumberHolder4 == randomNumberHolder2) || (randomNumberHolder4 == randomNumberHolder3))
            {
                randomNumberHolder4 = randGen.Next(0, 50);
            }
            while ((randomNumberHolder5 == randomNumberHolder1) || (randomNumberHolder5 == randomNumberHolder2) || (randomNumberHolder5 == randomNumberHolder3) || (randomNumberHolder5 == randomNumberHolder4))
            {
                randomNumberHolder5 = randGen.Next(0, 50);
            }
            while ((randomNumberHolder6 == randomNumberHolder1) || (randomNumberHolder6 == randomNumberHolder2) || (randomNumberHolder6 == randomNumberHolder3) || (randomNumberHolder6 == randomNumberHolder4) || (randomNumberHolder6 == randomNumberHolder5))
            {
                randomNumberHolder6 = randGen.Next(0, 50);
            }

            Number1 = randomNumberHolder1;

            if (randomNumberHolder1 < randomNumberHolder2)
            {
                Number1 = randomNumberHolder2;
                Number2 = randomNumberHolder1;
            }
            else
            {
                Number2 = randomNumberHolder2;
            }

            if (randomNumberHolder3 > Number1)
            {
                Number3 = Number2;
                Number2 = Number1;
                Number1 = randomNumberHolder3;
            }
            else if (randomNumberHolder3 > Number2)
            {
                Number3 = Number2;
                Number2 = randomNumberHolder3;
            }
            else
            {
                Number3 = randomNumberHolder3;
            }


            if (randomNumberHolder4 > Number1)
            {
                Number4 = Number3;
                Number3 = Number2;
                Number2 = Number1;
                Number1 = randomNumberHolder4;
            }
            else if (randomNumberHolder4 > Number2)
            {
                Number4 = Number3;
                Number3 = Number2;
                Number2 = randomNumberHolder4;
            }
            else if (randomNumberHolder4 > Number3)
            {
                Number4 = Number3;
                Number3 = randomNumberHolder4;
            }
            else
            {
                Number4 = randomNumberHolder4;
            }


            if (randomNumberHolder5 > Number1)
            {
                Number5 = Number4;
                Number4 = Number3;
                Number3 = Number2;
                Number2 = Number1;
                Number1 = randomNumberHolder5;
            }
            else if (randomNumberHolder5 > Number2)
            {
                Number5 = Number4;
                Number4 = Number3;
                Number3 = Number2;
                Number2 = randomNumberHolder5;
            }
            else if (randomNumberHolder5 > Number3)
            {
                Number5 = Number4;
                Number4 = Number3;
                Number3 = randomNumberHolder5;
            }
            else if (randomNumberHolder5 > Number4)
            {
                Number5 = Number4;
                Number4 = randomNumberHolder5;
            }
            else
            {
                Number5 = randomNumberHolder5;
            }


            if (randomNumberHolder6 > Number1)
            {
                Number6 = Number5;
                Number5 = Number4;
                Number4 = Number3;
                Number3 = Number2;
                Number2 = Number1;
                Number1 = randomNumberHolder6;
            }
            else if (randomNumberHolder6 > Number2)
            {
                Number6 = Number5;
                Number5 = Number4;
                Number4 = Number3;
                Number3 = Number2;
                Number2 = randomNumberHolder6;
            }
            else if (randomNumberHolder6 > Number3)
            {
                Number6 = Number5;
                Number5 = Number4;
                Number4 = Number3;
                Number3 = randomNumberHolder6;
            }
            else if (randomNumberHolder6 > Number4)
            {
                Number6 = Number5;
                Number5 = Number4;
                Number4 = randomNumberHolder6;
            }
            else if (randomNumberHolder6 > Number5)
            {chNumber6 = Number5;
                Number5 = randomNumberHolder6;
            }
            else
            {
                Number6 = randomNumberHolder6;
            }


            label1.Text = "Your winning numbers are:" + Environment.NewLine + Number1 + " " + Number2 + " " + Number3 + " " + 
                Number4 + " " + Number5 + " " + Number6;
