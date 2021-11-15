using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private UsbCamera camera = new UsbCamera();
        private List<String> devices = null;
        bool movementTest = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void detect_devices_Click(object sender, EventArgs e)
        {
            devicesComboBox.Items.Clear();
            devices = camera.lookForDevices();
            foreach (string device in devices)
            {

                devicesComboBox.Items.Add(device);

            }
            devicesComboBox.SelectedIndex = 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Wyświetl obraz")
            {
                Start.Text = "Zatrzymaj wyświetlanie";
                int selectedDeviceIndex = devicesComboBox.SelectedIndex;
                camera.connect(selectedDeviceIndex, cameraWindow);

            }
            else
            {
                Start.Text = "Wyświetl obraz";
                int selectedDeviceIndex = devicesComboBox.SelectedIndex;
                camera.disconnect(selectedDeviceIndex);
            }
        }

        private void settingsDialog_Click(object sender, EventArgs e)
        {
            camera.openSettingsDialog();
        }

        private void resolutionDialog_Click(object sender, EventArgs e)
        {
            camera.openSetResolutionDialog();
        }

        private void cameraShot_Click(object sender, EventArgs e)
        {
            Image shot = camera.cameraShot();


            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                shot.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
            }
        }


        private void zoomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (zoomBox.Checked)
            {
                camera.zoom(1);
            }
            else
            {
                camera.zoom(0);
            }
        }

        private void startRecording_Click(object sender, EventArgs e)
        {
            camera.startRecording();
        }

        private void endRecording_Click(object sender, EventArgs e)
        {
            camera.stopRecording();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movementDetector.Text="Brak ruchu";
            movementTest = true;
            Image frame1 = camera.cameraShot();
            while (movementTest)
            {
                frame1=camera.testMovement(movementDetector,frame1);
            }
            movementDetector.Text = "...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movementTest = false;
        }
    }
}
