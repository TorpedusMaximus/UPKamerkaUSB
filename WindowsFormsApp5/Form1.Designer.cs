namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.detect_devices = new System.Windows.Forms.Button();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.cameraWindow = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.settingsDialog = new System.Windows.Forms.Button();
            this.resolutionDialog = new System.Windows.Forms.Button();
            this.cameraShot = new System.Windows.Forms.Button();
            this.endRecording = new System.Windows.Forms.Button();
            this.startRecording = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zoomBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.movementDetector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 616);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz urządzenie: ";
            // 
            // detect_devices
            // 
            this.detect_devices.Location = new System.Drawing.Point(42, 578);
            this.detect_devices.Margin = new System.Windows.Forms.Padding(2);
            this.detect_devices.Name = "detect_devices";
            this.detect_devices.Size = new System.Drawing.Size(105, 23);
            this.detect_devices.TabIndex = 1;
            this.detect_devices.Text = "Wykryj urządzenia";
            this.detect_devices.UseVisualStyleBackColor = true;
            this.detect_devices.Click += new System.EventHandler(this.detect_devices_Click);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(151, 614);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(507, 21);
            this.devicesComboBox.TabIndex = 2;
            // 
            // cameraWindow
            // 
            this.cameraWindow.Location = new System.Drawing.Point(304, 36);
            this.cameraWindow.Margin = new System.Windows.Forms.Padding(2);
            this.cameraWindow.Name = "cameraWindow";
            this.cameraWindow.Size = new System.Drawing.Size(573, 441);
            this.cameraWindow.TabIndex = 3;
            this.cameraWindow.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(33, 36);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(204, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Wyświetl obraz";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // settingsDialog
            // 
            this.settingsDialog.Location = new System.Drawing.Point(33, 96);
            this.settingsDialog.Margin = new System.Windows.Forms.Padding(2);
            this.settingsDialog.Name = "settingsDialog";
            this.settingsDialog.Size = new System.Drawing.Size(204, 27);
            this.settingsDialog.TabIndex = 5;
            this.settingsDialog.Text = "Ustawienia obrazu";
            this.settingsDialog.UseVisualStyleBackColor = true;
            this.settingsDialog.Click += new System.EventHandler(this.settingsDialog_Click);
            // 
            // resolutionDialog
            // 
            this.resolutionDialog.Location = new System.Drawing.Point(33, 127);
            this.resolutionDialog.Margin = new System.Windows.Forms.Padding(2);
            this.resolutionDialog.Name = "resolutionDialog";
            this.resolutionDialog.Size = new System.Drawing.Size(204, 27);
            this.resolutionDialog.TabIndex = 6;
            this.resolutionDialog.Text = "Zmień rozdzielczość";
            this.resolutionDialog.UseVisualStyleBackColor = true;
            this.resolutionDialog.Click += new System.EventHandler(this.resolutionDialog_Click);
            // 
            // cameraShot
            // 
            this.cameraShot.Location = new System.Drawing.Point(33, 207);
            this.cameraShot.Margin = new System.Windows.Forms.Padding(2);
            this.cameraShot.Name = "cameraShot";
            this.cameraShot.Size = new System.Drawing.Size(204, 27);
            this.cameraShot.TabIndex = 7;
            this.cameraShot.Text = "Zrób zdjęcie";
            this.cameraShot.UseVisualStyleBackColor = true;
            this.cameraShot.Click += new System.EventHandler(this.cameraShot_Click);
            // 
            // endRecording
            // 
            this.endRecording.Location = new System.Drawing.Point(33, 269);
            this.endRecording.Margin = new System.Windows.Forms.Padding(2);
            this.endRecording.Name = "endRecording";
            this.endRecording.Size = new System.Drawing.Size(204, 27);
            this.endRecording.TabIndex = 8;
            this.endRecording.Text = "Zakończ nagrywanie";
            this.endRecording.UseVisualStyleBackColor = true;
            this.endRecording.Click += new System.EventHandler(this.endRecording_Click);
            // 
            // startRecording
            // 
            this.startRecording.Location = new System.Drawing.Point(33, 238);
            this.startRecording.Margin = new System.Windows.Forms.Padding(2);
            this.startRecording.Name = "startRecording";
            this.startRecording.Size = new System.Drawing.Size(204, 27);
            this.startRecording.TabIndex = 9;
            this.startRecording.Text = "Rozpocznij nagrywanie";
            this.startRecording.UseVisualStyleBackColor = true;
            this.startRecording.Click += new System.EventHandler(this.startRecording_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ustawienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zapis obrazu:";
            // 
            // zoomBox
            // 
            this.zoomBox.AutoSize = true;
            this.zoomBox.Location = new System.Drawing.Point(36, 157);
            this.zoomBox.Margin = new System.Windows.Forms.Padding(2);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(53, 17);
            this.zoomBox.TabIndex = 12;
            this.zoomBox.Text = "Zoom";
            this.zoomBox.UseVisualStyleBackColor = true;
            this.zoomBox.CheckedChanged += new System.EventHandler(this.zoomBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Zacznij testować ruch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Zakończ testować ruch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // movementDetector
            // 
            this.movementDetector.AutoSize = true;
            this.movementDetector.Location = new System.Drawing.Point(108, 403);
            this.movementDetector.Name = "movementDetector";
            this.movementDetector.Size = new System.Drawing.Size(16, 13);
            this.movementDetector.TabIndex = 16;
            this.movementDetector.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 681);
            this.Controls.Add(this.movementDetector);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zoomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startRecording);
            this.Controls.Add(this.endRecording);
            this.Controls.Add(this.cameraShot);
            this.Controls.Add(this.resolutionDialog);
            this.Controls.Add(this.settingsDialog);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.cameraWindow);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.detect_devices);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kamera";
            ((System.ComponentModel.ISupportInitialize)(this.cameraWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detect_devices;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.PictureBox cameraWindow;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button settingsDialog;
        private System.Windows.Forms.Button resolutionDialog;
        private System.Windows.Forms.Button cameraShot;
        private System.Windows.Forms.Button endRecording;
        private System.Windows.Forms.Button startRecording;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox zoomBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label movementDetector;
    }
}

