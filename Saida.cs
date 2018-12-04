using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;


namespace Arca_de_Noe
{
    public partial class Saida : Form
    {

        public void PlayBackgroundSoundFile()
        {
            Audio audio = new Audio();
            audio.Play(@"C:\1.wav", AudioPlayMode.WaitToComplete);
        }

        public Saida()
        {
            InitializeComponent();
            
        }

       
    }
}
