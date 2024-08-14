using System;
using System.Collections.Generic;
using System.Text;

namespace bytePacketger
{
    public class Packet
    {
        public static byte[] FloatToByteArray(float value)
        {
            return BitConverter.GetBytes(value);
        }

        // olusturalacak_paket dizisinin global tanımı
        public static byte[] olusturalacak_paket = new byte[78];

        // check_sum hesaplama fonksiyonu
        public static byte check_sum_hesapla()
        {
            int check_sum = 0;

            for (int i = 4; i < 75; i++)
            {
                check_sum += olusturalacak_paket[i];
            }

            return (byte)(check_sum % 256);

        }
        // bütün varileri yerleştirmek için değişkenler
        public static void paket_olustur(byte TeamID, byte Counter, float irtifa, float roketGpsIrtifa, 
            float roketEnlem, float roketBoylam, float gorevYukuGpsIrtifa, float gorevYukuEnlem, float gorevYukuBoylam, 
            float kademeGpsIrtifa, float kademeEnlem, float kademeBoylam, float jiroskopX, float jiroskopY, float jiroskopZ,
            float ivmeX, float ivmeY, float ivmeZ, float aci, byte parachuteİnfo)
        {
            olusturalacak_paket[0] = 0xFF; // Sabit
            olusturalacak_paket[1] = 0xFF; // Sabit
            olusturalacak_paket[2] = 0x54; // Sabit
            olusturalacak_paket[3] = 0x52; // Sabit

            
            olusturalacak_paket[4] = TeamID;    // Takim ID = 0
            olusturalacak_paket[5] = Counter;    // Sayac degeri = 0

            // İrtifa
            byte[] irtifaArray = FloatToByteArray(irtifa);
            Buffer.BlockCopy(irtifaArray, 0, olusturalacak_paket, 6, irtifaArray.Length);

            // Roket GPS İrtifa
            byte[] roketGpsIrtifaArray = FloatToByteArray(roketGpsIrtifa);
            Buffer.BlockCopy(roketGpsIrtifaArray, 0, olusturalacak_paket, 10, roketGpsIrtifaArray.Length);

            // Roket Enlem
            byte[] roketEnlemArray = FloatToByteArray(roketEnlem);
            Buffer.BlockCopy(roketEnlemArray, 0, olusturalacak_paket, 14, roketEnlemArray.Length);

            // Roket Boylam
            byte[] roketBoylamArray = FloatToByteArray(roketBoylam);
            Buffer.BlockCopy(roketBoylamArray, 0, olusturalacak_paket, 18, roketBoylamArray.Length);

            // Görev Yükü GPS İrtifa
            byte[] gorevYukuGpsIrtifaArray = FloatToByteArray(gorevYukuGpsIrtifa);
            Buffer.BlockCopy(gorevYukuGpsIrtifaArray, 0, olusturalacak_paket, 22, gorevYukuGpsIrtifaArray.Length);

            // Görev Yükü Enlem
            byte[] gorevYukuEnlemArray = FloatToByteArray(gorevYukuEnlem);
            Buffer.BlockCopy(gorevYukuEnlemArray, 0, olusturalacak_paket, 26, gorevYukuEnlemArray.Length);

            // Görev Yükü Boylam
            byte[] gorevYukuBoylamArray = FloatToByteArray(gorevYukuBoylam);
            Buffer.BlockCopy(gorevYukuBoylamArray, 0, olusturalacak_paket, 30, gorevYukuBoylamArray.Length);

            // Kademe GPS İrtifa
            byte[] kademeGpsIrtifaArray = FloatToByteArray(kademeGpsIrtifa);
            Buffer.BlockCopy(kademeGpsIrtifaArray, 0, olusturalacak_paket, 34, kademeGpsIrtifaArray.Length);

            // Kademe Enlem
            byte[] kademeEnlemArray = FloatToByteArray(kademeEnlem);
            Buffer.BlockCopy(kademeEnlemArray, 0, olusturalacak_paket, 38, kademeEnlemArray.Length);

            // Kademe Boylam
            byte[] kademeBoylamArray = FloatToByteArray(kademeBoylam);
            Buffer.BlockCopy(kademeBoylamArray, 0, olusturalacak_paket, 42, kademeBoylamArray.Length);

            // Jiroskop X
            byte[] jiroskopXArray = FloatToByteArray(jiroskopX);
            Buffer.BlockCopy(jiroskopXArray, 0, olusturalacak_paket, 46, jiroskopXArray.Length);

            // Jiroskop Y
            byte[] jiroskopYArray = FloatToByteArray(jiroskopY);
            Buffer.BlockCopy(jiroskopYArray, 0, olusturalacak_paket, 50, jiroskopYArray.Length);

            // Jiroskop Z
            byte[] jiroskopZArray = FloatToByteArray(jiroskopZ);
            Buffer.BlockCopy(jiroskopZArray, 0, olusturalacak_paket, 54, jiroskopZArray.Length);

            // İvme X
            byte[] ivmeXArray = FloatToByteArray(ivmeX);
            Buffer.BlockCopy(ivmeXArray, 0, olusturalacak_paket, 58, ivmeXArray.Length);

            // İvme Y
            byte[] ivmeYArray = FloatToByteArray(ivmeY);
            Buffer.BlockCopy(ivmeYArray, 0, olusturalacak_paket, 62, ivmeYArray.Length);

            // İvme Z
            byte[] ivmeZArray = FloatToByteArray(ivmeZ);
            Buffer.BlockCopy(ivmeZArray, 0, olusturalacak_paket, 66, ivmeZArray.Length);

            // Açı
            byte[] aciArray = FloatToByteArray(aci);
            Buffer.BlockCopy(aciArray, 0, olusturalacak_paket, 70, aciArray.Length);

            olusturalacak_paket[74] = parachuteİnfo; // Durum bilgisi = İki paraşüt de tetiklenmedi

            olusturalacak_paket[75] = check_sum_hesapla(); // Check_sum
            olusturalacak_paket[76] = 13; // Sabit
            olusturalacak_paket[77] = 10; // Sabit

           
        }

        public static String returnPacketSTR()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < olusturalacak_paket.Length; i++)
            {
                sb.Append($"0x{olusturalacak_paket[i]:X2} ");
            }

            return sb.ToString().Trim();
        }


    }
}