using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bytePacketger;

namespace byte_Test
{
    public partial class Form1 : Form
    {
        public byte teamID;
        public byte counter;
        public float irtifa;
        public float roketGps;
        public float roketEnlem;
        public float roketBoylam;
        public float yukGPS;
        public float yukEnlem;
        public float yukBoylam;
        public float gyroX;
        public float gyroY;
        public float gyroZ;
        public float ivmeX;
        public float ivmeY;
        public float ivmeZ;
        public float aci;
        public byte parachute;


        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {teamID = byte.Parse(uint8_teamID.Text); } catch (FormatException) {teamID = 0;}
            try {counter = byte.Parse(uint8_PacketCounter.Text); } catch (FormatException) { counter = 0; }
            try {irtifa = float.Parse(float32_irtifa.Text); } catch (FormatException) { irtifa = 0; }
            try {roketGps = float.Parse(float32_rGPS.Text); } catch (FormatException) {roketGps = 0; }
            try {roketEnlem = float.Parse(float32_rEnlem.Text); } catch (FormatException) {roketEnlem = 0; }
            try {roketBoylam = float.Parse(float32_rBoylam.Text); } catch (FormatException) {roketBoylam = 0; }
            try {yukGPS = float.Parse(float32_yGPS.Text); } catch (FormatException) {yukGPS = 0; }
            try {yukEnlem = float.Parse(float32_yEnlem.Text); } catch (FormatException) {yukEnlem = 0; }
            try {yukBoylam = float.Parse(float32_yBoylam.Text); } catch (FormatException) {yukBoylam = 0; }
            try {gyroX = float.Parse(float32_gyroX.Text); } catch (FormatException) {gyroX = 0; }
            try { gyroY = float.Parse(float32_gyroY.Text); } catch (FormatException) { gyroY = 0; }
            try { gyroZ = float.Parse(float32_gyroZ.Text); } catch (FormatException) { gyroZ = 0; }
            try { ivmeX = float.Parse(float32_ivmeX.Text); } catch (FormatException) { ivmeX = 0; }
            try { ivmeY = float.Parse(float32_ivmeY.Text); } catch (FormatException) { ivmeY = 0; }
            try { ivmeZ = float.Parse(float32_ivmeZ.Text); } catch (FormatException) { ivmeZ = 0; }
            try { aci = float.Parse(float32_aci.Text); } catch (FormatException) { aci = 0; }
            try { parachute = byte.Parse(uint8_Durum.Text); } catch (FormatException) { parachute = 0; }

            Packet.paket_olustur(teamID, counter, irtifa, roketGps, roketEnlem, roketBoylam, yukGPS, yukEnlem, yukBoylam, 0, 0, 0, gyroX, gyroY, gyroZ, ivmeX, ivmeY, ivmeZ, aci, parachute);

            output.Text = Packet.returnPacketSTR();
        }
    }
}
