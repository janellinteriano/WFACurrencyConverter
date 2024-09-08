namespace WFACurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Label = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            newAmt = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.FlatStyle = FlatStyle.Popup;
            Label.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Label.ForeColor = Color.DarkRed;
            Label.Location = new Point(232, 240);
            Label.Name = "Label";
            Label.Size = new Size(455, 57);
            Label.TabIndex = 0;
            Label.Text = "Currency Converter";
            Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(368, 671);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 1;
            button1.Text = "CONVERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(325, 495);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 26);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 440);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 3;
            label1.Text = "Amount:";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownHeight = 200;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 400;
            comboBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "AED - UAE Dirham", "AFN - Afghan Afghani", "ALL - Albanian Lek", "AMD - Armenian Dram", "ANG - Netherlands Antillian Guilder", "AOA - Angolan Kwanza", "ARS - Argentine Peso", "AUD - Australian Dollar", "AWG - Aruban Florin", "AZN - Azerbaijani Manat", "BAM - Bosnia and Herzegovina Mark", "BBD - Barbados Dollar", "BDT - Bangladeshi Taka", "BGN - Bulgarian Lev", "BHD - Bahraini Dinar", "BIF - Burundian Franc", "BMD - Bermudian Dollar", "BND - Brunei Dollar", "BOB - Bolivian Boliviano", "BRL - Brazilian Real", "BSD - Bahamian Dollar", "BTN - Bhutanese Ngultrum", "BWP - Botswana Pula", "BYN - Belarusian Ruble", "BZD - Belize Dollar", "CAD - Canadian Dollar", "CDF - Congolese Franc", "CHF - Swiss Franc", "CLP - Chilean Peso", "CNY - Chinese Renminbi", "COP - Colombian Peso", "CRC - Costa Rican Colon", "CUP - Cuban Peso", "CVE - Cape Verdean Escudo", "CZK - Czech Koruna", "DJF - Djiboutian Franc", "DKK - Danish Krone", "DOP - Dominican Peso", "DZD - Algerian Dinar", "EGP - Egyptian Pound", "ERN - Eritrean Nakfa", "ETB - Ethiopian Birr", "EUR - Euro", "FJD - Fiji Dollar", "FKP - Falkland Islands Pound", "FOK - Faroese Króna", "GBP - Pound Sterling", "GEL - Georgian Lari", "GGP - Guernsey Pound", "GHS - Ghanaian Cedi", "GIP - Gibraltar Pound", "GMD - Gambian Dalasi", "GNF - Guinean Franc", "GTQ - Guatemalan Quetzal", "GYD - Guyanese Dollar", "HKD - Hong Kong Dollar", "HNL - Honduran Lempira", "HRK - Croatian Kuna", "HTG - Haitian Gourde", "HUF - Hungarian Forint", "IDR - Indonesian Rupiah", "ILS - Israeli New Shekel", "IMP - Manx Pound", "INR - Indian Rupee", "IQD - Iraqi Dinar", "IRR - Iranian Rial", "ISK - Icelandic Króna", "JEP - Jersey Pound", "JMD - Jamaican Dollar", "JOD - Jordanian Dinar", "JPY - Japanese Yen", "KES - Kenyan Shilling", "KGS - Kyrgyzstani Som", "KHR - Cambodian Riel", "KID - Kiribati Dollar", "KMF - Comorian Franc", "KRW - South Korean Won", "KWD - Kuwaiti Dinar", "KYD - Cayman Islands Dollar", "KZT - Kazakhstani Tenge", "LAK - Lao Kip", "LBP - Lebanese Pound", "LKR - Sri Lanka Rupee", "LRD - Liberian Dollar", "LSL - Lesotho Loti", "LYD - Libyan Dinar", "MAD - Moroccan Dirham", "MDL - Moldovan Leu", "MGA - Malagasy Ariary", "MKD - Macedonian Denar", "MMK - Burmese Kyat", "MNT - Mongolian Tögrög", "MOP - Macanese Pataca", "MRU - Mauritanian Ouguiya", "MUR - Mauritian Rupee", "MVR - Maldivian Rufiyaa", "MWK - Malawian Kwacha", "MXN - Mexican Peso", "MYR - Malaysian Ringgit", "MZN - Mozambican Metical", "NAD - Namibian Dollar", "NGN - Nigerian Naira", "NIO - Nicaraguan Córdoba", "NOK - Norwegian Krone", "NPR - Nepalese Rupee", "NZD - New Zealand Dollar", "OMR - Omani Rial", "PAB - Panamanian Balboa", "PEN - Peruvian Sol", "PGK - Papua New Guinean Kina", "PHP - Philippine Peso", "PKR - Pakistani Rupee", "PLN - Polish Złoty", "PYG - Paraguayan Guaraní", "QAR - Qatari Riyal", "RON - Romanian Leu", "RSD - Serbian Dinar", "RUB - Russian Ruble", "RWF - Rwandan Franc", "SAR - Saudi Riyal", "SBD - Solomon Islands Dollar", "SCR - Seychellois Rupee", "SDG - Sudanese Pound", "SEK - Swedish Krona", "SGD - Singapore Dollar", "SHP - Saint Helena Pound", "SLE - Sierra Leonean Leone", "SOS - Somali Shilling", "SRD - Surinamese Dollar", "SSP - South Sudanese Pound", "STN - São Tomé and Príncipe Dobra", "SYP - Syrian Pound", "SZL - Eswatini Lilangeni", "THB - Thai Baht", "TJS - Tajikistani Somoni", "TMT - Turkmenistan Manat", "TND - Tunisian Dinar", "TOP - Tongan Paʻanga", "TRY - Turkish Lira", "TTD - Trinidad and Tobago Dollar", "TVD - Tuvaluan Dollar", "TWD - New Taiwan Dollar", "TZS - Tanzanian Shilling", "UAH - Ukrainian Hryvnia", "UGX - Ugandan Shilling", "USD - United States Dollar", "UYU - Uruguayan Peso", "UZS - Uzbekistani So'm", "VES - Venezuelan Bolívar Soberano", "VND - Vietnamese Đồng", "VUV - Vanuatu Vatu", "WST - Samoan Tālā", "XAF - Central African CFA Franc", "XCD - East Caribbean Dollar", "XDR - Special Drawing Rights", "XOF - West African CFA franc", "XPF - CFP Franc", "YER - Yemeni Rial", "ZAR - South African Rand", "ZMW - Zambian Kwacha", "ZWL - Zimbabwean Dollar" });
            comboBox1.Location = new Point(325, 612);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 27);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 561);
            label2.Name = "label2";
            label2.Size = new Size(52, 32);
            label2.TabIndex = 5;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 748);
            label3.MinimumSize = new Size(455, 42);
            label3.Name = "label3";
            label3.Size = new Size(455, 42);
            label3.TabIndex = 6;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newAmt
            // 
            newAmt.AutoSize = true;
            newAmt.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newAmt.ForeColor = SystemColors.ControlText;
            newAmt.Location = new Point(359, 267);
            newAmt.Name = "newAmt";
            newAmt.Size = new Size(0, 30);
            newAmt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(292, 326);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 8;
            label4.Text = "From:";
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownHeight = 200;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownWidth = 400;
            comboBox2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.Items.AddRange(new object[] { "AED - UAE Dirham", "AFN - Afghan Afghani", "ALL - Albanian Lek", "AMD - Armenian Dram", "ANG - Netherlands Antillian Guilder", "AOA - Angolan Kwanza", "ARS - Argentine Peso", "AUD - Australian Dollar", "AWG - Aruban Florin", "AZN - Azerbaijani Manat", "BAM - Bosnia and Herzegovina Mark", "BBD - Barbados Dollar", "BDT - Bangladeshi Taka", "BGN - Bulgarian Lev", "BHD - Bahraini Dinar", "BIF - Burundian Franc", "BMD - Bermudian Dollar", "BND - Brunei Dollar", "BOB - Bolivian Boliviano", "BRL - Brazilian Real", "BSD - Bahamian Dollar", "BTN - Bhutanese Ngultrum", "BWP - Botswana Pula", "BYN - Belarusian Ruble", "BZD - Belize Dollar", "CAD - Canadian Dollar", "CDF - Congolese Franc", "CHF - Swiss Franc", "CLP - Chilean Peso", "CNY - Chinese Renminbi", "COP - Colombian Peso", "CRC - Costa Rican Colon", "CUP - Cuban Peso", "CVE - Cape Verdean Escudo", "CZK - Czech Koruna", "DJF - Djiboutian Franc", "DKK - Danish Krone", "DOP - Dominican Peso", "DZD - Algerian Dinar", "EGP - Egyptian Pound", "ERN - Eritrean Nakfa", "ETB - Ethiopian Birr", "EUR - Euro", "FJD - Fiji Dollar", "FKP - Falkland Islands Pound", "FOK - Faroese Króna", "GBP - Pound Sterling", "GEL - Georgian Lari", "GGP - Guernsey Pound", "GHS - Ghanaian Cedi", "GIP - Gibraltar Pound", "GMD - Gambian Dalasi", "GNF - Guinean Franc", "GTQ - Guatemalan Quetzal", "GYD - Guyanese Dollar", "HKD - Hong Kong Dollar", "HNL - Honduran Lempira", "HRK - Croatian Kuna", "HTG - Haitian Gourde", "HUF - Hungarian Forint", "IDR - Indonesian Rupiah", "ILS - Israeli New Shekel", "IMP - Manx Pound", "INR - Indian Rupee", "IQD - Iraqi Dinar", "IRR - Iranian Rial", "ISK - Icelandic Króna", "JEP - Jersey Pound", "JMD - Jamaican Dollar", "JOD - Jordanian Dinar", "JPY - Japanese Yen", "KES - Kenyan Shilling", "KGS - Kyrgyzstani Som", "KHR - Cambodian Riel", "KID - Kiribati Dollar", "KMF - Comorian Franc", "KRW - South Korean Won", "KWD - Kuwaiti Dinar", "KYD - Cayman Islands Dollar", "KZT - Kazakhstani Tenge", "LAK - Lao Kip", "LBP - Lebanese Pound", "LKR - Sri Lanka Rupee", "LRD - Liberian Dollar", "LSL - Lesotho Loti", "LYD - Libyan Dinar", "MAD - Moroccan Dirham", "MDL - Moldovan Leu", "MGA - Malagasy Ariary", "MKD - Macedonian Denar", "MMK - Burmese Kyat", "MNT - Mongolian Tögrög", "MOP - Macanese Pataca", "MRU - Mauritanian Ouguiya", "MUR - Mauritian Rupee", "MVR - Maldivian Rufiyaa", "MWK - Malawian Kwacha", "MXN - Mexican Peso", "MYR - Malaysian Ringgit", "MZN - Mozambican Metical", "NAD - Namibian Dollar", "NGN - Nigerian Naira", "NIO - Nicaraguan Córdoba", "NOK - Norwegian Krone", "NPR - Nepalese Rupee", "NZD - New Zealand Dollar", "OMR - Omani Rial", "PAB - Panamanian Balboa", "PEN - Peruvian Sol", "PGK - Papua New Guinean Kina", "PHP - Philippine Peso", "PKR - Pakistani Rupee", "PLN - Polish Złoty", "PYG - Paraguayan Guaraní", "QAR - Qatari Riyal", "RON - Romanian Leu", "RSD - Serbian Dinar", "RUB - Russian Ruble", "RWF - Rwandan Franc", "SAR - Saudi Riyal", "SBD - Solomon Islands Dollar", "SCR - Seychellois Rupee", "SDG - Sudanese Pound", "SEK - Swedish Krona", "SGD - Singapore Dollar", "SHP - Saint Helena Pound", "SLE - Sierra Leonean Leone", "SOS - Somali Shilling", "SRD - Surinamese Dollar", "SSP - South Sudanese Pound", "STN - São Tomé and Príncipe Dobra", "SYP - Syrian Pound", "SZL - Eswatini Lilangeni", "THB - Thai Baht", "TJS - Tajikistani Somoni", "TMT - Turkmenistan Manat", "TND - Tunisian Dinar", "TOP - Tongan Paʻanga", "TRY - Turkish Lira", "TTD - Trinidad and Tobago Dollar", "TVD - Tuvaluan Dollar", "TWD - New Taiwan Dollar", "TZS - Tanzanian Shilling", "UAH - Ukrainian Hryvnia", "UGX - Ugandan Shilling", "USD - United States Dollar", "UYU - Uruguayan Peso", "UZS - Uzbekistani So'm", "VES - Venezuelan Bolívar Soberano", "VND - Vietnamese Đồng", "VUV - Vanuatu Vatu", "WST - Samoan Tālā", "XAF - Central African CFA Franc", "XCD - East Caribbean Dollar", "XDR - Special Drawing Rights", "XOF - West African CFA franc", "XPF - CFP Franc", "YER - Yemeni Rial", "ZAR - South African Rand", "ZMW - Zambian Kwacha", "ZWL - Zimbabwean Dollar" });
            comboBox2.Location = new Point(325, 377);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 27);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.ErrorImage = Properties.Resources.money_pile_11;
            pictureBox1.Image = Properties.Resources.money_pile_1;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(355, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 173);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(884, 861);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(newAmt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Label);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label newAmt;
        private Label label4;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
    }
}