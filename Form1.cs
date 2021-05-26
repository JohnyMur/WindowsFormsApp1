using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        //private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7,60);
            //panelMain.Controls.Add(leftBorderBtn);
            customizeDesing();
            #region Убрать верхнюю панель
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            #endregion
            NowTimeInfo();
            JsonOperations.ReadJsonMenyaNames("MenueNames_Jason.json", Lists.MenuaName_list);
            JsonOperations.ReadJsonMenueFoodPositions("MenueFood_Positions_Jason.json", Lists.FoodPositions_list);

        }
        private void ActivateButton(object senderBtn)// private void ActivateButton(object senderBtn, Color color)
        {
            if( senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(255, 190, 0);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(255, 190, 0);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(255, 190, 0);
                
              titleCurrentChildForm.ForeColor = Color.FromArgb(255, 190, 0);
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 190, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //private struct RGBColors
        //{
        //    public static Color color1 =Color.FromArgb(172,126,241);
        //    public static Color color2 =Color.FromArgb(249,118,176);
        //    public static Color color3 =Color.FromArgb(253,138,114);
        //    public static Color color4 =Color.FromArgb(95,77,221);
           
        //}
        
        private void subOrderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizeDesing()
        {
        subMenuePanel.Visible = false;
        subOrderPanel.Visible = false;
        subSetPanel.Visible = false;
        }
        private void hideSubMenue()
        {
        if (subMenuePanel.Visible == true) { subMenuePanel.Visible = false; }
        if (subOrderPanel.Visible == true) { subOrderPanel.Visible = false; }
        if (subSetPanel.Visible == true) { subSetPanel.Visible = false; }
        }
        private void showSubMenue(Panel subMenue)
        {
            if (subMenue.Visible == false)
            {
                hideSubMenue();
                subMenue.Visible = true;
            }
            else
            {
                subMenue.Visible = false;
            }
        }
        private void btnMenue_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenue(subMenuePanel);
        }
        #region SubMunue

        private void btnMenue1_Click_1(object sender, EventArgs e)
        {

            Lists.ListForOrdering.Clear();
            OrderingOperations.MenueFoodCategoryChois = "Горячее";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());


        }
        private void btnMenue2_Click(object sender, EventArgs e)
        {
            Lists.ListForOrdering.Clear();
            
            OrderingOperations.MenueFoodCategoryChois = "Гарнир";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());
        }
        private void btnMenue3_Click(object sender, EventArgs e)
        {
            Lists.ListForOrdering.Clear();
            
            OrderingOperations.MenueFoodCategoryChois = "Супы";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());
        }
        private void btnMenue4_Click_1(object sender, EventArgs e)
        {
            Lists.ListForOrdering.Clear();
            
            OrderingOperations.MenueFoodCategoryChois = "Салаты";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());
        }
        private void btnMenue5_Click(object sender, EventArgs e)
        {
            Lists.ListForOrdering.Clear();
            
            OrderingOperations.MenueFoodCategoryChois = "Напитки";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());
        }
        private void btnMenue6_Click(object sender, EventArgs e)
        {
            Lists.ListForOrdering.Clear();
            
            OrderingOperations.MenueFoodCategoryChois = "Десерты";
            OrderingOperations.CheckChoiceOfMenu(OrderingOperations.MenuChois);
            OpenChildForm(new Form_Ordering());
        }





        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenue(subOrderPanel);
        }
        #region SubOrder
        private void btnOrder1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyOrder());
    
        }
        private void btnOrder2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnSetMenue_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenue(subSetPanel);
            
        }
        #region SubSetMenue
        private void btnSet1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Create_Menue());

        }
        private void btnSet2_Click_1(object sender, EventArgs e)
        {
            //hideSubMenue();
            OpenChildForm(new Create_Position());
        }
        private void btnSet3_Click(object sender, EventArgs e)
        {

        }
        private void btnSet4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Chois());
        }

        #endregion

        private void btnMap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hideSubMenue();
            OpenChildForm(new FormMap());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
           
        }
        #region Сброс Home
        private void Reset()
        { 
            DisableButton();
            hideSubMenue();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            titleCurrentChildForm.Text = "Home";
            titleCurrentChildForm.ForeColor = Color.White;
        }
#endregion
        #region Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Создание ChildForm

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleCurrentChildForm.Text = currentBtn.Text;
        }
#endregion
        #region Time/Date
        private void NowTimeInfo()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            void timer_Tick(object sender, EventArgs e)
            {
                //InfoTime.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
                InfoTime.Text = DateTime.Now.ToString("HH.mm.ss", CultureInfo.CreateSpecificCulture("en-US"));
                InfoDate.Text = DateTime.Now.ToString("MMMM.dd.yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            }

        }









        #endregion

       
    }

}
