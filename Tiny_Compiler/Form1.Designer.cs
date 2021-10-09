namespace Tiny_Compiler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SourceCodeTextBox = new System.Windows.Forms.RichTextBox();
            this.Tok_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2VScrollBar3 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.ToksDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Error_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2HScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Btn_ShowToks = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_Compile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_ShowErrors = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ErrorsNoti = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.TokNoti = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.Tok_Panel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToksDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.Error_Panel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.guna2ImageButton2);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 557);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.HoverState.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton2.Location = new System.Drawing.Point(891, 10);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(49, 42);
            this.guna2ImageButton2.TabIndex = 2;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click_1);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(940, 10);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 51);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guna2HScrollBar1);
            this.panel2.Controls.Add(this.guna2VScrollBar1);
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 487);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Panel1);
            this.panel3.Controls.Add(this.Tok_Panel);
            this.panel3.Controls.Add(this.Error_Panel);
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 444);
            this.panel3.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.SourceCodeTextBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(471, 292);
            this.guna2Panel1.TabIndex = 3;
            // 
            // SourceCodeTextBox
            // 
            this.SourceCodeTextBox.AcceptsTab = true;
            this.SourceCodeTextBox.BackColor = System.Drawing.Color.White;
            this.SourceCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.SourceCodeTextBox.Location = new System.Drawing.Point(0, 0);
            this.SourceCodeTextBox.Name = "SourceCodeTextBox";
            this.SourceCodeTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SourceCodeTextBox.Size = new System.Drawing.Size(471, 292);
            this.SourceCodeTextBox.TabIndex = 0;
            this.SourceCodeTextBox.Text = "";
            this.SourceCodeTextBox.WordWrap = false;
            this.SourceCodeTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Tok_Panel
            // 
            this.Tok_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Tok_Panel.BorderColor = System.Drawing.Color.White;
            this.Tok_Panel.BorderRadius = 20;
            this.Tok_Panel.Controls.Add(this.panel6);
            this.Tok_Panel.Controls.Add(this.panel5);
            this.Tok_Panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tok_Panel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.Tok_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tok_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Tok_Panel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Tok_Panel.Location = new System.Drawing.Point(471, 0);
            this.Tok_Panel.Name = "Tok_Panel";
            this.Tok_Panel.Padding = new System.Windows.Forms.Padding(15);
            this.Tok_Panel.ShadowDecoration.Parent = this.Tok_Panel;
            this.Tok_Panel.Size = new System.Drawing.Size(517, 292);
            this.Tok_Panel.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.guna2VScrollBar3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(490, 15);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 35, 0, 20);
            this.panel6.Size = new System.Drawing.Size(12, 262);
            this.panel6.TabIndex = 2;
            // 
            // guna2VScrollBar3
            // 
            this.guna2VScrollBar3.AutoRoundedCorners = true;
            this.guna2VScrollBar3.BindingContainer = this.ToksDataGridView;
            this.guna2VScrollBar3.BorderColor = System.Drawing.Color.Black;
            this.guna2VScrollBar3.BorderRadius = 5;
            this.guna2VScrollBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VScrollBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2VScrollBar3.HoverState.Parent = null;
            this.guna2VScrollBar3.LargeChange = 1;
            this.guna2VScrollBar3.Location = new System.Drawing.Point(0, 35);
            this.guna2VScrollBar3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2VScrollBar3.Maximum = 1;
            this.guna2VScrollBar3.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar3.Name = "guna2VScrollBar3";
            this.guna2VScrollBar3.PressedState.Parent = this.guna2VScrollBar3;
            this.guna2VScrollBar3.ScrollbarSize = 12;
            this.guna2VScrollBar3.Size = new System.Drawing.Size(12, 207);
            this.guna2VScrollBar3.TabIndex = 4;
            this.guna2VScrollBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2VScrollBar3.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // ToksDataGridView
            // 
            this.ToksDataGridView.AllowUserToAddRows = false;
            this.ToksDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ToksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ToksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ToksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ToksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ToksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ToksDataGridView.ColumnHeadersHeight = 19;
            this.ToksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexeme,
            this.Token});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ToksDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ToksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToksDataGridView.EnableHeadersVisualStyles = false;
            this.ToksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(108)))));
            this.ToksDataGridView.Location = new System.Drawing.Point(4, 4);
            this.ToksDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ToksDataGridView.Name = "ToksDataGridView";
            this.ToksDataGridView.ReadOnly = true;
            this.ToksDataGridView.RowHeadersVisible = false;
            this.ToksDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ToksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ToksDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ToksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToksDataGridView.Size = new System.Drawing.Size(468, 254);
            this.ToksDataGridView.TabIndex = 0;
            this.ToksDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ToksDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ToksDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ToksDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ToksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ToksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ToksDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ToksDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(108)))));
            this.ToksDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ToksDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ToksDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToksDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ToksDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ToksDataGridView.ThemeStyle.HeaderStyle.Height = 19;
            this.ToksDataGridView.ThemeStyle.ReadOnly = true;
            this.ToksDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ToksDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ToksDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToksDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToksDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ToksDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ToksDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Lexeme
            // 
            this.Lexeme.HeaderText = "Lexeme";
            this.Lexeme.MinimumWidth = 6;
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.ReadOnly = true;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ToksDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4, 4, 15, 4);
            this.panel5.Size = new System.Drawing.Size(487, 262);
            this.panel5.TabIndex = 1;
            // 
            // Error_Panel
            // 
            this.Error_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Error_Panel.BorderColor = System.Drawing.Color.White;
            this.Error_Panel.BorderRadius = 20;
            this.Error_Panel.Controls.Add(this.guna2VScrollBar2);
            this.Error_Panel.Controls.Add(this.panel4);
            this.Error_Panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Error_Panel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.Error_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Error_Panel.Location = new System.Drawing.Point(0, 292);
            this.Error_Panel.Name = "Error_Panel";
            this.Error_Panel.Padding = new System.Windows.Forms.Padding(15);
            this.Error_Panel.ShadowDecoration.BorderRadius = 64;
            this.Error_Panel.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Error_Panel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Error_Panel.ShadowDecoration.Parent = this.Error_Panel;
            this.Error_Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(77);
            this.Error_Panel.Size = new System.Drawing.Size(988, 152);
            this.Error_Panel.TabIndex = 1;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.AutoRoundedCorners = true;
            this.guna2VScrollBar2.BindingContainer = this.panel4;
            this.guna2VScrollBar2.BorderColor = System.Drawing.Color.Black;
            this.guna2VScrollBar2.BorderRadius = 4;
            this.guna2VScrollBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2VScrollBar2.HoverState.Parent = null;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(962, 15);
            this.guna2VScrollBar2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2VScrollBar2.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.PressedState.Parent = this.guna2VScrollBar2;
            this.guna2VScrollBar2.ScrollbarSize = 11;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(11, 122);
            this.guna2VScrollBar2.TabIndex = 4;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // panel4
            // 
            this.panel4.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel4.Size = new System.Drawing.Size(958, 122);
            this.panel4.TabIndex = 5;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // guna2HScrollBar1
            // 
            this.guna2HScrollBar1.AutoRoundedCorners = true;
            this.guna2HScrollBar1.BindingContainer = this.SourceCodeTextBox;
            this.guna2HScrollBar1.BorderRadius = 4;
            this.guna2HScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2HScrollBar1.HoverState.Parent = null;
            this.guna2HScrollBar1.LargeChange = 492;
            this.guna2HScrollBar1.Location = new System.Drawing.Point(487, 473);
            this.guna2HScrollBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HScrollBar1.Maximum = 1000;
            this.guna2HScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2HScrollBar1.Name = "guna2HScrollBar1";
            this.guna2HScrollBar1.PressedState.Parent = this.guna2HScrollBar1;
            this.guna2HScrollBar1.ScrollbarSize = 10;
            this.guna2HScrollBar1.Size = new System.Drawing.Size(493, 10);
            this.guna2HScrollBar1.SmallChange = 21;
            this.guna2HScrollBar1.TabIndex = 2;
            this.guna2HScrollBar1.ThumbColor = System.Drawing.Color.Black;
            this.guna2HScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.guna2HScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2HScrollBar1_Scroll);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.SourceCodeTextBox;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Black;
            this.guna2VScrollBar1.BorderRadius = 4;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.LargeChange = 271;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(995, 212);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2VScrollBar1.Maximum = 2000;
            this.guna2VScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 11;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(11, 246);
            this.guna2VScrollBar1.SmallChange = 21;
            this.guna2VScrollBar1.TabIndex = 1;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_ShowToks);
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_Compile);
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_ShowErrors);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(186, -1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(595, 62);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // Btn_ShowToks
            // 
            this.Btn_ShowToks.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ShowToks.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowToks.CheckedState.Parent = this.Btn_ShowToks;
            this.Btn_ShowToks.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowToks.HoverState.Image")));
            this.Btn_ShowToks.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.Btn_ShowToks.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_ShowToks.HoverState.Parent = this.Btn_ShowToks;
            this.Btn_ShowToks.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowToks.Image")));
            this.Btn_ShowToks.ImageRotate = 0F;
            this.Btn_ShowToks.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_ShowToks.Location = new System.Drawing.Point(133, 10);
            this.Btn_ShowToks.Name = "Btn_ShowToks";
            this.Btn_ShowToks.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowToks.PressedState.Parent = this.Btn_ShowToks;
            this.Btn_ShowToks.Size = new System.Drawing.Size(52, 43);
            this.Btn_ShowToks.TabIndex = 0;
            this.Btn_ShowToks.Click += new System.EventHandler(this.Btn_ShowToks_Click);
            // 
            // Btn_Compile
            // 
            this.Btn_Compile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Compile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_Compile.CheckedState.Parent = this.Btn_Compile;
            this.Btn_Compile.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Compile.HoverState.Image")));
            this.Btn_Compile.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.Btn_Compile.HoverState.ImageRotate = 20F;
            this.Btn_Compile.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_Compile.HoverState.Parent = this.Btn_Compile;
            this.Btn_Compile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Compile.Image")));
            this.Btn_Compile.ImageRotate = 0F;
            this.Btn_Compile.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Compile.Location = new System.Drawing.Point(258, 10);
            this.Btn_Compile.Name = "Btn_Compile";
            this.Btn_Compile.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_Compile.PressedState.Parent = this.Btn_Compile;
            this.Btn_Compile.Size = new System.Drawing.Size(56, 43);
            this.Btn_Compile.TabIndex = 0;
            this.Btn_Compile.Click += new System.EventHandler(this.Btn_Compile_Click);
            // 
            // Btn_ShowErrors
            // 
            this.Btn_ShowErrors.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ShowErrors.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowErrors.CheckedState.Parent = this.Btn_ShowErrors;
            this.Btn_ShowErrors.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowErrors.HoverState.Image")));
            this.Btn_ShowErrors.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_ShowErrors.HoverState.Parent = this.Btn_ShowErrors;
            this.Btn_ShowErrors.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowErrors.Image")));
            this.Btn_ShowErrors.ImageRotate = 0F;
            this.Btn_ShowErrors.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_ShowErrors.Location = new System.Drawing.Point(393, 6);
            this.Btn_ShowErrors.Name = "Btn_ShowErrors";
            this.Btn_ShowErrors.PressedState.Parent = this.Btn_ShowErrors;
            this.Btn_ShowErrors.Size = new System.Drawing.Size(64, 49);
            this.Btn_ShowErrors.TabIndex = 0;
            this.Btn_ShowErrors.Click += new System.EventHandler(this.Btn_ShowErrors_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 54;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 55;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 55;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // ErrorsNoti
            // 
            this.ErrorsNoti.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ErrorsNoti.BorderRadius = 6;
            this.ErrorsNoti.BorderThickness = 0;
            this.ErrorsNoti.FillColor = System.Drawing.Color.Red;
            this.ErrorsNoti.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ErrorsNoti.Location = new System.Drawing.Point(10, 3);
            this.ErrorsNoti.Size = new System.Drawing.Size(19, 19);
            this.ErrorsNoti.TargetControl = this.Btn_ShowErrors;
            this.ErrorsNoti.Visible = false;
            // 
            // TokNoti
            // 
            this.TokNoti.BorderRadius = 6;
            this.TokNoti.BorderThickness = 0;
            this.TokNoti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TokNoti.Size = new System.Drawing.Size(19, 19);
            this.TokNoti.TargetControl = this.Btn_ShowToks;
            this.TokNoti.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1032, 571);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.Tok_Panel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToksDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.Error_Panel.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_ShowErrors;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_ShowToks;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_Compile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox SourceCodeTextBox;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2HScrollBar1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel Tok_Panel;
        private Guna.UI2.WinForms.Guna2Panel Error_Panel;
        private Guna.UI2.WinForms.Guna2DataGridView ToksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2NotificationPaint ErrorsNoti;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NotificationPaint TokNoti;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar3;
        private System.Windows.Forms.Panel panel5;
    }
}

