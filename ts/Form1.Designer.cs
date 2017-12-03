namespace ts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.db_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt7 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt9 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt10 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt11 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt12 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.db_table);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(598, 527);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // db_table
            // 
            this.db_table.AllowUserToAddRows = false;
            this.db_table.AllowUserToDeleteRows = false;
            this.db_table.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.db_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.db_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.db_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.db_table.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.db_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_table.DoubleBuffered = true;
            this.db_table.EnableHeadersVisualStyles = false;
            this.db_table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.db_table.HeaderForeColor = System.Drawing.Color.White;
            this.db_table.Location = new System.Drawing.Point(3, 54);
            this.db_table.Name = "db_table";
            this.db_table.ReadOnly = true;
            this.db_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.db_table.Size = new System.Drawing.Size(590, 461);
            this.db_table.TabIndex = 0;
            this.db_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_table_CellContentClick);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.HintForeColor = System.Drawing.Color.White;
            this.txt.HintText = "";
            this.txt.isPassword = false;
            this.txt.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt.LineIdleColor = System.Drawing.Color.Gray;
            this.txt.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt.LineThickness = 3;
            this.txt.Location = new System.Drawing.Point(676, 37);
            this.txt.Margin = new System.Windows.Forms.Padding(4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(325, 33);
            this.txt.TabIndex = 1;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt2.ForeColor = System.Drawing.Color.White;
            this.txt2.HintForeColor = System.Drawing.Color.White;
            this.txt2.HintText = "";
            this.txt2.isPassword = false;
            this.txt2.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt2.LineIdleColor = System.Drawing.Color.Gray;
            this.txt2.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt2.LineThickness = 3;
            this.txt2.Location = new System.Drawing.Point(676, 77);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(325, 33);
            this.txt2.TabIndex = 2;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt3.ForeColor = System.Drawing.Color.White;
            this.txt3.HintForeColor = System.Drawing.Color.White;
            this.txt3.HintText = "";
            this.txt3.isPassword = false;
            this.txt3.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt3.LineIdleColor = System.Drawing.Color.Gray;
            this.txt3.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt3.LineThickness = 3;
            this.txt3.Location = new System.Drawing.Point(676, 118);
            this.txt3.Margin = new System.Windows.Forms.Padding(4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(325, 33);
            this.txt3.TabIndex = 3;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt4.ForeColor = System.Drawing.Color.White;
            this.txt4.HintForeColor = System.Drawing.Color.White;
            this.txt4.HintText = "";
            this.txt4.isPassword = false;
            this.txt4.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt4.LineIdleColor = System.Drawing.Color.Gray;
            this.txt4.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt4.LineThickness = 3;
            this.txt4.Location = new System.Drawing.Point(676, 159);
            this.txt4.Margin = new System.Windows.Forms.Padding(4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(325, 33);
            this.txt4.TabIndex = 4;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt5.ForeColor = System.Drawing.Color.White;
            this.txt5.HintForeColor = System.Drawing.Color.White;
            this.txt5.HintText = "";
            this.txt5.isPassword = false;
            this.txt5.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt5.LineIdleColor = System.Drawing.Color.Gray;
            this.txt5.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt5.LineThickness = 3;
            this.txt5.Location = new System.Drawing.Point(676, 200);
            this.txt5.Margin = new System.Windows.Forms.Padding(4);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(325, 33);
            this.txt5.TabIndex = 5;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt6.ForeColor = System.Drawing.Color.White;
            this.txt6.HintForeColor = System.Drawing.Color.White;
            this.txt6.HintText = "";
            this.txt6.isPassword = false;
            this.txt6.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt6.LineIdleColor = System.Drawing.Color.Gray;
            this.txt6.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt6.LineThickness = 3;
            this.txt6.Location = new System.Drawing.Point(676, 241);
            this.txt6.Margin = new System.Windows.Forms.Padding(4);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(325, 33);
            this.txt6.TabIndex = 6;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt7.ForeColor = System.Drawing.Color.White;
            this.txt7.HintForeColor = System.Drawing.Color.White;
            this.txt7.HintText = "";
            this.txt7.isPassword = false;
            this.txt7.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt7.LineIdleColor = System.Drawing.Color.Gray;
            this.txt7.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt7.LineThickness = 3;
            this.txt7.Location = new System.Drawing.Point(676, 282);
            this.txt7.Margin = new System.Windows.Forms.Padding(4);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(325, 33);
            this.txt7.TabIndex = 7;
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt8
            // 
            this.txt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt8.ForeColor = System.Drawing.Color.White;
            this.txt8.HintForeColor = System.Drawing.Color.White;
            this.txt8.HintText = "";
            this.txt8.isPassword = false;
            this.txt8.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt8.LineIdleColor = System.Drawing.Color.Gray;
            this.txt8.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt8.LineThickness = 3;
            this.txt8.Location = new System.Drawing.Point(676, 323);
            this.txt8.Margin = new System.Windows.Forms.Padding(4);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(325, 33);
            this.txt8.TabIndex = 8;
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt9
            // 
            this.txt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt9.ForeColor = System.Drawing.Color.White;
            this.txt9.HintForeColor = System.Drawing.Color.White;
            this.txt9.HintText = "";
            this.txt9.isPassword = false;
            this.txt9.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt9.LineIdleColor = System.Drawing.Color.Gray;
            this.txt9.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt9.LineThickness = 3;
            this.txt9.Location = new System.Drawing.Point(676, 364);
            this.txt9.Margin = new System.Windows.Forms.Padding(4);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(325, 33);
            this.txt9.TabIndex = 9;
            this.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt10
            // 
            this.txt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt10.ForeColor = System.Drawing.Color.White;
            this.txt10.HintForeColor = System.Drawing.Color.White;
            this.txt10.HintText = "";
            this.txt10.isPassword = false;
            this.txt10.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt10.LineIdleColor = System.Drawing.Color.Gray;
            this.txt10.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt10.LineThickness = 3;
            this.txt10.Location = new System.Drawing.Point(676, 405);
            this.txt10.Margin = new System.Windows.Forms.Padding(4);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(325, 33);
            this.txt10.TabIndex = 10;
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt11
            // 
            this.txt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt11.ForeColor = System.Drawing.Color.White;
            this.txt11.HintForeColor = System.Drawing.Color.White;
            this.txt11.HintText = "";
            this.txt11.isPassword = false;
            this.txt11.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt11.LineIdleColor = System.Drawing.Color.Gray;
            this.txt11.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt11.LineThickness = 3;
            this.txt11.Location = new System.Drawing.Point(676, 446);
            this.txt11.Margin = new System.Windows.Forms.Padding(4);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(325, 33);
            this.txt11.TabIndex = 11;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt12
            // 
            this.txt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt12.ForeColor = System.Drawing.Color.White;
            this.txt12.HintForeColor = System.Drawing.Color.White;
            this.txt12.HintText = "";
            this.txt12.isPassword = false;
            this.txt12.LineFocusedColor = System.Drawing.Color.Aqua;
            this.txt12.LineIdleColor = System.Drawing.Color.Gray;
            this.txt12.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txt12.LineThickness = 3;
            this.txt12.Location = new System.Drawing.Point(676, 487);
            this.txt12.Margin = new System.Windows.Forms.Padding(4);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(325, 33);
            this.txt12.TabIndex = 12;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(603, 453);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(71, 26);
            this.bunifuCustomLabel11.TabIndex = 32;
            this.bunifuCustomLabel11.Text = "Объем \r\nвидеокарты:";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(603, 425);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel10.TabIndex = 31;
            this.bunifuCustomLabel10.Text = "Видеокарта:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(604, 371);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(45, 26);
            this.bunifuCustomLabel9.TabIndex = 30;
            this.bunifuCustomLabel9.Text = "Объем \r\nдиска:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(604, 330);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(52, 26);
            this.bunifuCustomLabel8.TabIndex = 29;
            this.bunifuCustomLabel8.Text = "Частота \r\nпамяти:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(603, 289);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(47, 26);
            this.bunifuCustomLabel7.TabIndex = 28;
            this.bunifuCustomLabel7.Text = "Объем \r\nпамяти:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(603, 248);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(47, 26);
            this.bunifuCustomLabel6.TabIndex = 27;
            this.bunifuCustomLabel6.Text = "Тип \r\nпамяти:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(603, 207);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(47, 26);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Форм\r\nфактор:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(603, 179);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel4.TabIndex = 25;
            this.bunifuCustomLabel4.Text = "Сокет:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(600, 125);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 26);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "Количество \r\nядер:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(599, 84);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 26);
            this.bunifuCustomLabel2.TabIndex = 23;
            this.bunifuCustomLabel2.Text = "Частота \r\nпроцессора:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(600, 54);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Процессор:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(599, 11);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(176, 24);
            this.bunifuCustomLabel12.TabIndex = 33;
            this.bunifuCustomLabel12.Text = "Характеристики:";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(604, 494);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(51, 26);
            this.bunifuCustomLabel13.TabIndex = 34;
            this.bunifuCustomLabel13.Text = "Блок \r\nпитания:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ts.Properties.Resources.power2;
            this.pictureBox1.Location = new System.Drawing.Point(976, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.db_table;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1014, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomDataGrid db_table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

