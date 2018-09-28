using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uFrAdvance;

namespace T2T_Read_and_Write
{
    using DL_STATUS = System.UInt32;
    public partial class Form1 : Form
    {
        DL_STATUS status;


        public static byte[] ToByteArray(String HexString)
        {

            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];

            if (HexString.Length % 2 != 0)
            {
                return bytes;
            }

            for (int i = 0; i < NumberChars; i += 2)
            {
                try
                {
                    bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Incorrect format!");
                    break;
                }
            }

            return bytes;
        }

        String GetDlTypeName(byte dl_type_code)
        {
            String s;

            switch (dl_type_code)
            {
                case DL_MIFARE_ULTRALIGHT:
                    s = "DL_MIFARE_ULTRALIGHT";
                    break;
                case DL_MIFARE_ULTRALIGHT_EV1_11:
                    s = "DL_MIFARE_ULTRALIGHT_EV1_11";
                    break;
                case DL_MIFARE_ULTRALIGHT_EV1_21:
                    s = "DL_MIFARE_ULTRALIGHT_EV1_21";
                    break;
                case DL_MIFARE_ULTRALIGHT_C:
                    s = "DL_MIFARE_ULTRALIGHT_C";
                    break;
                case DL_NTAG_203:
                    s = "DL_NTAG_203";
                    break;
                case DL_NTAG_210:
                    s = "DL_NTAG_210";
                    break;
                case DL_NTAG_212:
                    s = "DL_NTAG_212";
                    break;
                case DL_NTAG_213:
                    s = "DL_NTAG_213";
                    break;
                case DL_NTAG_215:
                    s = "DL_NTAG_215";
                    break;
                case DL_NTAG_216:
                    s = "DL_NTAG_216";
                    break;
                case DL_MIFARE_MINI:
                    s = "DL_MIFARE_MINI";
                    break;
                case DL_MIFARE_CLASSIC_1K:
                    s = "DL_MIFARE_CLASSIC_1K";
                    break;
                case DL_MIFARE_CLASSIC_4K:
                    s = "DL_MIFARE_CLASSIC_4K";
                    break;
                case DL_MIFARE_DESFIRE:
                    s = "DL_MIFARE_DESFIRE";
                    break;
                case DL_MIFARE_DESFIRE_EV1_2K:
                    s = "DL_MIFARE_DESFIRE_EV1_2K";
                    break;
                case DL_MIFARE_DESFIRE_EV1_4K:
                    s = "DL_MIFARE_DESFIRE_EV1_4K";
                    break;
                case DL_MIFARE_DESFIRE_EV1_8K:
                    s = "DL_MIFARE_DESFIRE_EV1_8K";
                    break;
                default:
                    s = "UNSUPPORTED CARD";
                    break;
            }

            return s;
        }

        const byte DL_MIFARE_ULTRALIGHT = 0x01,
                   DL_MIFARE_ULTRALIGHT_EV1_11 = 0x02,
                   DL_MIFARE_ULTRALIGHT_EV1_21 = 0x03,
                   DL_MIFARE_ULTRALIGHT_C = 0x04,
                   DL_NTAG_203 = 0x05,
                   DL_NTAG_210 = 0x06,
                   DL_NTAG_212 = 0x07,
                   DL_NTAG_213 = 0x08,
                   DL_NTAG_215 = 0x09,
                   DL_NTAG_216 = 0x0A,
                   DL_MIFARE_MINI = 0x20,
                   DL_MIFARE_CLASSIC_1K = 0x21,
                   DL_MIFARE_CLASSIC_4K = 0x22,
                   DL_MIFARE_PLUS_S_2K = 0x23,
                   DL_MIFARE_PLUS_S_4K = 0x24,
                   DL_MIFARE_PLUS_X_2K = 0x25,
                   DL_MIFARE_PLUS_X_4K = 0x26,
                   DL_MIFARE_DESFIRE = 0x27,
                   DL_MIFARE_DESFIRE_EV1_2K = 0x28,
                   DL_MIFARE_DESFIRE_EV1_4K = 0x29,
                   DL_MIFARE_DESFIRE_EV1_8K = 0x2A;

        public Form1()
        {
            InitializeComponent();
        }

        private void bReaderOpen_Click(object sender, EventArgs e)
        {
            ReaderTextBox.Clear();
            byte[] SerialDescription = new byte[8];
            byte VerMajor = 0;
            byte VerMinor = 0;
            byte BuildNum = 0;
            ulong reader_type;

            status = uFCoder.ReaderOpen();

            LabelStatus.Text = uFCoder.status2str(status);

            if (status == 0)
            {
                uFCoder.ReaderUISignal(1, 1);
                ReaderTextBox.AppendText("=========================================================== READER INFO ===========================================================");
                ReaderTextBox.AppendText("\nSerial number : ");
                uFCoder.GetReaderSerialDescription(SerialDescription);
                ReaderTextBox.AppendText(System.Text.Encoding.ASCII.GetString(SerialDescription));

                unsafe
                {
                    uFCoder.GetReaderType(&reader_type);
                    ReaderTextBox.AppendText("\nReader type : " + string.Format("{0:X}", reader_type));
                    uFCoder.GetReaderFirmwareVersion(&VerMajor, &VerMinor);
                    uFCoder.GetBuildNumber(&BuildNum);
                    ReaderTextBox.AppendText("\nFirmware version : " + VerMajor.ToString() + '.' + VerMinor.ToString() + '.' + BuildNum.ToString());
                    uFCoder.GetReaderHardwareVersion(&VerMajor, &VerMinor);
                    ReaderTextBox.AppendText("\nHardware version : " + VerMajor.ToString() + '.' + VerMinor.ToString());

                }

                ReaderTextBox.AppendText("\n===================================================================================================================================");

            }
            else
            {
                MessageBox.Show("Error while opening reader!");
            }
        }

        private void bReaderReset_Click(object sender, EventArgs e)
        {
            status = uFCoder.ReaderReset();

            LabelStatus.Text = uFCoder.status2str(status);

            if (status > 0)
            {
                MessageBox.Show("Error while trying to reset reader!");
            }
        }

        private void bReaderClose_Click(object sender, EventArgs e)
        {
            status = uFCoder.ReaderClose();

            LabelStatus.Text = uFCoder.status2str(status);

            if (status > 0)
            {
                MessageBox.Show("Error while trying to close reader!");
            }
        }

        private void bGetCardInfo_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte CardType = 0;
                byte[] Uid = new byte[10];
                byte UidSize = 0;

                status = uFCoder.GetCardIdEx(&CardType, Uid, &UidSize);

                uFCoder.GetDlogicCardType(&CardType);

                LabelStatus.Text = uFCoder.status2str(status);

                if (status == 0)
                {
                    UIDTextBox.TextAlign = HorizontalAlignment.Center;
                    UidLengthTextBox.TextAlign = HorizontalAlignment.Center;
                    CardTypeTextBox.TextAlign = HorizontalAlignment.Center;
                    UIDTextBox.Text = "[" + BitConverter.ToString(Uid).Replace("-", ":") + "]";
                    UidLengthTextBox.Text = "[" + UidSize.ToString() + " bytes]";
                    CardTypeTextBox.Text = "[" + GetDlTypeName(CardType) + "]";
                }
                else
                {
                    UIDTextBox.Clear();
                    CardTypeTextBox.Clear();
                    UidLengthTextBox.Clear();
                }
            }
        }

        private void bReadPage_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte[] PageData = new byte[16];
                String Address_Str = PageNumberTB.Text;
                byte[] ShowData = new byte[4];

                UInt16 PageAddress = UInt16.Parse(Address_Str);

                if (RB_NO_AUTH.Checked == true)
                {
                    status = uFCoder.BlockRead(PageData, PageAddress, 0x60, 0);
                    LabelStatus.Text = uFCoder.status2str(status);
                    Array.Copy(PageData, ShowData, 4);
                    if (status == 0)
                    {
                        PageDataTextBox.Text = BitConverter.ToString(ShowData).Replace("-", ":");
                    }
                    else
                    {
                        PageDataTextBox.Clear();
                    }
                }
                else if (RB_RKA_AUTH.Checked == true)
                {
                    String IndexStr = IndexTB.Text;
                    byte KeyIndex = Byte.Parse(IndexStr);
                    status = uFCoder.BlockRead(PageData, PageAddress, 0x61, KeyIndex);
                    LabelStatus.Text = uFCoder.status2str(status);
                    Array.Copy(PageData, ShowData, 4);
                    if (status == 0)
                    {
                        PageDataTextBox.Text = BitConverter.ToString(ShowData).Replace("-", ":");
                    }
                    else
                    {
                        PageDataTextBox.Clear();
                    }
                }
                else if (RB_PK_AUTH.Checked == true)
                {
                    String key_str = Byte1TB.Text + Byte2TB.Text + Byte3TB.Text + Byte4TB.Text + Byte5TB.Text + Byte6TB.Text;
                    byte[] key = new byte[6];
                    key = ToByteArray(key_str);

                    status = uFCoder.BlockRead_PK(PageData, PageAddress, 0x61, key);
                    LabelStatus.Text = uFCoder.status2str(status);
                    Array.Copy(PageData, ShowData, 4);

                    if (status == 0)
                    {
                        PageDataTextBox.Text = BitConverter.ToString(ShowData).Replace("-", ":");
                    }
                    else
                    {
                        PageDataTextBox.Clear();
                    }
                }

            }
        }

        private void bWritePage_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte[] WriteData = new byte[4];
                String DataStr = PGWByte1.Text + PGWByte2.Text + PGWByte3.Text + PGWByte4.Text;
                String AddressToWrite = PageNumberWriteTB.Text;
                UInt16 WriteAddress = UInt16.Parse(AddressToWrite);
                WriteData = ToByteArray(DataStr);

                if (RB_NO_AUTH.Checked == true)
                {
                    status = uFCoder.BlockWrite(WriteData, WriteAddress, 0x60, 0);
                    LabelStatus.Text = uFCoder.status2str(status);
                }
                else if (RB_RKA_AUTH.Checked == true)
                {
                    String IndexStr = IndexTB.Text;
                    byte KeyIndex = Byte.Parse(IndexStr);
                    status = uFCoder.BlockWrite(WriteData, WriteAddress, 0x61, KeyIndex);
                    LabelStatus.Text = uFCoder.status2str(status);
                }
                else if (RB_PK_AUTH.Checked == true)
                {
                    String key_str = Byte1TB.Text + Byte2TB.Text + Byte3TB.Text + Byte4TB.Text + Byte5TB.Text + Byte6TB.Text;
                    byte[] key = new byte[6];
                    key = ToByteArray(key_str);

                    status = uFCoder.BlockWrite_PK(WriteData, WriteAddress, 0x61, key);

                    LabelStatus.Text = uFCoder.status2str(status);

                }

            }
        }

        private void bLinearRead_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte[] LinearData = new byte[2048];
                String LinAddr = StartByteR.Text;
                String Len = LengthR.Text;
                ushort linear_address = 0;
                ushort data_len = 0;

                try
                {

                    linear_address = ushort.Parse(LinAddr);

                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Incorect start byte!");
                    LinearDataTB.Clear();
                }

                try
                {
                     data_len = ushort.Parse(Len);

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Incorect length!");
                    LinearDataTB.Clear();
                }

                
                ushort bytes_written = 0;

                if(RB_NO_AUTH.Checked == true)
                {
                    status = uFCoder.LinearRead(LinearData, linear_address, data_len, &bytes_written, 0x60, 0);

                    LabelStatus.Text = uFCoder.status2str(status);

                    if (status == 0)
                    {

                        byte[] LinearShow = new byte[data_len];

                        Array.Copy(LinearData, LinearShow, data_len);

                        LinearDataTB.Text = BitConverter.ToString(LinearShow).Replace("-", ":");

                    }
                    else
                    {
                        LinearDataTB.Clear();
                    }

                }
                else if(RB_RKA_AUTH.Checked == true)
                {
                    String IndexStr = IndexTB.Text;
                    byte KeyIndex = Byte.Parse(IndexStr);
                    status = uFCoder.LinearRead(LinearData, linear_address, data_len, &bytes_written, 0x61, KeyIndex);

                    LabelStatus.Text = uFCoder.status2str(status);

                    if (status == 0)
                    {

                        byte[] LinearShow = new byte[data_len];

                        Array.Copy(LinearData, LinearShow, data_len);

                        LinearDataTB.Text = BitConverter.ToString(LinearShow).Replace("-", ":");

                    }
                    else
                    {
                        LinearDataTB.Clear();
                    }

                }else if(RB_PK_AUTH.Checked == true)
                {
                    String key_str = Byte1TB.Text + Byte2TB.Text + Byte3TB.Text + Byte4TB.Text + Byte5TB.Text + Byte6TB.Text;
                    byte[] key = new byte[6];
                    key = ToByteArray(key_str);

                    status = uFCoder.LinearRead_PK(LinearData, linear_address, data_len, &bytes_written, 0x61, key);

                    LabelStatus.Text = uFCoder.status2str(status);

                    if (status == 0)
                    {

                        byte[] LinearShow = new byte[data_len];

                        Array.Copy(LinearData, LinearShow, data_len);

                        LinearDataTB.Text = BitConverter.ToString(LinearShow).Replace("-", ":");

                    }
                    else
                    {
                        LinearDataTB.Clear();
                    }
                }

            }
        }

        private void bLinearWrite_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte[] LWData = new byte[2048];
                String LinAddr = LWStartByte.Text;
                String LWData_Str = LinearWriteTB.Text;
                ushort linear_address = 0;

                try
                {
                     linear_address = ushort.Parse(LinAddr);

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Incorect start byte!");
                    
                }
                
                ushort byte_written = 0;

                LWData = ToByteArray(LWData_Str);

                Int32 data_len = LWData_Str.Length / 2;

                if (RB_NO_AUTH.Checked == true)
                {
                    status = uFCoder.LinearWrite(LWData, linear_address, (ushort)data_len, &byte_written, 0x60, 0);

                    LabelStatus.Text = uFCoder.status2str(status);

                }
                else if(RB_RKA_AUTH.Checked == true)
                {
                    String IndexStr = IndexTB.Text;
                    byte KeyIndex = Byte.Parse(IndexStr);

                    status = uFCoder.LinearWrite(LWData, linear_address, (ushort)data_len, &byte_written, 0x61, KeyIndex);

                    LabelStatus.Text = uFCoder.status2str(status);

                }
                else if(RB_PK_AUTH.Checked == true)
                {
                    String key_str = Byte1TB.Text + Byte2TB.Text + Byte3TB.Text + Byte4TB.Text + Byte5TB.Text + Byte6TB.Text;
                    byte[] key = new byte[6];
                    key = ToByteArray(key_str);

                    status = uFCoder.LinearWrite_PK(LWData, linear_address, (ushort)data_len, &byte_written, 0x61, key);

                    LabelStatus.Text = uFCoder.status2str(status);
                }
                
            }

        }

    }
}
