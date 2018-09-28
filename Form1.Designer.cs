namespace T2T_Read_and_Write
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bReaderClose = new System.Windows.Forms.Button();
            this.bReaderReset = new System.Windows.Forms.Button();
            this.bReaderOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bGetCardInfo = new System.Windows.Forms.Button();
            this.CardTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UidLengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReaderTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RB_PK_AUTH = new System.Windows.Forms.RadioButton();
            this.RB_RKA_AUTH = new System.Windows.Forms.RadioButton();
            this.RB_NO_AUTH = new System.Windows.Forms.RadioButton();
            this.Byte6TB = new System.Windows.Forms.TextBox();
            this.Byte5TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Byte4TB = new System.Windows.Forms.TextBox();
            this.Byte3TB = new System.Windows.Forms.TextBox();
            this.Byte2TB = new System.Windows.Forms.TextBox();
            this.Byte1TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IndexTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bReadPage = new System.Windows.Forms.Button();
            this.PageDataTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PageNumberTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bWritePage = new System.Windows.Forms.Button();
            this.PGWByte4 = new System.Windows.Forms.TextBox();
            this.PGWByte3 = new System.Windows.Forms.TextBox();
            this.PGWByte2 = new System.Windows.Forms.TextBox();
            this.PGWByte1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PageNumberWriteTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.LinearDataTB = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bLinearRead = new System.Windows.Forms.Button();
            this.LengthR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StartByteR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bLinearWrite = new System.Windows.Forms.Button();
            this.LinearWriteTB = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LWStartByte = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bReaderClose);
            this.groupBox1.Controls.Add(this.bReaderReset);
            this.groupBox1.Controls.Add(this.bReaderOpen);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader commands";
            // 
            // bReaderClose
            // 
            this.bReaderClose.Location = new System.Drawing.Point(184, 19);
            this.bReaderClose.Name = "bReaderClose";
            this.bReaderClose.Size = new System.Drawing.Size(79, 23);
            this.bReaderClose.TabIndex = 2;
            this.bReaderClose.Text = "Reader Close";
            this.bReaderClose.UseVisualStyleBackColor = true;
            this.bReaderClose.Click += new System.EventHandler(this.bReaderClose_Click);
            // 
            // bReaderReset
            // 
            this.bReaderReset.Location = new System.Drawing.Point(93, 19);
            this.bReaderReset.Name = "bReaderReset";
            this.bReaderReset.Size = new System.Drawing.Size(85, 23);
            this.bReaderReset.TabIndex = 1;
            this.bReaderReset.Text = "Reader Reset";
            this.bReaderReset.UseVisualStyleBackColor = true;
            this.bReaderReset.Click += new System.EventHandler(this.bReaderReset_Click);
            // 
            // bReaderOpen
            // 
            this.bReaderOpen.Location = new System.Drawing.Point(6, 19);
            this.bReaderOpen.Name = "bReaderOpen";
            this.bReaderOpen.Size = new System.Drawing.Size(81, 23);
            this.bReaderOpen.TabIndex = 0;
            this.bReaderOpen.Text = "Reader Open";
            this.bReaderOpen.UseVisualStyleBackColor = true;
            this.bReaderOpen.Click += new System.EventHandler(this.bReaderOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bGetCardInfo);
            this.groupBox2.Controls.Add(this.CardTypeTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UidLengthTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UIDTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "T2T Tag Informations :";
            // 
            // bGetCardInfo
            // 
            this.bGetCardInfo.Location = new System.Drawing.Point(307, 48);
            this.bGetCardInfo.Name = "bGetCardInfo";
            this.bGetCardInfo.Size = new System.Drawing.Size(144, 23);
            this.bGetCardInfo.TabIndex = 6;
            this.bGetCardInfo.Text = "GET CARD INFO";
            this.bGetCardInfo.UseVisualStyleBackColor = true;
            this.bGetCardInfo.Click += new System.EventHandler(this.bGetCardInfo_Click);
            // 
            // CardTypeTextBox
            // 
            this.CardTypeTextBox.Location = new System.Drawing.Point(555, 22);
            this.CardTypeTextBox.Name = "CardTypeTextBox";
            this.CardTypeTextBox.ReadOnly = true;
            this.CardTypeTextBox.Size = new System.Drawing.Size(225, 20);
            this.CardTypeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Card Type :";
            // 
            // UidLengthTextBox
            // 
            this.UidLengthTextBox.Location = new System.Drawing.Point(381, 22);
            this.UidLengthTextBox.Name = "UidLengthTextBox";
            this.UidLengthTextBox.ReadOnly = true;
            this.UidLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.UidLengthTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card UID Length : ";
            // 
            // UIDTextBox
            // 
            this.UIDTextBox.Location = new System.Drawing.Point(67, 22);
            this.UIDTextBox.Name = "UIDTextBox";
            this.UIDTextBox.ReadOnly = true;
            this.UIDTextBox.Size = new System.Drawing.Size(216, 20);
            this.UIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card UID :";
            // 
            // ReaderTextBox
            // 
            this.ReaderTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReaderTextBox.Location = new System.Drawing.Point(2, 543);
            this.ReaderTextBox.Name = "ReaderTextBox";
            this.ReaderTextBox.ReadOnly = true;
            this.ReaderTextBox.Size = new System.Drawing.Size(795, 83);
            this.ReaderTextBox.TabIndex = 2;
            this.ReaderTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.Byte6TB);
            this.groupBox3.Controls.Add(this.Byte5TB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Byte4TB);
            this.groupBox3.Controls.Add(this.Byte3TB);
            this.groupBox3.Controls.Add(this.Byte2TB);
            this.groupBox3.Controls.Add(this.Byte1TB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.IndexTB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(8, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 89);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set authentication mode";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RB_PK_AUTH);
            this.groupBox6.Controls.Add(this.RB_RKA_AUTH);
            this.groupBox6.Controls.Add(this.RB_NO_AUTH);
            this.groupBox6.Location = new System.Drawing.Point(6, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(155, 77);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // RB_PK_AUTH
            // 
            this.RB_PK_AUTH.AutoSize = true;
            this.RB_PK_AUTH.Location = new System.Drawing.Point(6, 50);
            this.RB_PK_AUTH.Name = "RB_PK_AUTH";
            this.RB_PK_AUTH.Size = new System.Drawing.Size(133, 17);
            this.RB_PK_AUTH.TabIndex = 2;
            this.RB_PK_AUTH.Text = "T2T_PK_PWD_AUTH";
            this.RB_PK_AUTH.UseVisualStyleBackColor = true;
            // 
            // RB_RKA_AUTH
            // 
            this.RB_RKA_AUTH.AutoSize = true;
            this.RB_RKA_AUTH.Location = new System.Drawing.Point(6, 30);
            this.RB_RKA_AUTH.Name = "RB_RKA_AUTH";
            this.RB_RKA_AUTH.Size = new System.Drawing.Size(141, 17);
            this.RB_RKA_AUTH.TabIndex = 1;
            this.RB_RKA_AUTH.Text = "T2T_RKA_PWD_AUTH";
            this.RB_RKA_AUTH.UseVisualStyleBackColor = true;
            // 
            // RB_NO_AUTH
            // 
            this.RB_NO_AUTH.AutoSize = true;
            this.RB_NO_AUTH.Checked = true;
            this.RB_NO_AUTH.Location = new System.Drawing.Point(6, 7);
            this.RB_NO_AUTH.Name = "RB_NO_AUTH";
            this.RB_NO_AUTH.Size = new System.Drawing.Size(135, 17);
            this.RB_NO_AUTH.TabIndex = 0;
            this.RB_NO_AUTH.TabStop = true;
            this.RB_NO_AUTH.Text = "T2T_NO_PWD_AUTH";
            this.RB_NO_AUTH.UseVisualStyleBackColor = true;
            // 
            // Byte6TB
            // 
            this.Byte6TB.Location = new System.Drawing.Point(519, 61);
            this.Byte6TB.MaxLength = 2;
            this.Byte6TB.Name = "Byte6TB";
            this.Byte6TB.Size = new System.Drawing.Size(30, 20);
            this.Byte6TB.TabIndex = 14;
            this.Byte6TB.Text = "FF";
            this.Byte6TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte5TB
            // 
            this.Byte5TB.Location = new System.Drawing.Point(483, 60);
            this.Byte5TB.MaxLength = 2;
            this.Byte5TB.Name = "Byte5TB";
            this.Byte5TB.Size = new System.Drawing.Size(30, 20);
            this.Byte5TB.TabIndex = 13;
            this.Byte5TB.Text = "FF";
            this.Byte5TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter new PACK :";
            // 
            // Byte4TB
            // 
            this.Byte4TB.Location = new System.Drawing.Point(353, 62);
            this.Byte4TB.MaxLength = 2;
            this.Byte4TB.Name = "Byte4TB";
            this.Byte4TB.Size = new System.Drawing.Size(30, 20);
            this.Byte4TB.TabIndex = 11;
            this.Byte4TB.Text = "FF";
            this.Byte4TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte3TB
            // 
            this.Byte3TB.Location = new System.Drawing.Point(318, 61);
            this.Byte3TB.MaxLength = 2;
            this.Byte3TB.Name = "Byte3TB";
            this.Byte3TB.Size = new System.Drawing.Size(30, 20);
            this.Byte3TB.TabIndex = 10;
            this.Byte3TB.Text = "FF";
            this.Byte3TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte2TB
            // 
            this.Byte2TB.Location = new System.Drawing.Point(282, 60);
            this.Byte2TB.MaxLength = 2;
            this.Byte2TB.Name = "Byte2TB";
            this.Byte2TB.Size = new System.Drawing.Size(30, 20);
            this.Byte2TB.TabIndex = 9;
            this.Byte2TB.Text = "FF";
            this.Byte2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte1TB
            // 
            this.Byte1TB.Location = new System.Drawing.Point(246, 60);
            this.Byte1TB.MaxLength = 2;
            this.Byte1TB.Name = "Byte1TB";
            this.Byte1TB.Size = new System.Drawing.Size(30, 20);
            this.Byte1TB.TabIndex = 8;
            this.Byte1TB.Text = "FF";
            this.Byte1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter new PWD :";
            // 
            // IndexTB
            // 
            this.IndexTB.Location = new System.Drawing.Point(334, 38);
            this.IndexTB.MaxLength = 2;
            this.IndexTB.Name = "IndexTB";
            this.IndexTB.Size = new System.Drawing.Size(30, 20);
            this.IndexTB.TabIndex = 6;
            this.IndexTB.Text = "0";
            this.IndexTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PWD/PACK index stored in reader : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bReadPage);
            this.groupBox4.Controls.Add(this.PageDataTextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.PageNumberTB);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(8, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Page read";
            // 
            // bReadPage
            // 
            this.bReadPage.Location = new System.Drawing.Point(122, 22);
            this.bReadPage.Name = "bReadPage";
            this.bReadPage.Size = new System.Drawing.Size(75, 23);
            this.bReadPage.TabIndex = 5;
            this.bReadPage.Text = "Read";
            this.bReadPage.UseVisualStyleBackColor = true;
            this.bReadPage.Click += new System.EventHandler(this.bReadPage_Click);
            // 
            // PageDataTextBox
            // 
            this.PageDataTextBox.BackColor = System.Drawing.Color.White;
            this.PageDataTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDataTextBox.Location = new System.Drawing.Point(7, 71);
            this.PageDataTextBox.Name = "PageDataTextBox";
            this.PageDataTextBox.ReadOnly = true;
            this.PageDataTextBox.Size = new System.Drawing.Size(341, 21);
            this.PageDataTextBox.TabIndex = 5;
            this.PageDataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data :";
            // 
            // PageNumberTB
            // 
            this.PageNumberTB.Location = new System.Drawing.Point(86, 24);
            this.PageNumberTB.MaxLength = 3;
            this.PageNumberTB.Name = "PageNumberTB";
            this.PageNumberTB.Size = new System.Drawing.Size(30, 20);
            this.PageNumberTB.TabIndex = 5;
            this.PageNumberTB.Text = "0";
            this.PageNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Page number :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bWritePage);
            this.groupBox5.Controls.Add(this.PGWByte4);
            this.groupBox5.Controls.Add(this.PGWByte3);
            this.groupBox5.Controls.Add(this.PGWByte2);
            this.groupBox5.Controls.Add(this.PGWByte1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.PageNumberWriteTB);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(368, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Page write";
            // 
            // bWritePage
            // 
            this.bWritePage.Location = new System.Drawing.Point(231, 69);
            this.bWritePage.Name = "bWritePage";
            this.bWritePage.Size = new System.Drawing.Size(183, 23);
            this.bWritePage.TabIndex = 7;
            this.bWritePage.Text = "Write data to page";
            this.bWritePage.UseVisualStyleBackColor = true;
            this.bWritePage.Click += new System.EventHandler(this.bWritePage_Click);
            // 
            // PGWByte4
            // 
            this.PGWByte4.Location = new System.Drawing.Point(195, 71);
            this.PGWByte4.MaxLength = 2;
            this.PGWByte4.Name = "PGWByte4";
            this.PGWByte4.Size = new System.Drawing.Size(30, 20);
            this.PGWByte4.TabIndex = 6;
            this.PGWByte4.Text = "FF";
            this.PGWByte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PGWByte3
            // 
            this.PGWByte3.Location = new System.Drawing.Point(159, 71);
            this.PGWByte3.MaxLength = 2;
            this.PGWByte3.Name = "PGWByte3";
            this.PGWByte3.Size = new System.Drawing.Size(30, 20);
            this.PGWByte3.TabIndex = 5;
            this.PGWByte3.Text = "FF";
            this.PGWByte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PGWByte2
            // 
            this.PGWByte2.Location = new System.Drawing.Point(123, 71);
            this.PGWByte2.MaxLength = 2;
            this.PGWByte2.Name = "PGWByte2";
            this.PGWByte2.Size = new System.Drawing.Size(30, 20);
            this.PGWByte2.TabIndex = 4;
            this.PGWByte2.Text = "FF";
            this.PGWByte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PGWByte1
            // 
            this.PGWByte1.Location = new System.Drawing.Point(87, 71);
            this.PGWByte1.MaxLength = 2;
            this.PGWByte1.Name = "PGWByte1";
            this.PGWByte1.Size = new System.Drawing.Size(30, 20);
            this.PGWByte1.TabIndex = 3;
            this.PGWByte1.Text = "FF";
            this.PGWByte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data to write :";
            // 
            // PageNumberWriteTB
            // 
            this.PageNumberWriteTB.Location = new System.Drawing.Point(88, 24);
            this.PageNumberWriteTB.MaxLength = 3;
            this.PageNumberWriteTB.Name = "PageNumberWriteTB";
            this.PageNumberWriteTB.Size = new System.Drawing.Size(30, 20);
            this.PageNumberWriteTB.TabIndex = 1;
            this.PageNumberWriteTB.Text = "4";
            this.PageNumberWriteTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Page number :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.LinearDataTB);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.bLinearRead);
            this.groupBox7.Controls.Add(this.LengthR);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.StartByteR);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(8, 352);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(354, 185);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Linear read";
            // 
            // LinearDataTB
            // 
            this.LinearDataTB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearDataTB.Location = new System.Drawing.Point(4, 63);
            this.LinearDataTB.Name = "LinearDataTB";
            this.LinearDataTB.Size = new System.Drawing.Size(344, 116);
            this.LinearDataTB.TabIndex = 6;
            this.LinearDataTB.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Data :";
            // 
            // bLinearRead
            // 
            this.bLinearRead.Location = new System.Drawing.Point(251, 20);
            this.bLinearRead.Name = "bLinearRead";
            this.bLinearRead.Size = new System.Drawing.Size(97, 23);
            this.bLinearRead.TabIndex = 4;
            this.bLinearRead.Text = "Linear read";
            this.bLinearRead.UseVisualStyleBackColor = true;
            this.bLinearRead.Click += new System.EventHandler(this.bLinearRead_Click);
            // 
            // LengthR
            // 
            this.LengthR.Location = new System.Drawing.Point(205, 22);
            this.LengthR.MaxLength = 5;
            this.LengthR.Name = "LengthR";
            this.LengthR.Size = new System.Drawing.Size(40, 20);
            this.LengthR.TabIndex = 3;
            this.LengthR.Text = "4";
            this.LengthR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Length :";
            // 
            // StartByteR
            // 
            this.StartByteR.Location = new System.Drawing.Point(107, 22);
            this.StartByteR.MaxLength = 5;
            this.StartByteR.Name = "StartByteR";
            this.StartByteR.Size = new System.Drawing.Size(40, 20);
            this.StartByteR.TabIndex = 1;
            this.StartByteR.Text = "0";
            this.StartByteR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Start byte address :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bLinearWrite);
            this.groupBox8.Controls.Add(this.LinearWriteTB);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.LWStartByte);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(368, 352);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(420, 185);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Linear write";
            // 
            // bLinearWrite
            // 
            this.bLinearWrite.Location = new System.Drawing.Point(159, 20);
            this.bLinearWrite.Name = "bLinearWrite";
            this.bLinearWrite.Size = new System.Drawing.Size(75, 23);
            this.bLinearWrite.TabIndex = 4;
            this.bLinearWrite.Text = "Linear write";
            this.bLinearWrite.UseVisualStyleBackColor = true;
            this.bLinearWrite.Click += new System.EventHandler(this.bLinearWrite_Click);
            // 
            // LinearWriteTB
            // 
            this.LinearWriteTB.Location = new System.Drawing.Point(6, 63);
            this.LinearWriteTB.Name = "LinearWriteTB";
            this.LinearWriteTB.Size = new System.Drawing.Size(408, 116);
            this.LinearWriteTB.TabIndex = 3;
            this.LinearWriteTB.Text = "FFFFFFFF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Data to write (without delimiter) :";
            // 
            // LWStartByte
            // 
            this.LWStartByte.Location = new System.Drawing.Point(110, 22);
            this.LWStartByte.Name = "LWStartByte";
            this.LWStartByte.Size = new System.Drawing.Size(40, 20);
            this.LWStartByte.TabIndex = 1;
            this.LWStartByte.Text = "0";
            this.LWStartByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Start byte address :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2, 629);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 8;
            this.label16.Text = "Status : ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(48, 642);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 9;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(72, 629);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(35, 14);
            this.LabelStatus.TabIndex = 10;
            this.LabelStatus.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ReaderTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bReaderClose;
        private System.Windows.Forms.Button bReaderReset;
        private System.Windows.Forms.Button bReaderOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGetCardInfo;
        private System.Windows.Forms.TextBox CardTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UidLengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ReaderTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Byte6TB;
        private System.Windows.Forms.TextBox Byte5TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Byte4TB;
        private System.Windows.Forms.TextBox Byte3TB;
        private System.Windows.Forms.TextBox Byte2TB;
        private System.Windows.Forms.TextBox Byte1TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IndexTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bReadPage;
        private System.Windows.Forms.TextBox PageDataTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PageNumberTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bWritePage;
        private System.Windows.Forms.TextBox PGWByte4;
        private System.Windows.Forms.TextBox PGWByte3;
        private System.Windows.Forms.TextBox PGWByte2;
        private System.Windows.Forms.TextBox PGWByte1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PageNumberWriteTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton RB_PK_AUTH;
        private System.Windows.Forms.RadioButton RB_RKA_AUTH;
        private System.Windows.Forms.RadioButton RB_NO_AUTH;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox LinearDataTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bLinearRead;
        private System.Windows.Forms.TextBox LengthR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox StartByteR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox LWStartByte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bLinearWrite;
        private System.Windows.Forms.RichTextBox LinearWriteTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LabelStatus;
    }
}

