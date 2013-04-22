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
            InitCalPower();
            cbBoxSoldier1.Enabled = false;
            cbBoxSoldier2.Enabled = false;
            cbBoxSoldier3.Enabled = false;

            txtBox_sword.GotFocus += txtBox_GotFocus;
            txtBox_spear.GotFocus += txtBox_GotFocus;
            txtBox_ax.GotFocus += txtBox_GotFocus;
            txtBox_bow.GotFocus += txtBox_GotFocus;
            txtBox_infantry.GotFocus += txtBox_GotFocus;
            txtBox_ride.GotFocus += txtBox_GotFocus;
            txtBox_godadd_infantry.GotFocus += txtBox_GotFocus;
            txtBox_godadd_bow.GotFocus += txtBox_GotFocus;
            txtBox_godadd_ride.GotFocus += txtBox_GotFocus;
            txtBox_morale.GotFocus += txtBox_GotFocus;
            txtBox_satisfy.GotFocus += txtBox_GotFocus;
            txtBoxPower1.GotFocus += txtBox_GotFocus;
            txtBoxPower2.GotFocus += txtBox_GotFocus;
            txtBoxPower3.GotFocus += txtBox_GotFocus;
            txtBoxPower4.GotFocus += txtBox_GotFocus;
            txtBoxPower5.GotFocus += txtBox_GotFocus;
            txtBoxPower6.GotFocus += txtBox_GotFocus;
            txtBoxPower7.GotFocus += txtBox_GotFocus;
            txtBoxSelfPower.GotFocus += txtBox_GotFocus;

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

            txtBox_sword.MouseUp += txtBox_MouseUp;
            txtBox_spear.MouseUp += txtBox_MouseUp;
            txtBox_ax.MouseUp += txtBox_MouseUp;
            txtBox_bow.MouseUp += txtBox_MouseUp;
            txtBox_infantry.MouseUp += txtBox_MouseUp;
            txtBox_ride.MouseUp += txtBox_MouseUp;
            txtBox_godadd_infantry.MouseUp += txtBox_MouseUp;
            txtBox_godadd_bow.MouseUp += txtBox_MouseUp;
            txtBox_godadd_ride.MouseUp += txtBox_MouseUp;
            txtBox_morale.MouseUp += txtBox_MouseUp;
            txtBox_satisfy.MouseUp += txtBox_MouseUp;
            txtBoxPower1.MouseUp += txtBox_MouseUp;
            txtBoxPower2.MouseUp += txtBox_MouseUp;
            txtBoxPower3.MouseUp += txtBox_MouseUp;
            txtBoxPower4.MouseUp += txtBox_MouseUp;
            txtBoxPower5.MouseUp += txtBox_MouseUp;
            txtBoxPower6.MouseUp += txtBox_MouseUp;
            txtBoxPower7.MouseUp += txtBox_MouseUp;
            txtBoxSelfPower.MouseUp += txtBox_MouseUp;

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
        private void InitCalPower()
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

                CalculatePower();

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
            SortSoldier();
        }

        /// <summary>
        /// 计算无损核心算法(排斥法)
        /// </summary>
        private void CalculatePower()
        {
            InitCalPower();
            //满意度和士气值在4500-9000之间分为3个档次，4500-5000为一档，5001-6000为一档，6001-8000为一档，8001-9000为一档，加成分别为0.00,0.01,0.03,0.05
            double satisfiction = double.Parse(txtBox_satisfy.Text);
            double morale = double.Parse(txtBox_morale.Text);

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
            double tecSword = double.Parse(txtBox_sword.Text) / 100;
            double tecSpear = double.Parse(txtBox_spear.Text) / 100;
            double tecAx = double.Parse(txtBox_ax.Text) / 100;
            double tecInfantry = double.Parse(txtBox_infantry.Text) / 100;
            double tecBow = double.Parse(txtBox_bow.Text) * 2 / 100;
            double tecRide = double.Parse(txtBox_ride.Text) / 100;
            double godBow = double.Parse(txtBox_godadd_bow.Text);
            double godInfantry = double.Parse(txtBox_godadd_infantry.Text);
            double godRide = double.Parse(txtBox_godadd_ride.Text);


            //兵力数量
            int cSwordInfantry = int.Parse(txtBoxPower1.Text);
            int cSpearInfantry = int.Parse(txtBoxPower2.Text);
            int cAxInfantry = int.Parse(txtBoxPower3.Text);
            int cBow = int.Parse(txtBoxPower4.Text);
            int cSwordRide = int.Parse(txtBoxPower5.Text);
            int cSpearRide = int.Parse(txtBoxPower6.Text);
            int cAxRide = int.Parse(txtBoxPower7.Text);

            //单位战力
            double unitTotalPowerInfantrySword = SpartanConst.UnitPower.INFANTRY_SWORD * (1 + satisfiction + morale + tecSword + tecInfantry) + godInfantry; ;
            double unitTotalPowerInfantrySpear = SpartanConst.UnitPower.INFANTRY_SPEAR * (1 + satisfiction + morale + tecSpear + tecInfantry) + godInfantry; ;
            double unitTotalPowerInfantryAx = SpartanConst.UnitPower.INFANTRY_AX * (1 + satisfiction + morale + tecAx + tecInfantry) + godInfantry;
            double unitTotalPowerBow = SpartanConst.UnitPower.BOW * (1 + satisfiction + morale + tecBow) + godBow;
            double unitTotalPowerRideSword = SpartanConst.UnitPower.RIDE_SWORD * (1 + satisfiction + morale + tecSword + tecRide) + godRide;
            double unitTotalPowerRideSpear = SpartanConst.UnitPower.RIDE_SPEAR * (1 + satisfiction + morale + tecSpear + tecRide) + godRide;
            double unitTotalPowerRideAx = SpartanConst.UnitPower.RIDE_AX * (1 + satisfiction + morale + tecAx + tecRide) + godRide;

            //无损所需兵力过渡变量
            int cNeedN;
            int cNeedD;

            //无损兵力数组
            var cNeedNormal = new int[7];
            var cNeedDouble = new int[7];
            //初始化兵力
            for (int i = 0; i < 7; i++)
            {
                cNeedNormal[i] = -1;
                cNeedDouble[i] = -1;
            }

            //敌军总战力
            double enemyPower;
            //暴击战力
            double dEnemyPower;

            //列举敌对7种兵可出的兵种及相应数量
            //剑步
            if (cSwordInfantry > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[0] = 0;
                cNeedNormal[2] = 0;
                cNeedNormal[4] = 0;
                cNeedNormal[6] = 0;
                cNeedDouble[0] = 0;
                cNeedDouble[2] = 0;
                cNeedDouble[4] = 0;
                cNeedDouble[6] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_SWORD * cSwordInfantry;
                //矛步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerInfantrySpear)));
                if (cNeedNormal[1] == -1 || (cNeedNormal[1] < cNeedN && cNeedNormal[1] != 0))
                {
                    cNeedNormal[1] = cNeedN;
                    cNeedDouble[1] = cNeedN;
                }
                //矛骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPowerRideSpear)));
                if (cNeedNormal[5] == -1 || cNeedNormal[5] < cNeedN && cNeedNormal[5] != 0)
                {
                    cNeedNormal[5] = cNeedN;
                    cNeedDouble[5] = cNeedN;
                }
                //弓
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerBow)));
                if (cNeedNormal[3] == -1 || (cNeedNormal[3] < cNeedN && cNeedNormal[3] != 0))
                {
                    cNeedNormal[3] = cNeedN;
                    cNeedDouble[3] = cNeedN;
                }

            }
            //矛步
            if (cSpearInfantry > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[0] = 0;
                cNeedNormal[1] = 0;
                cNeedNormal[4] = 0;
                cNeedNormal[5] = 0;
                cNeedDouble[0] = 0;
                cNeedDouble[1] = 0;
                cNeedDouble[4] = 0;
                cNeedDouble[5] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_SPEAR * cSpearInfantry;
                //斧步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerInfantryAx)));
                if (cNeedNormal[2] == -1 || (cNeedNormal[2] < cNeedN && cNeedNormal[2] != 0))
                {
                    cNeedNormal[2] = cNeedN;
                    cNeedDouble[2] = cNeedN;
                }
                //斧骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPowerRideAx)));
                if (cNeedNormal[6] == -1 || cNeedNormal[6] < cNeedN && cNeedNormal[6] != 0)
                {
                    cNeedNormal[6] = cNeedN;
                    cNeedDouble[6] = cNeedN;
                }
                //弓
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerBow)));
                if (cNeedNormal[3] == -1 || (cNeedNormal[3] < cNeedN && cNeedNormal[3] != 0))
                {
                    cNeedNormal[3] = cNeedN;
                    cNeedDouble[3] = cNeedN;
                }
            }
            //斧步
            if (cAxInfantry > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[1] = 0;
                cNeedNormal[2] = 0;
                cNeedNormal[5] = 0;
                cNeedNormal[6] = 0;
                cNeedDouble[1] = 0;
                cNeedDouble[2] = 0;
                cNeedDouble[5] = 0;
                cNeedDouble[6] = 0;

                enemyPower = SpartanConst.UnitPower.INFANTRY_AX * cAxInfantry;
                //剑步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerInfantrySword)));
                if (cNeedNormal[0] == -1 || (cNeedNormal[0] < cNeedN && cNeedNormal[0] != 0))
                {
                    cNeedNormal[0] = cNeedN;
                    cNeedDouble[0] = cNeedN;
                }
                //剑骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.3 / (0.2 * unitTotalPowerRideSword)));
                if (cNeedNormal[4] == -1 || cNeedNormal[4] < cNeedN && cNeedNormal[4] != 0)
                {
                    cNeedNormal[4] = cNeedN;
                    cNeedDouble[4] = cNeedN;
                }
                //弓
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerBow)));
                if (cNeedNormal[3] == -1 || (cNeedNormal[3] < cNeedN && cNeedNormal[3] != 0))
                {
                    cNeedNormal[3] = cNeedN;
                    cNeedDouble[3] = cNeedN;
                }
            }
            //弓
            if (cBow > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[0] = 0;
                cNeedNormal[1] = 0;
                cNeedNormal[2] = 0;
                cNeedNormal[3] = 0;
                cNeedDouble[0] = 0;
                cNeedDouble[1] = 0;
                cNeedDouble[2] = 0;
                cNeedDouble[3] = 0;

                enemyPower = SpartanConst.UnitPower.BOW * cBow;
                dEnemyPower = enemyPower * 2;
                //剑骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerRideSword)));
                if (cNeedNormal[4] == -1 || (cNeedNormal[4] < cNeedN && cNeedNormal[4] != 0))
                {
                    cNeedNormal[4] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerRideSword)));
                if (cNeedDouble[4] == -1 || (cNeedDouble[4] < cNeedD && cNeedDouble[4] != 0))
                {
                    cNeedDouble[4] = cNeedD;
                }

                //矛骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerRideSpear)));
                if (cNeedNormal[5] == -1 || cNeedNormal[5] < cNeedN && cNeedNormal[5] != 0)
                {
                    cNeedNormal[5] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerRideSpear)));
                if (cNeedDouble[5] == -1 || (cNeedDouble[5] < cNeedD && cNeedDouble[5] != 0))
                {
                    cNeedDouble[5] = cNeedD;
                }

                //斧骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerRideAx)));
                if (cNeedNormal[6] == -1 || (cNeedNormal[6] < cNeedN && cNeedNormal[6] != 0))
                {
                    cNeedNormal[6] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerRideAx)));
                if (cNeedDouble[6] == -1 || (cNeedDouble[6] < cNeedD && cNeedDouble[6] != 0))
                {
                    cNeedDouble[6] = cNeedD;
                }
            }
            //剑骑
            if (cSwordRide > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[3] = 0;
                cNeedNormal[4] = 0;
                cNeedNormal[6] = 0;
                cNeedDouble[3] = 0;
                cNeedDouble[4] = 0;
                cNeedDouble[6] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_SWORD * cSwordRide;
                dEnemyPower = enemyPower * 2;
                //剑步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerInfantrySword)));
                if (cNeedNormal[0] == -1 || (cNeedNormal[0] < cNeedN && cNeedNormal[0] != 0))
                {
                    cNeedNormal[0] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerInfantrySword)));
                if (cNeedDouble[0] == -1 || (cNeedDouble[0] < cNeedD && cNeedDouble[0] != 0))
                {
                    cNeedDouble[0] = cNeedD;
                }

                //矛步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPowerInfantrySpear)));
                if (cNeedNormal[1] == -1 || (cNeedNormal[1] < cNeedN && cNeedNormal[1] != 0))
                {
                    cNeedNormal[1] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPowerInfantrySpear)));
                if (cNeedDouble[1] == -1 || (cNeedDouble[1] < cNeedD && cNeedDouble[1] != 0))
                {
                    cNeedDouble[1] = cNeedD;
                }

                //斧步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPowerInfantryAx)));
                if (cNeedNormal[2] == -1 || (cNeedNormal[2] < cNeedN && cNeedNormal[2] != 0))
                {
                    cNeedNormal[2] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPowerInfantryAx)));
                if (cNeedDouble[2] == -1 || (cNeedDouble[2] < cNeedD && cNeedDouble[2] != 0))
                {
                    cNeedDouble[2] = cNeedD;
                }

                //矛骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerRideSpear)));
                if (cNeedNormal[5] == -1 || (cNeedNormal[5] < cNeedN && cNeedNormal[5] != 0))
                {
                    cNeedNormal[5] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPowerRideSpear)));
                if (cNeedDouble[5] == -1 || (cNeedDouble[5] < cNeedD && cNeedDouble[5] != 0))
                {
                    cNeedDouble[5] = cNeedD;
                }
            }
            //矛骑
            if (cSpearRide > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[3] = 0;
                cNeedNormal[4] = 0;
                cNeedNormal[5] = 0;
                cNeedDouble[3] = 0;
                cNeedDouble[4] = 0;
                cNeedDouble[5] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_SPEAR * cSpearRide;
                dEnemyPower = enemyPower * 2;
                //剑步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPowerInfantrySword)));
                if (cNeedNormal[0] == -1 || (cNeedNormal[0] < cNeedN && cNeedNormal[0] != 0))
                {
                    cNeedNormal[0] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPowerInfantrySword)));
                if (cNeedDouble[0] == -1 || (cNeedDouble[0] < cNeedD && cNeedDouble[0] != 0))
                {
                    cNeedDouble[0] = cNeedD;
                }

                //矛步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerInfantrySpear)));
                if (cNeedNormal[1] == -1 || (cNeedNormal[1] < cNeedN && cNeedNormal[1] != 0))
                {
                    cNeedNormal[1] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerInfantrySpear)));
                if (cNeedDouble[1] == -1 || (cNeedDouble[1] < cNeedD && cNeedDouble[1] != 0))
                {
                    cNeedDouble[1] = cNeedD;
                }

                //斧步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPowerInfantryAx)));
                if (cNeedNormal[2] == -1 || (cNeedNormal[2] < cNeedN && cNeedNormal[2] != 0))
                {
                    cNeedNormal[2] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPowerInfantryAx)));
                if (cNeedDouble[2] == -1 || (cNeedDouble[2] < cNeedD && cNeedDouble[2] != 0))
                {
                    cNeedDouble[2] = cNeedD;
                }

                //斧骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerRideAx)));
                if (cNeedNormal[6] == -1 || (cNeedNormal[6] < cNeedN && cNeedNormal[6] != 0))
                {
                    cNeedNormal[6] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPowerRideAx)));
                if (cNeedDouble[6] == -1 || (cNeedDouble[6] < cNeedD && cNeedDouble[6] != 0))
                {
                    cNeedDouble[6] = cNeedD;
                }
            }
            //斧骑
            if (cAxRide > 0)
            {
                //设置不能无损的兵种为0
                cNeedNormal[3] = 0;
                cNeedNormal[5] = 0;
                cNeedNormal[6] = 0;
                cNeedDouble[3] = 0;
                cNeedDouble[5] = 0;
                cNeedDouble[6] = 0;

                enemyPower = SpartanConst.UnitPower.RIDE_AX * cAxRide;
                dEnemyPower = enemyPower * 2;
                //剑步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.5 * unitTotalPowerInfantrySword)));
                if (cNeedNormal[0] == -1 || (cNeedNormal[0] < cNeedN && cNeedNormal[0] != 0))
                {
                    cNeedNormal[0] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.5 * unitTotalPowerInfantrySword)));
                if (cNeedDouble[0] == -1 || (cNeedDouble[0] < cNeedD && cNeedDouble[0] != 0))
                {
                    cNeedDouble[0] = cNeedD;
                }

                //矛步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower * 1.2 / (0.3 * unitTotalPowerInfantrySpear)));
                if (cNeedNormal[1] == -1 || (cNeedNormal[1] < cNeedN && cNeedNormal[1] != 0))
                {
                    cNeedNormal[1] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower * 1.2 / (0.3 * unitTotalPowerInfantrySpear)));
                if (cNeedDouble[1] == -1 || (cNeedDouble[1] < cNeedD && cNeedDouble[1] != 0))
                {
                    cNeedDouble[1] = cNeedD;
                }

                //斧步
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.3 * unitTotalPowerInfantryAx)));
                if (cNeedNormal[2] == -1 || (cNeedNormal[2] < cNeedN && cNeedNormal[2] != 0))
                {
                    cNeedNormal[2] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.3 * unitTotalPowerInfantryAx)));
                if (cNeedDouble[2] == -1 || (cNeedDouble[2] < cNeedD && cNeedDouble[2] != 0))
                {
                    cNeedDouble[2] = cNeedD;
                }

                //剑骑
                cNeedN = Convert.ToInt32(Math.Round(enemyPower / (0.2 * unitTotalPowerRideSword)));
                if (cNeedNormal[4] == -1 || (cNeedNormal[4] < cNeedN && cNeedNormal[4] != 0))
                {
                    cNeedNormal[4] = cNeedN;
                }
                cNeedD = Convert.ToInt32(Math.Round(dEnemyPower / (0.2 * unitTotalPowerRideSword)));
                if (cNeedDouble[4] == -1 || (cNeedDouble[4] < cNeedD && cNeedDouble[4] != 0))
                {
                    cNeedDouble[4] = cNeedD;
                }
            }

            //分析两个无损数组，将数据填写至输出框
            if (cNeedNormal[0] > 0)
            {
                txtBoxNPower1.Text = cNeedNormal[0].ToString("n0");
            }
            if (cNeedNormal[1] > 0)
            {
                txtBoxNPower2.Text = cNeedNormal[1].ToString("n0");
            }
            if (cNeedNormal[2] > 0)
            {
                txtBoxNPower3.Text = cNeedNormal[2].ToString("n0");
            }
            if (cNeedNormal[3] > 0)
            {
                txtBoxNPower4.Text = cNeedNormal[3].ToString("n0");
            }
            if (cNeedNormal[4] > 0)
            {
                txtBoxNPower5.Text = cNeedNormal[4].ToString("n0");
            }
            if (cNeedNormal[5] > 0)
            {
                txtBoxNPower6.Text = cNeedNormal[5].ToString("n0");
            }
            if (cNeedNormal[6] > 0)
            {
                txtBoxNPower7.Text = cNeedNormal[6].ToString("n0");
            }

            if (cNeedDouble[0] > 0)
            {
                txtBoxDPower1.Text = cNeedDouble[0].ToString("n0");
            }
            if (cNeedDouble[1] > 0)
            {
                txtBoxDPower2.Text = cNeedDouble[1].ToString("n0");
            }
            if (cNeedDouble[2] > 0)
            {
                txtBoxDPower3.Text = cNeedDouble[2].ToString("n0");
            }
            if (cNeedDouble[3] > 0)
            {
                txtBoxDPower4.Text = cNeedDouble[3].ToString("n0");
            }
            if (cNeedDouble[4] > 0)
            {
                txtBoxDPower5.Text = cNeedDouble[4].ToString("n0");
            }
            if (cNeedDouble[5] > 0)
            {
                txtBoxDPower6.Text = cNeedDouble[5].ToString("n0");
            }
            if (cNeedDouble[6] > 0)
            {
                txtBoxDPower7.Text = cNeedDouble[6].ToString("n0");
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
                case "剑步": unitSelfPower = unitTotalPowerInfantrySword;
                    break;
                case "矛步": unitSelfPower = unitTotalPowerInfantrySpear;
                    break;
                case "斧步": unitSelfPower = unitTotalPowerInfantryAx;
                    break;
                case "弓": unitSelfPower = unitTotalPowerBow;
                    break;
                case "剑骑": unitSelfPower = unitTotalPowerRideSword;
                    break;
                case "矛骑": unitSelfPower = unitTotalPowerRideSpear;
                    break;
                case "斧骑": unitSelfPower = unitTotalPowerRideAx;
                    break;
                default:
                    break;
            }


        }

        /// <summary>
        /// 选择难度改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxDif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxDif.SelectedIndex == 2)
            {
                MessageBox.Show("游戏系统未开发完毕！切换至普通难度");
                cbBoxDif.SelectedIndex = 0;
            }
            cbBoxLayer.Text = "选择层";
            InitControls();
        }

        /// <summary>
        /// 选择层改变事件，选择好层后将自动列出此层各兵种所需的最大量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitControls();
            //初始化兵力数量
            //兵力数量
            int cSwordInfantry = 0;
            int cSpearInfantry = 0;
            int cAxInfantry = 0;
            int cBow = 0;
            int cSwordRide = 0;
            int cSpearRide = 0;
            int cAxRide = 0;

            var entity = new DB_mysteryData { Difficulty = Convert.ToString(cbBoxDif.SelectedIndex + 1), Level = Convert.ToString(cbBoxLayer.SelectedIndex + 1) };
            var ds = entity.Select(entity);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var soldierType = ds.Tables[0].Rows[i]["soldier_type"].ToString();
                        switch (soldierType)
                        {
                            case "剑步":
                                cSwordInfantry = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "矛步":
                                cSpearInfantry = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "斧步":
                                cAxInfantry = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "弓":
                                cBow = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "剑骑":
                                cSwordRide = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "矛骑":
                                cSpearRide = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                            case "斧骑":
                                cAxRide = Convert.ToInt32(ds.Tables[0].Rows[i]["soldier_count"]);
                                break;
                        }
                    }
                }
            }



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
        private void CbBoxSoldierSelectedIndexChanged(object sender, EventArgs e)
        {
            string preValue = "";
            string difficulty = "";
            string level = "";
            string soldierType = "";

            string cbBoxName = ((ComboBox)sender).Name;

            switch (cbBoxName)
            {
                case "cbBoxSoldier1":
                    preValue = cbBoxSoldier1.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier1.Tag = cbBoxSoldier1.Text;
                    soldierType = cbBoxSoldier1.Text;
                    break;
                case "cbBoxSoldier2":
                    preValue = cbBoxSoldier2.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier2.Tag = cbBoxSoldier2.Text;
                    soldierType = cbBoxSoldier2.Text;
                    break;
                case "cbBoxSoldier3":
                    preValue = cbBoxSoldier3.Tag.ToString();
                    ChangeTxtBoxes(preValue);
                    cbBoxSoldier3.Tag = cbBoxSoldier3.Text;
                    soldierType = cbBoxSoldier3.Text;
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

            var dbMystery = new DB_mysteryData { Difficulty = difficulty, Level = level, Type = soldierType };

            var count = "0";
            var ds = dbMystery.Select(dbMystery);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    count = ds.Tables[0].Rows[0]["soldier_count"].ToString();
                }
            }

            switch (soldierType)
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

            CalculatePower();
        }

        /// <summary>
        /// 出兵排序
        /// </summary>
        private void SortSoldier()
        {
            var dt = new DataTable();
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
            if (String.IsNullOrEmpty(preValue) || cbBoxSoldier1.Tag.Equals(cbBoxSoldier2.Tag) ||
                cbBoxSoldier1.Tag.Equals(cbBoxSoldier3.Tag) || cbBoxSoldier2.Tag.Equals(cbBoxSoldier3.Tag)) return;
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

        /// <summary>
        /// 输入框检查
        /// </summary>
        /// <returns></returns>
        private bool TxtBoxCheck()
        {
            bool hasErrorDigital = false;

            if (!IsOnlyDigital(txtBox_sword.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_spear.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_ax.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_infantry.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_bow.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_ride.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_infantry.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_bow.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_godadd_ride.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_satisfy.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBox_morale.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower1.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower2.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower3.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower4.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower5.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower6.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxPower7.Text))
            {
                hasErrorDigital = true;
            }
            if (!IsOnlyDigital(txtBoxSelfPower.Text))
            {
                hasErrorDigital = true;
            }
            return hasErrorDigital;
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
            CalculatePower();
        }
    }
}