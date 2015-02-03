using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PacDriveDemo
{
    public partial class Form1 : Form
    {
        private PacDrive m_PacDrive = null;
        private CheckBox[] m_LedButton = null;
        private bool[] m_LedState = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_LedButton = new CheckBox[16];
            m_LedState = new bool[16];

            CreateLEDButtons();

            m_PacDrive = new PacDrive(this);
            m_PacDrive.OnPacAttached += new PacDrive.PacAttachedDelegate(OnPacAttached);
            m_PacDrive.OnPacRemoved += new PacDrive.PacRemovedDelegate(OnPacRemoved);
            m_PacDrive.Initialize();

            UpdateDeviceList();
        }

        private void CreateLEDButtons()
        {
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    int id = y * 8 + x;
                    Size size = new Size(panel1.Width / 8, panel1.Height / 2);

                    m_LedButton[id] = new CheckBox();

                    m_LedButton[id].Location = new Point(x * size.Width, y * size.Height);
                    m_LedButton[id].Size = size;

                    m_LedButton[id].Appearance = Appearance.Button;

                    m_LedButton[id].Text = id.ToString();

                    m_LedButton[id].CheckedChanged += new EventHandler(LedButton_CheckedChanged);

                    panel1.Controls.Add(m_LedButton[id]);
                }
            }
        }

        private void UpdateDeviceList()
        {
            lvwDevices.Items.Clear();

            for (int i = 0; i < m_PacDrive.NumDevices; i++)
                lvwDevices.Items.Add(new ListViewItem(new string[] { m_PacDrive.GetDeviceType(i).ToString(), m_PacDrive.GetVendorId(i).ToString(), m_PacDrive.GetProductId(i).ToString(), m_PacDrive.GetVersionNumber(i).ToString(), m_PacDrive.GetVendorName(i), m_PacDrive.GetProductName(i), m_PacDrive.GetSerialNumber(i), m_PacDrive.GetDevicePath(i) }));

            for (int i = 0; i < lvwDevices.Columns.Count; i++)
                lvwDevices.Columns[i].Width = -2;

            if (lvwDevices.Items.Count > 0)
            {
                lvwDevices.SelectedIndices.Clear();
                lvwDevices.SelectedIndices.Add(0);
            }
        }

        private void OnPacAttached(int id)
        {
            UpdateDeviceList();
        }

        private void OnPacRemoved(int id)
        {
            UpdateDeviceList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_PacDrive.Shutdown();
        }

        private void LedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            CheckBox chk = (CheckBox)sender;

            m_LedState[Int32.Parse(chk.Text)] = chk.Checked;

            if (m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.PacLED64 ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.NanoLED ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.IPACIO)
                m_PacDrive.SetLED64States(id, (int) LEDGroup.Value, m_LedState);
            else
                m_PacDrive.SetLEDStates(id, m_LedState);
        }

        private void Intensity_Scroll(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            if ((int)LEDNumber.Value == 0)
            {
                byte[] data = new byte[128];

				for (int i = 0; i < 128; i++)
                    data[i] = (byte)Intensity.Value;

                m_PacDrive.SetLED64Intensities(id, data);
            }
            else
                m_PacDrive.SetLED64Intensity(id, (int)LEDNumber.Value - 1, (byte)Intensity.Value);
        }

        private void lvwDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

			if (m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.PacLED64 ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.NanoLED ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.IPACIO)
            {
                for (int i = 0; i < 16; i++)
                    m_LedButton[i].Visible = (i < 8);
            }
            else
            {
                for (int i = 0; i < 16; i++)
                    m_LedButton[i].Visible = true;
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

			if (m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.PacLED64 ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.NanoLED ||
				m_PacDrive.GetDeviceType(id) == PacDrive.DeviceType.IPACIO)
                m_PacDrive.SetLED64StatesRandom(id);
            else
                m_PacDrive.SetLEDStates(id, (ushort) new Random().Next(0xFFFF));
        }

        private void StartRecording_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.StartScriptRecording(id);
        }

        private void StopRecording_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.StopScriptRecording(id);
        }

        private void ClearFlash_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.ClearFlash(id);
        }

        private void RunScript_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.RunScript(id);
        }

        private void FadeTime_Scroll(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.SetLED64FadeTime(id, (byte)FadeTime.Value);
        }

        private void FlashSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];
            PacDrive.FlashSpeed flashSpeed = 0;

            if (rdoAlwaysOn.Checked)
                flashSpeed = PacDrive.FlashSpeed.AlwaysOn;
            else if (rdoSeconds_2.Checked)
                flashSpeed = PacDrive.FlashSpeed.Seconds_2;
            else if (rdoSeconds_1.Checked)
                flashSpeed = PacDrive.FlashSpeed.Seconds_1;
            else if (rdoSeconds_0_5.Checked)
                flashSpeed = PacDrive.FlashSpeed.Seconds_0_5;

            if(LEDNumber.Value == 0)
                m_PacDrive.SetLED64FlashSpeeds(id, flashSpeed);
            else
                m_PacDrive.SetLED64FlashSpeed(id, (byte)LEDNumber.Value - 1, flashSpeed);
        }

        private void ScriptStepDelay_Scroll(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.SetScriptStepDelay(id, (byte)ScriptStepDelay.Value);
        }

        private void SetDeviceID_Click(object sender, EventArgs e)
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            m_PacDrive.SetDeviceId(id, (int)DeviceId.Value);
        }

        private void ProgUHID_Click(object sender, EventArgs e)
        {
            ProgramUHid();
        }

        private void ProgramUHid()
        {
            if (lvwDevices.SelectedIndices.Count == 0)
                return;

            int id = lvwDevices.SelectedIndices[0];

            if (m_PacDrive.GetDeviceType(id) != PacDrive.DeviceType.UHID)
                return;

            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Raw Files (*.raw)|*.raw";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
                m_PacDrive.ProgramUHid(id, fileDialog.FileName);
        }

        private void SetPerminent_Click(object sender, EventArgs e)
        {
			if (lvwDevices.SelectedIndices.Count == 0)
				return;

			int id = lvwDevices.SelectedIndices[0];

			if (m_PacDrive.GetDeviceType(id) != PacDrive.DeviceType.USBButton)
				return;

            byte[] data = new byte[62];
            byte[] releasedColorData = GetUSBButtonColor(butReleased.BackColor);
            byte[] pressedColorData = GetUSBButtonColor(butPressed.BackColor);
            byte[] strData = GetUSBButtonData(Url.Text);

            data[0] = 0x00; // Mode (00 = Alternate, 01 = Extended, 02 = both)
            data[1] = 0x00; // Spare

            Buffer.BlockCopy(releasedColorData, 0, data, 2, pressedColorData.Length);
            Buffer.BlockCopy(pressedColorData, 0, data, 5, pressedColorData.Length);
            Buffer.BlockCopy(strData, 0, data, 8, strData.Length);

            m_PacDrive.SetUSBButtonConfigurePermanent(id, data);
        }

        private void SetTemporary_Click(object sender, EventArgs e)
        {
			if (lvwDevices.SelectedIndices.Count == 0)
				return;

			int id = lvwDevices.SelectedIndices[0];

			if (m_PacDrive.GetDeviceType(id) != PacDrive.DeviceType.USBButton)
				return;

            byte[] data = new byte[62];
            byte[] releasedColorData = GetUSBButtonColor(butReleased.BackColor);
            byte[] pressedColorData = GetUSBButtonColor(butPressed.BackColor);
            byte[] strData = GetUSBButtonData(Url.Text);

            data[0] = 0x00; // Mode (00 = Alternate, 01 = Extended, 02 = both)
            data[1] = 0x00; // Spare

            Buffer.BlockCopy(releasedColorData, 0, data, 2, pressedColorData.Length);
            Buffer.BlockCopy(pressedColorData, 0, data, 5, pressedColorData.Length);
            Buffer.BlockCopy(strData, 0, data, 8, strData.Length);

            m_PacDrive.SetUSBButtonConfigureTemporary(id, data);
        }

        private byte[] GetUSBButtonColor(Color color)
        {
            byte[] data = new byte[3];

            data[0] = color.R;
            data[1] = color.G;
            data[2] = color.B;

            return data;
        }

        private byte[] GetUSBButtonData(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char chr = str.ToUpper()[i];

                if (chr >= 'A' && chr <= 'Z')
                    data[i] = (byte)(chr - 61);
                else if (chr == ' ')
                    data[i] = 0x2C;
            }

            return data;
        }

        private void butPressed_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog1 = new ColorDialog())
            {
                DialogResult result = colorDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    butPressed.BackColor = colorDialog1.Color;
                }
            }
        }

        private void butReleased_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog1 = new ColorDialog())
            {
                DialogResult result = colorDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    butReleased.BackColor = colorDialog1.Color;
                }
            }
        }

        private void GetState_Click(object sender, EventArgs e)
        {
			if (lvwDevices.SelectedIndices.Count == 0)
				return;

			int id = lvwDevices.SelectedIndices[0];

			if (m_PacDrive.GetDeviceType(id) != PacDrive.DeviceType.USBButton)
				return;

			bool state = false;

			if (m_PacDrive.GetUSBButtonState(id, ref state))
				lblState.Text = state ? "Pressed" : "Released";
        }
    }
}