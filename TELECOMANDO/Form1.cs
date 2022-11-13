namespace TELECOMANDO
{
    public partial class Form1 : Form
    {
        public static Television tv = new Television("dsdsads", "sddsa", 100);
        public tele t = new tele("aads","adssad","asaadsd",tv);
        public int number, nCanale,per=10;
        public Form1()
        {
            InitializeComponent();
        }

        private void pulsante1_Click(object sender, EventArgs e)
        {
            number = 1;
            if(per==1)
               nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per)+number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante2_Click(object sender, EventArgs e)
        {
            number = 2;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante3_Click(object sender, EventArgs e)
        {
            number = 3;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante4_Click(object sender, EventArgs e)
        {
            number = 4;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante5_Click(object sender, EventArgs e)
        {
            number = 5;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = 6;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante7_Click(object sender, EventArgs e)
        {
            number = 7;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante8_Click(object sender, EventArgs e)
        {
            number = 8;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante9_Click(object sender, EventArgs e)
        {
            number = 9;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsante0_Click(object sender, EventArgs e)
        {
            number = 0;
            if (per == 1)
                nCanale = number * 1;
            else
            {
                nCanale = (nCanale * per) + number;
            }
            channelLAbel.Text = nCanale.ToString();
            if (channelLAbel.Text.Length > 3)
            {
                channelLAbel.Text = 0.ToString();
                nCanale = 0;
            }
        }

        private void pulsantePiu_Click(object sender, EventArgs e)
        {
            int vol;
            t.alzaVolume();
            vol = t.getVolume();
            labelVolume.Text = vol.ToString();
        }

        private void pulsanteMeno_Click(object sender, EventArgs e)
        {
            int vol;
            t.abbassaVolume();
            vol = t.getVolume();
            labelVolume.Text = vol.ToString();
        }
    }
}