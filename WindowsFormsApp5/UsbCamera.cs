using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;

namespace WindowsFormsApp5
{
    class UsbCamera
    {

        private const int WM_CAP_START = 1024;
        private const short WM_CAP = 0x400;
        private const int WM_CAP_DRIVER_CONNECT = 0x40a;
        private const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        private const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        private const int WM_CAP_FILE_SET_CAPTURE_FILE = WM_CAP_START + 21;
        private const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
        private const int WM_CAP_SET_SEQUENCE_SETUP = WM_CAP_START + 64;
        private const int WM_CAP_FILE_SAVEAS = WM_CAP_START + 23;
        private const int WM_CAP_PAL_SAVE = WM_CAP_START + 81;
        private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        private const int WM_CAP_EDIT_COPY = 0x41e;
        private const int WM_CAP_SET_PREVIEW = 0x432;
        private const int WM_CAP_SET_OVERLAY = 0x433;
        private const int WM_CAP_SET_PREVIEWRATE = 0x434;
        private const int WM_CAP_SET_SCALE = 0x435;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const short SWP_NOMOVE = 0x2;

        // for showing devices
        [DllImport("avicap32.dll")]
        protected static extern bool capGetDriverDescription(short wDriverIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

        // for displaying camera image
        [DllImport("avicap32.dll")]
        protected static extern int capCreateCaptureWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

        // for position changing
        [DllImport("user32")]
        protected static extern int SetWindowPosition(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        // sends messages to the window
        [DllImport("user32", EntryPoint = "SendMessageA")]
        protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

        // closes window
        [DllImport("user32")]
        protected static extern bool DestroyWindow(int hwnd);



        int windowHandler;


        public List<String> lookForDevices()
        {
            string name = String.Empty.PadRight(100);
            string version = String.Empty.PadRight(100);
            List<string> listOfDevices = new List<string>();

            for (short i = 0; capGetDriverDescription(i, ref name, 100, ref version, 100); i++)
            {
                listOfDevices.Add(name.Trim() + version.Trim());
            }
            return listOfDevices.Count == 0 ? null : listOfDevices;
        }

        public void connect(int selectedDeviceIndex, PictureBox box)
        {
            string device = selectedDeviceIndex.ToString();
            int handler = box.Handle.ToInt32();
            openSetResolutionDialog();
            windowHandler = capCreateCaptureWindow(ref device, WS_CHILD | WS_VISIBLE, 0, 0, 1600, 1200, handler, 0);

            SendMessage(windowHandler, WM_CAP_DRIVER_CONNECT, selectedDeviceIndex, 0);
            SendMessage(windowHandler, WM_CAP_SET_PREVIEWRATE, 16, 0);
            SendMessage(windowHandler, WM_CAP_SET_PREVIEW, 1, 0);
        }
        public void disconnect(int selectedDeviceIndex)
        {
            SendMessage(windowHandler, WM_CAP_DRIVER_DISCONNECT, selectedDeviceIndex, 0);
            DestroyWindow(windowHandler);
        }


        // camera settings module

        public void openSettingsDialog()
        {
            SendMessage(windowHandler, WM_CAP_DLG_VIDEOSOURCE, 0, 0);
        }

        public void openSetResolutionDialog()
        {
            SendMessage(windowHandler, WM_CAP_DLG_VIDEOFORMAT, 0, 0);
        }

        public void zoom(int ifZoom)
        {
            SendMessage(windowHandler, WM_CAP_SET_SCALE, ifZoom, 0);
        }

        public Image cameraShot()
        {
            SendMessage(windowHandler, WM_CAP_EDIT_COPY, 0, 0);
            return Clipboard.GetImage();
        }


        public void testMovement(Label movementDetector)
        {
            Bitmap frame1,frame2;
            Image temp;
            int similarity = 0;
            string img1_ref, img2_ref;
            
            SendMessage(windowHandler, WM_CAP_EDIT_COPY, 0, 0);
            temp= Clipboard.GetImage();
            frame1 = (Bitmap)temp;
            for(int i = 0; i < 1000000; i+=2)
            {
                i--;
            }

            SendMessage(windowHandler, WM_CAP_EDIT_COPY, 0, 0);
            temp = Clipboard.GetImage();
            frame2 = (Bitmap)temp;

            for (int i = 0; i < frame1.Width; i++)
            {
                for (int j = 0; j < frame1.Height; j++)
                {
                    img1_ref = frame1.GetPixel(i, j).ToString();
                    img2_ref = frame2.GetPixel(i, j).ToString();
                    if (img1_ref == img2_ref)
                    {
                        similarity++;
                    }
                }
            }

            float similarityRatio = (float)((similarity)*1.0 / (frame1.Width * frame1.Height));
            Console.WriteLine(similarityRatio);

            if (similarityRatio < 0.90)
            {
                movementDetector.Text.Insert(0, "Wykryto ruch                          ");
            }
            else
            {
                movementDetector.Text.Insert(0, "Brak ruchu                            ");
            }
        }



        public void startRecording()
        {
           // SendMessage(windowHandler, WM_CAP_FILE_SET_CAPTURE_FILE, 0, 0);
           // SendMessage(windowHandler, WM_CAP_SEQUENCE, 0, 0);
           // SendMessage(windowHandler, WM_CAP_START, 0, 0);
        }

        public void stopRecording()
        {
            //SendMessage(windowHandler, WM_CAP_STOP, 0, 0);
           // SendMessage(windowHandler, WM_CAP_PAL_SAVE, 0, "file.avi");
        }

        //set capture file
        //wstępna ocena 3,5
        //TODO:
        //nagrywanie 0,25
        //detekcja ruchu 0,55  może git ?

    }
}
