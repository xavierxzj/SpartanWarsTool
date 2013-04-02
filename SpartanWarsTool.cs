using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpartanWarsTool.dbOperate;

namespace SpartanWarsTool
{
    public partial class SpartanWarsTool : Form
    {
        public SpartanWarsTool()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            cbBoxDif.SelectedIndex = 0;
            cbBoxLayer.Text = "选择层";
            InitControls();
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            cbBoxSoldier1.Items.Clear();
            cbBoxSoldier2.Items.Clear();
            cbBoxSoldier3.Items.Clear();
            cbBoxSoldier1.Text = "选择兵种";
            cbBoxSoldier2.Text = "选择兵种";
            cbBoxSoldier3.Text = "选择兵种";
            cbBoxSoldier1.Tag = "1";
            cbBoxSoldier2.Tag = "2";
            cbBoxSoldier3.Tag = "3";
            txtBoxPower1.Text = "0";
            txtBoxPower2.Text = "0";
            txtBoxPower3.Text = "0";
            txtBoxPower4.Text = "0";
            txtBoxPower5.Text = "0";
            txtBoxPower6.Text = "0";
            txtBoxPower7.Text = "0";
            initCalPower();
            cbBoxSoldier1.Enabled = false;
            cbBoxSoldier2.Enabled = false;
            cbBoxSoldier3.Enabled = false;

            txtBox_sword.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_spear.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_ax.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_bow.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_infantry.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_ride.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_godadd_infantry.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_godadd_bow.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_godadd_ride.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_morale.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBox_satisfy.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower1.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower2.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower3.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower4.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower5.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower6.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxPower7.GotFocus += new EventHandler(txtBox_GotFocus);
            txtBoxSelfPower.GotFocus += new EventHandler(txtBox_GotFocus);

            txtBox_sword.Tag = false;
            txtBox_spear.Tag = false;
            txtBox_ax.Tag = false;
            txtBox_bow.Tag = false;
            txtBox_infantry.Tag = false;
            txtBox_ride.Tag = false;
            txtBox_godadd_infantry.Tag = false;
            txtBox_godadd_bow.Tag = false;
            txtBox_godadd_ride.Tag = false;
            txtBox_morale.Tag = false;
            txtBoxPower1.Tag = false;
            txtBoxPower2.Tag = false;
            txtBoxPower3.Tag = false;
            txtBoxPower4.Tag = false;
            txtBoxPower5.Tag = false;
            txtBoxPower6.Tag = false;
            txtBoxPower7.Tag = false;
            txtBoxSelfPower.Tag = false;

            txtBox_sword.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_spear.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_ax.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_bow.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_infantry.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_ride.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_godadd_infantry.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_godadd_bow.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_godadd_ride.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_morale.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBox_satisfy.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower1.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower2.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower3.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower4.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower5.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower6.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxPower7.MouseUp += new MouseEventHandler(txtBox_MouseUp);
            txtBoxSelfPower.MouseUp += new MouseEventHandler(txtBox_MouseUp);

        }

        /// <summary>
        /// 文本框获取焦点时全选其中的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.Tag = true;
            txtBox.SelectAll();
        }

        /// <summary>
        /// 鼠标抬起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (e.Button == MouseButtons.Left && (bool)txtBox.Tag == true)
            {
                txtBox.SelectAll();
            }
            txtBox.Tag = false;
        }

        /// <summary>
        /// 初始化无损值
        /// </summary>
        private void initCalPower()
        {
            txtBoxNPower1.Text = "";
            txtBoxNPower2.Text = "";
            txtBoxNPower3.Text = "";
            txtBoxNPower4.Text = "";
            txtBoxNPower5.Text = "";
            txtBoxNPower6.Text = "";
            txtBoxNPower7.Text = "";
            txtBoxDPower1.Text = "";
            txtBoxDPower2.Text = "";
            txtBoxDPower3.Text = "";
            txtBoxDPower4.Text = "";
            txtBoxDPower5.Text = "";
            txtBoxDPower6.Text = "";
            txtBoxDPower7.Text = "";
        }

        /// <summary>
        /// 输入框的回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox current_txtBox = (TextBox)sender;
            string txtBoxName = current_txtBox.Name;
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBoxCheck())
                {
                    MessageBox.Show("输入框内容必须为数字，且大于等于0");
                    current_txtBox.Text = "0";
                    return;
                }
                double satisfiction;
                double morale;
                satisfiction = double.Parse(txtBox_satisfy.Text);
                morale = double.Parse(txtBox_morale.Text);
                if (satisfiction < 4500 || morale < 4500)
                {
                    MessageBox.Show("满意度或士气值低于4500完全就是去送死！");
                    current_txtBox.Text = "9000";
                    return;
                }

                calculatePower();

                switch (txtBoxName)
                {
                    case "txtBox_sword": txtBox_spear.Focus();
                        break;
                    case "txtBox_spear": txtBox_ax.Focus();
                        break;
                    case "txtBox_ax": txtBox_infantry.Focus();
                        break;
                    case "txtBox_infantry": txtBox_bow.Focus();
                        break;
                    case "txtBox_bow": txtBox_ride.Focus();
                        break;
                    case "txtBox_ride": txtBox_godadd_infantry.Focus();
                        break;
                    case "txtBox_godadd_infantry": txtBox_godadd_bow.Focus();
                        break;
                    case "txtBox_godadd_bow": txtBox_godadd_ride.Focus();
                        break;
                    case "txtBox_godadd_ride": txtBox_satisfy.Focus();
                        break;
                    case "txtBox_satisfy": txtBox_morale.Focus();
                        break;
                    case "txtBox_morale": txtBox_sword.Focus();
                        break;
                    case "txtBoxPower1": txtBoxPower2.Focus();
                        break;
                    case "txtBoxPower2": txtBoxPower3.Focus();
                        break;
                    case "txtBoxPower3": txtBoxPower4.Focus();
                        break;
                    case "txtBoxPower4": txtBoxPower5.Focus();
                        break;
                    case "txtBoxPower5": txtBoxPower6.Focus();
                        break;
                    case "txtBoxPower6": txtBoxPower7.Focus();
                        break;
                    case "txtBoxPower7": txtBoxPower1.Focus();
                        break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// 计算无损核心算法(排斥法)
        /// </summary>
        private void calculatePower()
        {
            initCalPower();
            //满意度和士气值在4500-9000之间分为3个档次，4500-5000为一档，5001-6000为一档，6001-8000为一档，8001-9000为一档，加成分别为0.00,0.01,0.03,0.05
            double satisfiction;
            double morale;
            satisfiction = double.Parse(txtBox_satisfy.Text);
            morale = double.Parse(txtBox_morale.Text);

            //满意度加成
            if (satisfiction >= 4500 && satisfiction <= 5000)
            {
                satisfiction = 0;
            }
            else if (satisfiction >= 5001 && satisfiction <= 6000)
            {
                satisfiction = 0.01;
            }
            else if (satisfiction >= 6001 && satisfiction <= 8000)
            {
                satisfiction = 0.03;
            }
            else if (satisfiction >= 8001)
            {
                satisfiction = 0.05;
            }

            //士气值加成
            if (morale >= 4500 && morale <= 5000)
            {
                morale = 0;
            }
            else if (morale >= 5001 && morale <= 6000)
            {
                morale = 0.01;
            }
            else if (morale >= 6001 && morale <= 8000)
            {
                morale = 0.03;
            }
            else if (morale >= 8001)
            {
                morale = 0.05;
            }

            double satisAndMorale = satisfiction + morale;


            //科技神满意度加成(其它一级1%，弓一级2%)
            double tec_sword = double.Parse(txtBox_sword.Text) / 100;
            double tec_spear = double.Parse(txtBox_spear.Text) / 100;
            double tec_ax = double.Parse(txtBox_ax.Text) / 100;
            double tec_infantry = double.Parse(txtBox_infantry.Text) / 100;
            double tec_bow = double.Parse(txtBox_bow.Text) * 2 / 100;
            double tec_ride = double.Parse(txtBox_ride.Text) / 100;
            double god_bow = double.Parse(txtBox_godadd_bow.Text);
            double god_infantry = double.Parse(txtBox_godadd_infantry.Text);
            double god_ride = double.Parse(txtBox_godadd_ride.Text);


            //兵力数量
            int c_sword_infantry = int.Parse(txtBoxPower1.Text);
            int c_spear_infantry = int.Parse(txtBoxPower2.Text);
            int c_ax_infantry = int.Parse(txtBoxPower3.Text); ;
            int c_bow = int.Parse(txtBoxPower4.Text); ;
            int c_sword_ride = int.Parse(txtBoxPower5.Text); ;
            int c_spear_ride = int.Parse(txtBoxPower6.Text); ;
            int c_ax_ride = int.Parse(txtBoxPower7.Text); ;

            //单位战力
            double unitTotalPower_infantry_sword = SpartanConst.UnitPower.INFANTRY_SWORD * (1 + satisfiction + morale + tec_sword + tec_infantry) + god_infantry; ;
            double unitTotalPower_infantry_spear = SpartanConst.UnitPower.INFANTRY_SPEAR * (1 + satisfiction + morale + tec_spear + tec_infantry) + god_infantry; ;
            double unitTotalPower_infantry_ax = SpartanConst.UnitPower.INFANTRY_AX * (1 + satisfiction + morale + tec_ax + tec_infantry) + god_infantry;
            double unitTotalPower_bow = SpartanConst.UnitPower.BOW * (1 + satisfiction + morale + tec_bow) + god_bow;
            double unitTotalPower_ride_sword = SpartanConst.UnitPower.RIDE_SWORD * (1 + satisfiction + morale + tec_sword + tec_ride) + god_ride;
            double unitTotalPower_ride_spear = SpartanConst.UnitPower.RIDE_SPEAR * (1 + satisfiction + morale + tec_spear + tec_ride) + god_ride;
            double unitTotalPower_ride_ax = SpartanConst.UnitPower.RIDE_AX * (1 + satisfiction + morale + tec_ax + tec_ride) + god_ride;

            //无损所需兵力过渡变量
            int c_need_n;
            int c_need_d;

            //无损兵力数组
            int[] c_need_normal = new int[7];
            int[] c_need_double = new int[7];
            //初始化兵力
            for (int i = 0; i < 7; i++)
            {
                c_need_normal[i] = -1;
                c_need_double[i] = -1;
            }

            //敌军总战力
            double enemyPower;
            //暴击战力
            double dEnemyPower;

            //列举敌对7种兵可出的兵种及相应数量
            //剑步
            if (c_sword_infantry > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[0] = 0;
                c_need_normal[2] = 0;
                c_need_normal[4] = 0;
                c_need_normal[6] = 0;
                c_need_double[0] = 0;
                c_need_double[2] = 0;
                c_need_double[4] = 0;
                c_need_double[6] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_SWORD * c_sword_infantry;
                //矛步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_spear)));
                if (c_need_normal[1] == -1 || (c_need_normal[1] < c_need_n && c_need_normal[1] != 0))
                {
                    c_need_normal[1] = c_need_n;
                    c_need_double[1] = c_need_n;
                }
                //矛骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_spear)));
                if (c_need_normal[5] == -1 || c_need_normal[5] < c_need_n && c_need_normal[5] != 0)
                {
                    c_need_normal[5] = c_need_n;
                    c_need_double[5] = c_need_n;
                }
                //弓
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                if (c_need_normal[3] == -1 || (c_need_normal[3] < c_need_n && c_need_normal[3] != 0))
                {
                    c_need_normal[3] = c_need_n;
                    c_need_double[3] = c_need_n;
                }

            }
            //矛步
            if (c_spear_infantry > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[0] = 0;
                c_need_normal[1] = 0;
                c_need_normal[4] = 0;
                c_need_normal[5] = 0;
                c_need_double[0] = 0;
                c_need_double[1] = 0;
                c_need_double[4] = 0;
                c_need_double[5] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_SPEAR * c_spear_infantry;
                //斧步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_ax)));
                if (c_need_normal[2] == -1 || (c_need_normal[2] < c_need_n && c_need_normal[2] != 0))
                {
                    c_need_normal[2] = c_need_n;
                    c_need_double[2] = c_need_n;
                }
                //斧骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_ax)));
                if (c_need_normal[6] == -1 || c_need_normal[6] < c_need_n && c_need_normal[6] != 0)
                {
                    c_need_normal[6] = c_need_n;
                    c_need_double[6] = c_need_n;
                }
                //弓
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                if (c_need_normal[3] == -1 || (c_need_normal[3] < c_need_n && c_need_normal[3] != 0))
                {
                    c_need_normal[3] = c_need_n;
                    c_need_double[3] = c_need_n;
                }
            }
            //斧步
            if (c_ax_infantry > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[1] = 0;
                c_need_normal[2] = 0;
                c_need_normal[5] = 0;
                c_need_normal[6] = 0;
                c_need_double[1] = 0;
                c_need_double[2] = 0;
                c_need_double[5] = 0;
                c_need_double[6] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_AX * c_ax_infantry;
                //剑步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_sword)));
                if (c_need_normal[0] == -1 || (c_need_normal[0] < c_need_n && c_need_normal[0] != 0))
                {
                    c_need_normal[0] = c_need_n;
                    c_need_double[0] = c_need_n;
                }
                //剑骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_sword)));
                if (c_need_normal[4] == -1 || c_need_normal[4] < c_need_n && c_need_normal[4] != 0)
                {
                    c_need_normal[4] = c_need_n;
                    c_need_double[4] = c_need_n;
                }
                //弓
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                if (c_need_normal[3] == -1 || (c_need_normal[3] < c_need_n && c_need_normal[3] != 0))
                {
                    c_need_normal[3] = c_need_n;
                    c_need_double[3] = c_need_n;
                }
            }
            //弓
            if (c_bow > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[0] = 0;
                c_need_normal[1] = 0;
                c_need_normal[2] = 0;
                c_need_normal[3] = 0;
                c_need_double[0] = 0;
                c_need_double[1] = 0;
                c_need_double[2] = 0;
                c_need_double[3] = 0;

                enemyPower = SpartanConst.UnitPower.BOW * c_bow;
                dEnemyPower = enemyPower * 2;
                //剑骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_sword)));
                if (c_need_normal[4] == -1 || (c_need_normal[4] < c_need_n && c_need_normal[4] != 0))
                {
                    c_need_normal[4] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_sword)));
                if (c_need_double[4] == -1 || (c_need_double[4] < c_need_d && c_need_double[4] != 0))
                {
                    c_need_double[4] = c_need_d;
                }

                //矛骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_spear)));
                if (c_need_normal[5] == -1 || c_need_normal[5] < c_need_n && c_need_normal[5] != 0)
                {
                    c_need_normal[5] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_spear)));
                if (c_need_double[5] == -1 || (c_need_double[5] < c_need_d && c_need_double[5] != 0))
                {
                    c_need_double[5] = c_need_d;
                }

                //斧骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_ax)));
                if (c_need_normal[6] == -1 || (c_need_normal[6] < c_need_n && c_need_normal[6] != 0))
                {
                    c_need_normal[6] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_ax)));
                if (c_need_double[6] == -1 || (c_need_double[6] < c_need_d && c_need_double[6] != 0))
                {
                    c_need_double[6] = c_need_d;
                }
            }
            //剑骑
            if (c_sword_ride > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[3] = 0;
                c_need_normal[4] = 0;
                c_need_normal[6] = 0;
                c_need_double[3] = 0;
                c_need_double[4] = 0;
                c_need_double[6] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_SWORD * c_sword_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_sword)));
                if (c_need_normal[0] == -1 || (c_need_normal[0] < c_need_n && c_need_normal[0] != 0))
                {
                    c_need_normal[0] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_sword)));
                if (c_need_double[0] == -1 || (c_need_double[0] < c_need_d && c_need_double[0] != 0))
                {
                    c_need_double[0] = c_need_d;
                }

                //矛步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_spear)));
                if (c_need_normal[1] == -1 || (c_need_normal[1] < c_need_n && c_need_normal[1] != 0))
                {
                    c_need_normal[1] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_spear)));
                if (c_need_double[1] == -1 || (c_need_double[1] < c_need_d && c_need_double[1] != 0))
                {
                    c_need_double[1] = c_need_d;
                }

                //斧步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_ax)));
                if (c_need_normal[2] == -1 || (c_need_normal[2] < c_need_n && c_need_normal[2] != 0))
                {
                    c_need_normal[2] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_ax)));
                if (c_need_double[2] == -1 || (c_need_double[2] < c_need_d && c_need_double[2] != 0))
                {
                    c_need_double[2] = c_need_d;
                }

                //矛骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_spear)));
                if (c_need_normal[5] == -1 || (c_need_normal[5] < c_need_n && c_need_normal[5] != 0))
                {
                    c_need_normal[5] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_spear)));
                if (c_need_double[5] == -1 || (c_need_double[5] < c_need_d && c_need_double[5] != 0))
                {
                    c_need_double[5] = c_need_d;
                }
            }
            //矛骑
            if (c_spear_ride > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[3] = 0;
                c_need_normal[4] = 0;
                c_need_normal[5] = 0;
                c_need_double[3] = 0;
                c_need_double[4] = 0;
                c_need_double[5] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_SPEAR * c_spear_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_sword)));
                if (c_need_normal[0] == -1 || (c_need_normal[0] < c_need_n && c_need_normal[0] != 0))
                {
                    c_need_normal[0] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_sword)));
                if (c_need_double[0] == -1 || (c_need_double[0] < c_need_d && c_need_double[0] != 0))
                {
                    c_need_double[0] = c_need_d;
                }

                //矛步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_spear)));
                if (c_need_normal[1] == -1 || (c_need_normal[1] < c_need_n && c_need_normal[1] != 0))
                {
                    c_need_normal[1] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_spear)));
                if (c_need_double[1] == -1 || (c_need_double[1] < c_need_d && c_need_double[1] != 0))
                {
                    c_need_double[1] = c_need_d;
                }

                //斧步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_ax)));
                if (c_need_normal[2] == -1 || (c_need_normal[2] < c_need_n && c_need_normal[2] != 0))
                {
                    c_need_normal[2] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_ax)));
                if (c_need_double[2] == -1 || (c_need_double[2] < c_need_d && c_need_double[2] != 0))
                {
                    c_need_double[2] = c_need_d;
                }

                //斧骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_ax)));
                if (c_need_normal[6] == -1 || (c_need_normal[6] < c_need_n && c_need_normal[6] != 0))
                {
                    c_need_normal[6] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_ax)));
                if (c_need_double[6] == -1 || (c_need_double[6] < c_need_d && c_need_double[6] != 0))
                {
                    c_need_double[6] = c_need_d;
                }
            }
            //斧骑
            if (c_ax_ride > 0)
            {
                //设置不能无损的兵种为0
                c_need_normal[3] = 0;
                c_need_normal[5] = 0;
                c_need_normal[6] = 0;
                c_need_double[3] = 0;
                c_need_double[5] = 0;
                c_need_double[6] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_AX * c_ax_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_sword)));
                if (c_need_normal[0] == -1 || (c_need_normal[0] < c_need_n && c_need_normal[0] != 0))
                {
                    c_need_normal[0] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_sword)));
                if (c_need_double[0] == -1 || (c_need_double[0] < c_need_d && c_need_double[0] != 0))
                {
                    c_need_double[0] = c_need_d;
                }

                //矛步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_spear)));
                if (c_need_normal[1] == -1 || (c_need_normal[1] < c_need_n && c_need_normal[1] != 0))
                {
                    c_need_normal[1] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_spear)));
                if (c_need_double[1] == -1 || (c_need_double[1] < c_need_d && c_need_double[1] != 0))
                {
                    c_need_double[1] = c_need_d;
                }

                //斧步
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_ax)));
                if (c_need_normal[2] == -1 || (c_need_normal[2] < c_need_n && c_need_normal[2] != 0))
                {
                    c_need_normal[2] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_ax)));
                if (c_need_double[2] == -1 || (c_need_double[2] < c_need_d && c_need_double[2] != 0))
                {
                    c_need_double[2] = c_need_d;
                }

                //剑骑
                c_need_n = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_sword)));
                if (c_need_normal[4] == -1 || (c_need_normal[4] < c_need_n && c_need_normal[4] != 0))
                {
                    c_need_normal[4] = c_need_n;
                }
                c_need_d = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_sword)));
                if (c_need_double[4] == -1 || (c_need_double[4] < c_need_d && c_need_double[4] != 0))
                {
                    c_need_double[4] = c_need_d;
                }
            }

            //分析两个无损数组，将数据填写至输出框
            if (c_need_normal[0] > 0)
            {
                txtBoxNPower1.Text = c_need_normal[0].ToString("n0");
            }
            if (c_need_normal[1] > 0)
            {
                txtBoxNPower2.Text = c_need_normal[1].ToString("n0");
            }
            if (c_need_normal[2] > 0)
            {
                txtBoxNPower3.Text = c_need_normal[2].ToString("n0");
            }
            if (c_need_normal[3] > 0)
            {
                txtBoxNPower4.Text = c_need_normal[3].ToString("n0");
            }
            if (c_need_normal[4] > 0)
            {
                txtBoxNPower5.Text = c_need_normal[4].ToString("n0");
            }
            if (c_need_normal[5] > 0)
            {
                txtBoxNPower6.Text = c_need_normal[5].ToString("n0");
            }
            if (c_need_normal[6] > 0)
            {
                txtBoxNPower7.Text = c_need_normal[6].ToString("n0");
            }

            if (c_need_double[0] > 0)
            {
                txtBoxDPower1.Text = c_need_double[0].ToString("n0");
            }
            if (c_need_double[1] > 0)
            {
                txtBoxDPower2.Text = c_need_double[1].ToString("n0");
            }
            if (c_need_double[2] > 0)
            {
                txtBoxDPower3.Text = c_need_double[2].ToString("n0");
            }
            if (c_need_double[3] > 0)
            {
                txtBoxDPower4.Text = c_need_double[3].ToString("n0");
            }
            if (c_need_double[4] > 0)
            {
                txtBoxDPower5.Text = c_need_double[4].ToString("n0");
            }
            if (c_need_double[5] > 0)
            {
                txtBoxDPower6.Text = c_need_double[5].ToString("n0");
            }
            if (c_need_double[6] > 0)
            {
                txtBoxDPower7.Text = c_need_double[6].ToString("n0");
            }

            //计算己方损失
            if (txtBoxSelfPower.Text.Equals("0"))
            {                
                return;
            }
            string selfName = cbBoxSelfSoldier.SelectedText;
            double unitSelfPower;
            switch (selfName)
            {
                case "剑步": unitSelfPower = unitTotalPower_infantry_sword;
                    break;
                case "矛步": unitSelfPower = unitTotalPower_infantry_spear;
                    break;
                case "斧步": unitSelfPower = unitTotalPower_infantry_ax;
                    break;
                case "弓": unitSelfPower = unitTotalPower_bow;
                    break;
                case "剑骑": unitSelfPower = unitTotalPower_ride_sword;
                    break;
                case "矛骑": unitSelfPower = unitTotalPower_ride_spear;
                    break;
                case "斧骑": unitSelfPower = unitTotalPower_ride_ax;
                    break;
                default:
                    break;
            }
            

        }

        
        /// <summary>
        /// 计算无损核心算法(枚举法)（非常坑爹，枚举到双兵种时才想到新方法）
        /// </summary>
        private void calculatePower_pre()
        {
            initCalPower();
            //满意度和士气值在4500-9000之间分为3个档次，4500-5000为一档，5001-6000为一档，6001-8000为一档，8001-9000为一档，加成分别为0.00,0.01,0.03,0.05
            double satisfiction;
            double morale;
            satisfiction = double.Parse(txtBox_satisfy.Text);
            morale = double.Parse(txtBox_morale.Text);

            //满意度加成
            if (satisfiction >= 4500 && satisfiction <= 5000)
            {
                satisfiction = 0;
            }
            else if (satisfiction >= 5001 && satisfiction <= 6000)
            {
                satisfiction = 0.01;
            }
            else if (satisfiction >= 6001 && satisfiction <= 8000)
            {
                satisfiction = 0.03;
            }
            else if (satisfiction >= 8001)
            {
                satisfiction = 0.05;
            }

            //士气值加成
            if (morale >= 4500 && morale <= 5000)
            {
                morale = 0;
            }
            else if (morale >= 5001 && morale <= 6000)
            {
                morale = 0.01;
            }
            else if (morale >= 6001 && morale <= 8000)
            {
                morale = 0.03;
            }
            else if (morale >= 8001)
            {
                morale = 0.05;
            }

            double satisAndMorale = satisfiction + morale;


            //科技神满意度加成(其它一级1%，弓一级2%)
            double tec_sword = double.Parse(txtBox_sword.Text) / 100;
            double tec_spear = double.Parse(txtBox_spear.Text) / 100;
            double tec_ax = double.Parse(txtBox_ax.Text) / 100;
            double tec_infantry = double.Parse(txtBox_infantry.Text) / 100;
            double tec_bow = double.Parse(txtBox_bow.Text) * 2 / 100;
            double tec_ride = double.Parse(txtBox_ride.Text) / 100;
            double god_bow = double.Parse(txtBox_godadd_bow.Text);
            double god_infantry = double.Parse(txtBox_godadd_infantry.Text);
            double god_ride = double.Parse(txtBox_godadd_ride.Text);


            //兵力数量
            int c_sword_infantry = int.Parse(txtBoxPower1.Text);
            int c_spear_infantry = int.Parse(txtBoxPower2.Text);
            int c_ax_infantry = int.Parse(txtBoxPower3.Text); ;
            int c_bow = int.Parse(txtBoxPower4.Text); ;
            int c_sword_ride = int.Parse(txtBoxPower5.Text); ;
            int c_spear_ride = int.Parse(txtBoxPower6.Text); ;
            int c_ax_ride = int.Parse(txtBoxPower7.Text); ;

            //单位战力
            double unitTotalPower_infantry_sword = SpartanConst.UnitPower.INFANTRY_SWORD * (1 + satisfiction + morale + tec_sword + tec_infantry) + god_infantry; ;
            double unitTotalPower_infantry_spear = SpartanConst.UnitPower.INFANTRY_SPEAR * (1 + satisfiction + morale + tec_spear + tec_infantry) + god_infantry; ;
            double unitTotalPower_infantry_ax = SpartanConst.UnitPower.INFANTRY_AX * (1 + satisfiction + morale + tec_ax + tec_infantry) + god_infantry;
            double unitTotalPower_bow = SpartanConst.UnitPower.BOW * (1 + satisfiction + morale + tec_bow) + god_bow;
            double unitTotalPower_ride_sword = SpartanConst.UnitPower.RIDE_SWORD * (1 + satisfiction + morale + tec_sword + tec_ride) + god_ride;
            double unitTotalPower_ride_spear = SpartanConst.UnitPower.RIDE_SPEAR * (1 + satisfiction + morale + tec_spear + tec_ride) + god_ride;
            double unitTotalPower_ride_ax = SpartanConst.UnitPower.RIDE_AX * (1 + satisfiction + morale + tec_ax + tec_ride) + god_ride;

            //无损所需兵力
            int c_need_1;
            int c_need_2;
            int c_need_3;
            int c_need_4;

            //敌军总战力
            double enemyPower;
            //暴击战力
            double dEnemyPower;

            //无损计算
            //克制关系：武器克制：矛克剑20%，斧克矛20%，剑克斧20%；兵种克制：弓克步30%，骑克弓30%，步克骑30%

            //枚举各种情况

            //单种兵纵队
            //剑步，可以出矛步，矛骑，弓三种兵
            if (c_sword_infantry > 0 && (c_spear_infantry + c_ax_infantry + c_bow + c_sword_ride + c_spear_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.INFANTRY_SWORD * c_sword_infantry;
                //矛步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_spear)));
                txtBoxNPower2.Text = c_need_1.ToString("n0");
                //矛骑
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_spear)));
                txtBoxNPower6.Text = c_need_2.ToString("n0");
                //弓
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                txtBoxNPower4.Text = c_need_3.ToString("n0");
            }
            //矛步，可以出斧步，斧骑，弓三种兵
            if (c_spear_infantry > 0 && (c_sword_infantry + c_ax_infantry + c_bow + c_sword_ride + c_spear_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.INFANTRY_SPEAR * c_spear_infantry;
                //斧步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_ax)));
                txtBoxNPower3.Text = c_need_1.ToString("n0");
                //斧骑
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_ax)));
                txtBoxNPower7.Text = c_need_2.ToString("n0");
                //弓
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                txtBoxNPower4.Text = c_need_3.ToString("n0");
            }
            //斧步，可以出剑步，剑骑，弓三种兵
            if (c_ax_infantry > 0 && (c_sword_infantry + c_spear_infantry + c_bow + c_sword_ride + c_spear_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.INFANTRY_AX * c_ax_infantry;
                //剑步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_infantry_sword)));
                txtBoxNPower1.Text = c_need_1.ToString("n0");
                //剑骑
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPower_ride_sword)));
                txtBoxNPower5.Text = c_need_2.ToString("n0");
                //弓
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_bow)));
                txtBoxNPower4.Text = c_need_3.ToString("n0");
            }
            //弓，可以出剑骑，矛骑，斧骑三种兵
            if (c_bow > 0 && (c_sword_infantry + c_spear_infantry + c_ax_infantry + c_sword_ride + c_spear_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.BOW * c_bow;
                dEnemyPower = enemyPower * 2;
                //剑骑
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_sword)));
                txtBoxNPower5.Text = c_need_1.ToString("n0");
                c_need_1 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_sword)));
                txtBoxDPower5.Text = c_need_1.ToString("n0");
                //矛骑
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_spear)));
                txtBoxNPower6.Text = c_need_2.ToString("n0");
                c_need_2 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_spear)));
                txtBoxDPower6.Text = c_need_2.ToString("n0");
                //斧骑
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_ride_ax)));
                txtBoxNPower7.Text = c_need_3.ToString("n0");
                c_need_3 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_ride_ax)));
                txtBoxDPower7.Text = c_need_3.ToString("n0");
            }
            //剑骑，可以出三步，矛骑四种兵
            if (c_sword_ride > 0 && (c_sword_infantry + c_spear_infantry + c_ax_infantry + c_bow + c_spear_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.RIDE_SWORD * c_sword_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_sword)));
                txtBoxNPower1.Text = c_need_1.ToString("n0");
                c_need_1 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_sword)));
                txtBoxDPower1.Text = c_need_1.ToString("n0");
                //矛步
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_spear)));
                txtBoxNPower2.Text = c_need_2.ToString("n0");
                c_need_2 = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_spear)));
                txtBoxDPower2.Text = c_need_2.ToString("n0");
                //斧步
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_ax)));
                txtBoxNPower3.Text = c_need_3.ToString("n0");
                c_need_3 = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_ax)));
                txtBoxDPower3.Text = c_need_3.ToString("n0");
                //矛骑
                c_need_4 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_spear)));
                txtBoxNPower6.Text = c_need_4.ToString("n0");
                c_need_4 = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_spear)));
                txtBoxDPower6.Text = c_need_4.ToString("n0");
            }
            //矛骑，可以出三步，斧骑四种兵
            if (c_spear_ride > 0 && (c_sword_infantry + c_spear_infantry + c_ax_infantry + c_bow + c_sword_ride + c_ax_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.RIDE_SPEAR * c_spear_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_sword)));
                txtBoxNPower1.Text = c_need_1.ToString("n0");
                c_need_1 = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_sword)));
                txtBoxDPower1.Text = c_need_1.ToString("n0");
                //矛步
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_spear)));
                txtBoxNPower2.Text = c_need_2.ToString("n0");
                c_need_2 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_spear)));
                txtBoxDPower2.Text = c_need_2.ToString("n0");
                //斧步
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_ax)));
                txtBoxNPower3.Text = c_need_3.ToString("n0");
                c_need_3 = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_ax)));
                txtBoxDPower3.Text = c_need_3.ToString("n0");
                //斧骑
                c_need_4 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_ax)));
                txtBoxNPower7.Text = c_need_4.ToString("n0");
                c_need_4 = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_ax)));
                txtBoxDPower7.Text = c_need_4.ToString("n0");
            }
            //斧骑，可以出三步，剑骑四种兵
            if (c_ax_ride > 0 && (c_sword_infantry + c_spear_infantry + c_ax_infantry + c_bow + c_sword_ride + c_spear_ride) == 0)
            {
                enemyPower = SpartanConst.UnitPower.RIDE_AX * c_ax_ride;
                dEnemyPower = enemyPower * 2;
                //剑步
                c_need_1 = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPower_infantry_sword)));
                txtBoxNPower1.Text = c_need_1.ToString("n0");
                c_need_1 = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPower_infantry_sword)));
                txtBoxDPower1.Text = c_need_1.ToString("n0");
                //矛步
                c_need_2 = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPower_infantry_spear)));
                txtBoxNPower2.Text = c_need_2.ToString("n0");
                c_need_2 = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPower_infantry_spear)));
                txtBoxDPower2.Text = c_need_2.ToString("n0");
                //斧步
                c_need_3 = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPower_infantry_ax)));
                txtBoxNPower3.Text = c_need_3.ToString("n0");
                c_need_3 = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPower_infantry_ax)));
                txtBoxDPower3.Text = c_need_3.ToString("n0");
                //剑骑
                c_need_4 = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPower_ride_sword)));
                txtBoxNPower5.Text = c_need_4.ToString("n0");
                c_need_4 = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPower_ride_sword)));
                txtBoxDPower5.Text = c_need_4.ToString("n0");
            }

            //两种兵纵队

            //双步
            //剑步+矛步
            if (c_sword_infantry > 0 && c_spear_infantry > 0 && (c_ax_infantry + c_bow + c_sword_ride + c_spear_ride + c_ax_ride) == 0)
            {

            }
        }

        /// <summary>
        /// 选择难度改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxDif_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBoxLayer.Text = "选择层";
            InitControls();
        }

        /// <summary>
        /// 选择层改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitControls();
            //普通难度（1，2，3为单纵队并且只有步兵，4，5，6，7为双纵队并且没有弓，6，7，8，9，10为三纵队并且三兵种都齐全）
            if (cbBoxDif.SelectedIndex == 0)
            {
                if (cbBoxLayer.SelectedIndex >= 0 && cbBoxLayer.SelectedIndex <= 2)
                {
                    cbBoxSoldier1.Enabled = true;
                    cbBoxSoldier2.Enabled = false;
                    cbBoxSoldier3.Enabled = false;
                    this.cbBoxSoldier1.Items.AddRange(new object[] { "剑步", "矛步", "斧步" });
                }
                else if (cbBoxLayer.SelectedIndex >= 3 && cbBoxLayer.SelectedIndex <= 6)
                {
                    cbBoxSoldier1.Enabled = true;
                    cbBoxSoldier2.Enabled = true;
                    cbBoxSoldier3.Enabled = false;
                    this.cbBoxSoldier1.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "剑骑", "矛骑", "斧骑" });
                    this.cbBoxSoldier2.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "剑骑", "矛骑", "斧骑" });
                }
                else
                {
                    cbBoxSoldier1.Enabled = true;
                    cbBoxSoldier2.Enabled = true;
                    cbBoxSoldier3.Enabled = true;
                    this.cbBoxSoldier1.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });
                    this.cbBoxSoldier2.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });
                    this.cbBoxSoldier3.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });

                }
            }
            //恐怖难度（均为三纵队，可能重复）
            if (cbBoxDif.SelectedIndex == 1)
            {
                if (cbBoxLayer.SelectedIndex >= 0 && cbBoxLayer.SelectedIndex <= 9)
                {
                    cbBoxSoldier1.Enabled = true;
                    cbBoxSoldier2.Enabled = true;
                    cbBoxSoldier3.Enabled = true;
                    this.cbBoxSoldier1.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });
                    this.cbBoxSoldier2.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });
                    this.cbBoxSoldier3.Items.AddRange(new object[] { "剑步", "矛步", "斧步", "弓", "剑骑", "矛骑", "斧骑" });
                }
            }

            //噩梦难度（未知）
        }

        /// <summary>
        /// 兵种列表选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxSoldier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string preValue = "";
            string difficulty = "";
            string level = "";
            string soldier_type = "";

            string cbBoxName = ((ComboBox)sender).Name;

            switch (cbBoxName)
            {
                case "cbBoxSoldier1":
                    preValue = cbBoxSoldier1.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier1.Tag = cbBoxSoldier1.Text;
                    soldier_type = cbBoxSoldier1.Text;
                    break;
                case "cbBoxSoldier2":
                    preValue = cbBoxSoldier2.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier2.Tag = cbBoxSoldier2.Text;
                    soldier_type = cbBoxSoldier2.Text;
                    break;
                case "cbBoxSoldier3":
                    preValue = cbBoxSoldier3.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier3.Tag = cbBoxSoldier3.Text;
                    soldier_type = cbBoxSoldier3.Text;
                    break;
                default:
                    break;
            }

            switch (cbBoxDif.Text)
            {
                case "普通": difficulty = "1";
                    break;
                case "恐怖": difficulty = "2";
                    break;
                case "噩梦": difficulty = "3";
                    break;
                default: return;
            }

            level = cbBoxLayer.Text;

            DB_mysteryData db_mystery = new DB_mysteryData();
            db_mystery.Difficulty = difficulty;
            db_mystery.Level = level;
            db_mystery.Type = soldier_type;

            string count = "0";
            DataSet ds = db_mystery.Select(db_mystery);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    count = ds.Tables[0].Rows[0]["soldier_count"].ToString();
                }
            }

            switch (soldier_type)
            {
                case "剑步": txtBoxPower1.Text = count; break;
                case "矛步": txtBoxPower2.Text = count; break;
                case "斧步": txtBoxPower3.Text = count; break;
                case "弓": txtBoxPower4.Text = count; break;
                case "剑骑": txtBoxPower5.Text = count; break;
                case "矛骑": txtBoxPower6.Text = count; break;
                case "斧骑": txtBoxPower7.Text = count; break;
                default:
                    break;
            }

            SortSoldier();

            calculatePower();
        }

        /// <summary>
        /// 出兵排序
        /// </summary>
        private void SortSoldier()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("text", System.Type.GetType("System.String"));
            dt.Columns.Add("value", System.Type.GetType("System.Int32"));
            DataRow dr;
            int totalPower;
            if ((Convert.ToInt32(txtBoxPower1.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower1.Text) * SpartanConst.UnitPower.INFANTRY_SWORD;
                dr = dt.NewRow();
                dr["text"] = lblPower1.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower2.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower2.Text) * SpartanConst.UnitPower.INFANTRY_SPEAR;
                dr = dt.NewRow();
                dr["text"] = lblPower2.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower3.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower3.Text) * SpartanConst.UnitPower.INFANTRY_AX;
                dr = dt.NewRow();
                dr["text"] = lblPower3.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower4.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower4.Text) * SpartanConst.UnitPower.BOW;
                dr = dt.NewRow();
                dr["text"] = lblPower4.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower5.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower5.Text) * SpartanConst.UnitPower.RIDE_SWORD;
                dr = dt.NewRow();
                dr["text"] = lblPower5.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower6.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower6.Text) * SpartanConst.UnitPower.RIDE_SPEAR;
                dr = dt.NewRow();
                dr["text"] = lblPower6.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }
            if ((Convert.ToInt32(txtBoxPower7.Text)) > 0)
            {
                totalPower = Convert.ToInt32(txtBoxPower7.Text) * SpartanConst.UnitPower.RIDE_AX;
                dr = dt.NewRow();
                dr["text"] = lblPower7.Text;
                dr["value"] = totalPower;
                dt.Rows.Add(dr);
            }

            DataView dv = dt.DefaultView;
            dv.Sort = "value desc";
            listBoxSort.DataSource = dv;
            listBoxSort.DisplayMember = "text";
            listBoxSort.ValueMember = "value";


        }

        /// <summary>
        /// 改变兵种后清空原来兵种数量，加载新兵种数量
        /// </summary>
        /// <param name="preValue"></param>
        private void ChangeTxtBoxes(string preValue)
        {
            if (!String.IsNullOrEmpty(preValue) && !cbBoxSoldier1.Tag.Equals(cbBoxSoldier2.Tag) && !cbBoxSoldier1.Tag.Equals(cbBoxSoldier3.Tag) && !cbBoxSoldier2.Tag.Equals(cbBoxSoldier3.Tag))
            {
                switch (preValue)
                {
                    case "剑步": txtBoxPower1.Text = "0"; break;
                    case "矛步": txtBoxPower2.Text = "0"; break;
                    case "斧步": txtBoxPower3.Text = "0"; break;
                    case "弓": txtBoxPower4.Text = "0"; break;
                    case "剑骑": txtBoxPower5.Text = "0"; break;
                    case "矛骑": txtBoxPower6.Text = "0"; break;
                    case "斧骑": txtBoxPower7.Text = "0"; break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 输入框检查
        /// </summary>
        /// <returns></returns>
        private bool TxtBoxCheck()
        {
            bool HasErrorDigital = false;
            if (!IsOnlyDigital(txtBox_sword.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_spear.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_ax.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_infantry.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_bow.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_ride.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_infantry.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_bow.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_ride.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_satisfy.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_morale.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower1.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower2.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower3.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower4.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower5.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower6.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower7.Text))
            {
                HasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxSelfPower.Text))
            {
                HasErrorDigital = true;
            }
            return HasErrorDigital;
        }

        /// <summary>
        /// 判断全是数字并且不能为空
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        private bool IsOnlyDigital(string strValue)
        {
            bool blnIsOnlyDigital;
            char[] arrChar;
            if (IsOnlyHalfChar(strValue) && !String.IsNullOrEmpty(strValue))
            {
                int intIdx;
                bool blnInvalidCharFound = false;
                arrChar = strValue.ToCharArray();
                for (intIdx = 0; intIdx < strValue.Length; intIdx++)
                {
                    if (arrChar[intIdx] >= '0' && arrChar[intIdx] <= '9')
                    {
                    }
                    else
                    {
                        blnInvalidCharFound = true;
                        break;
                    }
                }
                blnIsOnlyDigital = !blnInvalidCharFound;
            }
            else
                blnIsOnlyDigital = false;
            return blnIsOnlyDigital;
        }

        /// <summary>
        /// 判断全为半角字符
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        private bool IsOnlyHalfChar(string strValue)
        {
            bool blnIsOnlyHalfChar;
            if (strValue.Length == GetByteLength(strValue))
                blnIsOnlyHalfChar = true;
            else
                blnIsOnlyHalfChar = false;
            return blnIsOnlyHalfChar;
        }

        /// <summary>
        /// 获取字节长度
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        private int GetByteLength(string strValue)
        {
            return System.Text.Encoding.GetEncoding("gb2312").GetByteCount(strValue);
        }

        /// <summary>
        /// 计算无损
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            calculatePower();
        }
    }
}