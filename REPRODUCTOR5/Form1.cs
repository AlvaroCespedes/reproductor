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

namespace REPRODUCTOR5
{
    public partial class Form1 : Form
    {
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;
        bool Play = false;

        string[] subida; // atributo d ela cancion
        public Form1()
        {
            InitializeComponent();
        }
        List<Cancion> canciones = new List<Cancion>();

        Serializar obj = new Serializar();
        List<string> archivo = new List<string>();

        private void Adjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaBusquedaDeARchivos = new OpenFileDialog();
            CajaBusquedaDeARchivos.Multiselect = true; // Nos permite seleccionar varios archivos al mismo tiempo
            if (CajaBusquedaDeARchivos.ShowDialog() == DialogResult.OK) //Filtrando solo los archivos MP3
            {

                ArchivosMP3 = CajaBusquedaDeARchivos.SafeFileNames; // aqui se van almacenar todos los archivos
                rutasArchivosMP3 = CajaBusquedaDeARchivos.FileNames;

                List<string> listaAux = new List<string>();
                try
                {
                    listaAux = obj.Deserialize<List<string>>(File.Open("data.bin", FileMode.Open));


                }
                catch (System.Runtime.Serialization.SerializationException)
                {

                }
                if (listaAux.Count > 0)
                {
                    foreach (var x in listaAux)
                    {
                        archivo.Add(x);
                    }
                }

                foreach (var x in rutasArchivosMP3)
                {
                    archivo.Add(x);
                }

                foreach (var ArchivoMP3 in ArchivosMP3)//Para leer cada uno de los archivos MP3 que adjuntamos a la appp
                {
                    // NECESITO FILTRO QUE SOLO SEA MP3
                    int startIndex = ArchivoMP3.Length - 4;
                    int final = 4;
                    String substring = ArchivoMP3.Substring(startIndex, final);
                    try 
                    {
                        //VER QUE SEAN MINUSCULAS Y MAYUSCULAS
                        if(substring == ".mp3" || substring == ".mp4")
                        {
                            listBox1.Items.Add(ArchivoMP3);

                        }
                        
                    }
                    catch
                    {

                        MessageBox.Show("Solo formato .mp3 o .mp4");
                    }
                    
                    
                }
                //Vamos a agarrar el ultio elemtno que adjuntamos en nuestra app y lo vamos a reproducir
                obj.Serialize(archivo, File.Open("data.bin", FileMode.Create));
                Reproductor.URL = rutasArchivosMP3[0];
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[listBox1.SelectedIndex];
            lblCancion.Text = ArchivosMP3[listBox1.SelectedIndex];
        }

        private void listGuardadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = archivo[listGuardadas.SelectedIndex];
        
        }

        private void Boton2_Click(object sender, EventArgs e)
        {

            try
            {
                archivo = obj.Deserialize<List<string>>(File.Open("data.bin", FileMode.Open));
                foreach (var x in archivo)
                {
                    listGuardadas.Items.Add(x);
                }


            }
            catch (System.Runtime.Serialization.SerializationException)
            {

            }
            foreach (var x in archivo)
            {
                MessageBox.Show(x);
            }
        }

        private void btnAgregarInfo_Click(object sender, EventArgs e)
        {
            //panelCancion.Visible = true;
            mTrackStatus.Visible = false;
            mTrackVolumen.Visible = false;
            btnPlay2.Visible = false;
            btnStop.Visible = false;
            panel1.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelCancion.Visible = false;
            mTrackStatus.Visible = true;
            mTrackVolumen.Visible = true;
            btnPlay2.Visible = true;
            btnStop.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)//BOTON PARA AGERGAR INFO
        {
            btnContinuar.Visible = false;


            string title = "";
            string singer = "";
            string composer = "";
            string album = "";
            string gender = "";
            string publicationYear = ""; //Tiene que ser en el formato de data time
            string study = "";
            string keyWord = "";

            title = txtTitle.Text;
            singer = txtSinger.Text;
            composer = txtComposer.Text;
            album = txtAlbum.Text;
            gender = txtGender.Text;
            publicationYear = txtPublicationYear.Text;
            study = txtStudy.Text;
            keyWord = txtKeyword.Text;


            Cancion ob = new Cancion(gender, publicationYear, title, 123, 123, study, keyWord, composer, singer, album, "asd", ".mp4");

            string nueva = ArchivosMP3[listBoxAgregar.SelectedIndex]; // Cancion seleccionada para agregar informacion



        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    //btnPlay.Image = Properties.Resources.play; //Sirve para cambiar de imagen el boton
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    Play = true;
                    break;



            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            Play = false;
        }
        public void ActualizarDatosTrack()
        {
            if(Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control del tiempo maximo del mp3 actual.
                mTrackStatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mTrackStatus.Value = 0; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //Actualizar datos del track
        {
            ActualizarDatosTrack();
            mTrackStatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mTrackVolumen.Value = Reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay2.Image = Properties.Resources.play; //Sirve para cambiar de imagen el boton
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay2.Image = Properties.Resources.descarga;
                    Play = true;
                    break;



            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay2.Image = Properties.Resources.play;
            Play = false;
        }

        private void mTrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mTrackVolumen.Value;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            panelCancion.Visible = true;
            btnContinuar.Visible = false;

        }
    }
}
