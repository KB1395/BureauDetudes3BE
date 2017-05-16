﻿using KewLox_Forms_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KewLox_Forms
{
    public partial class Form4_Catalog2 : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public static int closetwidth;
        public static int ClosetWidth
        {
            get { return closetwidth; }
            set { closetwidth = value; }
        }
        public static int closetdepth;
        public static int Depth
        {
            get { return closetdepth; }
            set { closetdepth = value; }
        }
        public static int totalHeight;
        public static int TotalHeight
        {
            get { return totalHeight; }
            set { totalHeight = value; }
        }
        public static int boxamount;
        public static int Boxamount
        {
            get { return boxamount; }
            set { boxamount = value; }
        }
        public Form4_Catalog2()
        {
            InitializeComponent();
        }

        private void Form4_Catalog2_Load(object sender, EventArgs e)
        {

        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form(Armoire);
            frm.Show();
            Hide();
        }
        
        //To show the Basket of the Client
        private void Basket_Click(object sender, EventArgs e)
        {
            Basket_form frm = new Basket_form();
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Form3_Catalog frm = new Form3_Catalog(Armoire);
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Form5_Signup frm = new Form5_Signup();
            frm.Show();
            Hide();
        }

        // To change the color or the material of the door with button
        private void Blue_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_blue;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_green;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_yellow;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_orange;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_pink;
        }

        private void White_Click(object sender, EventArgs e)
        {
            Case.Image = Resources._case;
        }

        private void Cup_Click(object sender, EventArgs e)
        {
            Case.Image = Resources._case;
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_glass;
        }



        //To choose a material for the door with the filter
        private void Cup_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = Resources._case;
        }

        private void Glass_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = Resources.case_glass;
        }

        // To choose the number of cases in one closet
        private void closet_1case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_1case;
            Boxamount = 1;
        }

        private void closet_2case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_2case;
            Boxamount = 2;
        }

        private void closet_3case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_3case;
            Boxamount = 3;
        }

        private void closet_4case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_4case;
            Boxamount =4;
        }

        private void closet_5case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_5case;
            Boxamount = 5;
        }

        private void closet_6case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_6case;
            Boxamount = 6;
        }

        private void closet_7case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = Resources.closet_7case;
            Boxamount = 7;
        }

        //The different values of Depth
        private void D_32_Click(object sender, EventArgs e)
        {
            Depth = 32;

        }

        private void D_42_Click(object sender, EventArgs e)
        {
            Depth = 42;
        }

        private void D_52_Click(object sender, EventArgs e)
        {
            Depth = 52;
        }

        private void D_62_Click(object sender, EventArgs e)
        {
            Depth = 62;
        }


        //The different values of Width
        private void W_32_Click(object sender, EventArgs e)
        {
            ClosetWidth = 32;
        }

        private void W_42_Click(object sender, EventArgs e)
        {
            ClosetWidth = 42;
        }

        private void W_52_Click(object sender, EventArgs e)
        {
            ClosetWidth = 52;
        }

        private void W_62_Click(object sender, EventArgs e)
        {
            ClosetWidth = 62;
        }

        private void W_80_Click(object sender, EventArgs e)
        {
            ClosetWidth = 80;
        }

        private void W_100_Click(object sender, EventArgs e)
        {
            ClosetWidth = 100;
        }

        private void W_120_Click(object sender, EventArgs e)
        {
            ClosetWidth = 120;
        }


        //The total height
        private void Total_height_Click(object sender, EventArgs e)
        {
            
        }

    }
}
