using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_Compiler
{
    
    public partial class Form1 : Form
    {
        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        //Guna.UI2.WinForms.Helpers.PanelScrollHelper.VScrollBarPanelHelper VSBH;
        public Form1()
        {
            //VSBH = new Guna.UI2.WinForms.Helpers.PanelScrollHelper.VScrollBarPanelHelper(panel4, guna2VScrollBar2, true);
            InitializeComponent();
            //guna2VScrollBar2.Maximum = panel4.Width;
            //guna2VScrollBar2.LargeChange = panel4.Width; // panel which contain panelChild, and this hScrollBar will same as panel scrollbar
            //guna2VScrollBar2.Scroll += HScrollBar_Scroll;
           // VSBH.updateScrollBar();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Btn_ShowErrors_Click(object sender, EventArgs e)
        {
            if (Error_Panel.Visible)
                Error_Panel.Hide();
            else
                Error_Panel.Show();

            if (Btn_ShowErrors.Image == ((System.Drawing.Image)(resources.GetObject("Btn_ShowErrors.Image"))))
            {
                Btn_ShowErrors.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowErrors.HoverState.Image")));
            }
            else
                Btn_ShowErrors.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowErrors.Image")));

        }

        private void Btn_ShowToks_Click(object sender, EventArgs e)
        {
            if (Tok_Panel.Visible)
                Tok_Panel.Hide();
            else
                Tok_Panel.Show();
        }

        private void Btn_Compile_Click(object sender, EventArgs e)
        {
            if (Tok_Panel.Visible)
                Tok_Panel.Hide();
            if (Error_Panel.Visible)
                Error_Panel.Hide();


            //clear Tokens Table and Error List

            //do
            //{
            //    foreach (DataGridViewRow row in ToksDataGridView.Rows)
            //    {
            //        try
            //        {
            //            ToksDataGridView.Rows.Remove(row);
            //        }
            //        catch (Exception) { }
            //    }
            //} while (ToksDataGridView.Rows.Count > 1);
            ToksDataGridView.Rows.Clear();
            //ToksDataGridView.Refresh();

            panel4.Controls.Clear();

            //add tokens
            string SourceCode = SourceCodeTextBox.Text;
            Tiny_Compiler.Start_Compiling(SourceCode);
            string Lex;
            Token_Class Tok;
            for (int i = 0; i < Tiny_Compiler.TokenStream.Count; i++)
            {
                Lex = Tiny_Compiler.TokenStream[i].lex;
                Tok = Tiny_Compiler.TokenStream[i].token_type;
                ToksDataGridView.Rows.Add(Lex, Tok);

            }

            //add errors in error list
            AddErrors();

            //show TokenTable and Error List
            Tok_Panel.Show();


            //guna2VScrollBar2.Refresh();
            //guna2VScrollBar2.Update();
            Error_Panel.Show();

            ErrorsNoti.Text = Errors.Error_List.Count.ToString();
            ErrorsNoti.Visible = true;
            TokNoti.Text = Tiny_Compiler.TokenStream.Count.ToString();
            TokNoti.Visible = true;
        }


        private void AddErrors()
        {
            foreach (string error in Errors.Error_List)
                AddError(error);
            guna2VScrollBar2.Refresh();
        }

        private void AddError(string Error)
        {
            Guna.UI2.WinForms.Guna2TextBox ErroeBar = new Guna.UI2.WinForms.Guna2TextBox();
            ErroeBar.BorderRadius = 10;
            ErroeBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            ErroeBar.DefaultText = Error;
            ErroeBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            ErroeBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            ErroeBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            ErroeBar.DisabledState.Parent = ErroeBar;
            ErroeBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            ErroeBar.Dock = System.Windows.Forms.DockStyle.Top;
            ErroeBar.FillColor = System.Drawing.Color.DarkRed;
            ErroeBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ErroeBar.FocusedState.Parent = ErroeBar;
            ErroeBar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            ErroeBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ErroeBar.HoverState.Parent = ErroeBar;
            ErroeBar.Location = new System.Drawing.Point(15, 15);
            ErroeBar.Margin = new System.Windows.Forms.Padding(6);
            ErroeBar.Name = "ErroeBar";
            ErroeBar.PasswordChar = '\0';
            ErroeBar.PlaceholderText = "";
            ErroeBar.SelectedText = "";
            ErroeBar.ShadowDecoration.Parent = ErroeBar;
            ErroeBar.Size = new System.Drawing.Size(958, 25);
            ErroeBar.TabIndex = 0;
            ErroeBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ErroeBar.ReadOnly = true;
            
            panel4.Controls.Add(ErroeBar);
          
            Guna.UI2.WinForms.Guna2Separator sep = new Guna.UI2.WinForms.Guna2Separator();
            sep.Dock = System.Windows.Forms.DockStyle.Top;
            sep.FillColor = System.Drawing.Color.SeaShell;
            sep.Location = new System.Drawing.Point(15, 15);
            sep.Name = "guna2Separator1";
            sep.Size = new System.Drawing.Size(958, 10);
            sep.TabIndex = 1;
           
            panel4.Controls.Add(sep);

            

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel4_Resize(object sender, EventArgs e)
        {
            // VSBH.UpdateScrollBar();
            //guna2VScrollBar2.Refresh();
           // VSBH.updateScrollBar();

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Tok_Panel.Hide();
          
                Error_Panel.Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }



        //private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        //{
        //    int diference = e.OldValue - e.NewValue;
        //    foreach (Control c in panel4.Controls)
        //    {
        //        c.Location = new Point(c.Location.X + diference, c.Location.Y);
        //    }
        //}
    }
}
