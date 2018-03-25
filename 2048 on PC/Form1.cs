using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace _2048_on_PC
{
    public partial class MainForm : Form
    {
        private int[,] tiles = new int[4,4]; //各タイルの情報
        private int tilenum = 0;//タイルの枚数
        private bool cleared = false;
        private int score = 0; //得点
        private bool isundoable = false; //アンドゥできるか
        private int nextwrite = 0; 
        private int record = 0;
        private int[][,] backnumber = new int[21][,];
        private int[] pastscore = new int[21];
        private int[] pasttilenum = new int[21];
        private bool backupfilled = false;
        private void inittable()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    tiles[i, j] = 0;
            for (int i = 0; i < 21; i++)
            {
                backnumber[i] = new int[4, 4];
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        backnumber[i][j, k] = 0;
                    }
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
            inittable();
        }
        private void drawtiles()
        {
            disptile(ref tile11, ref tiles[0, 0]);
            disptile(ref tile12, ref tiles[0, 1]);
            disptile(ref tile13, ref tiles[0, 2]);
            disptile(ref tile14, ref tiles[0, 3]);
            disptile(ref tile21, ref tiles[1, 0]);
            disptile(ref tile22, ref tiles[1, 1]);
            disptile(ref tile23, ref tiles[1, 2]);
            disptile(ref tile24, ref tiles[1, 3]);
            disptile(ref tile31, ref tiles[2, 0]);
            disptile(ref tile32, ref tiles[2, 1]);
            disptile(ref tile33, ref tiles[2, 2]);
            disptile(ref tile34, ref tiles[2, 3]);
            disptile(ref tile41, ref tiles[3, 0]);
            disptile(ref tile42, ref tiles[3, 1]);
            disptile(ref tile43, ref tiles[3, 2]);
            disptile(ref tile44, ref tiles[3, 3]);
            scorelabel.Text = "Score: " + score.ToString();
        }
        private void disptile(ref System.Windows.Forms.Label tile, ref int num)
        {
            if (num == 0)
            {
                tile.Text = "";
                tile.BackColor = Color.LightGray;
                tile.ForeColor = Color.Black;
            }
            else
            {
                tile.Text = (1 << num).ToString();
                tile.ForeColor = num <= 2 ? Color.Black : Color.White;
                switch (num)
                {
                    case 1: //2
                        tile.BackColor = Color.White;
                        break;
                    case 2://4
                        tile.BackColor = Color.FromArgb(255,255,204);
                        break;
                    case 3: //8
                        tile.BackColor = Color.FromArgb(255,192,192);
                        break;
                    case 4: //16
                        tile.BackColor = Color.FromArgb(255,128,128);
                        break;
                    case 5: //32
                        tile.BackColor = Color.FromArgb(255,96,96);
                        break;
                    case 6: //64
                        tile.BackColor = Color.Red;
                        break;
                    case 7: //128
                        tile.BackColor = Color.FromArgb(255, 255, 64);
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        tile.BackColor = Color.Yellow;
                        break;
                    default:
                        tile.BackColor = Color.Black;
                        break;
                }
            }
        }

        private void dispmestotile(ref System.Windows.Forms.Label tile,string mes,Color back,Color fore)
        {
            tile.BackColor = back;
            tile.ForeColor = fore;
            tile.Text = mes;
        }
        private void gameover()
        {
            toplabel.Text = "Game Over!";
            bottomlabel.Text = "S・R→リスタート" + (isundoable ? "　U or BS→アンドゥ" : "") + "\r\nQ→やめる";
            tilenum = -1;
        }

        private void cleartiles()
        {
            for (int i = 0; i < 4; i++) for (int j = 0; j < 4; j++) tiles[i, j] = 0;
            tilenum = 0;
            cleared = false;
        }

        /// <summary>
        /// 整数を論理型に変換する(Cと同じ挙動をさせる)
        /// </summary>
        /// <param name="num">数字</param>
        /// <returns>真偽値</returns>
        private bool ToBool(int num)
        {
            return num != 0;
        }

        /// <summary>
        /// 乱数を返す。
        /// </summary>
        /// <param name="lessthan">0～何未満か(何通りとるか)</param>
        /// <returns>乱数</returns>
        private int getrandom(int lessthan)
        {
            int ret;
            byte[] rand = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            do
            {
                rng.GetBytes(rand);
                ret = (rand[0] | ((int)rand[1] << 8) | ((int)rand[2] << 16) | (((int)rand[3] & 0x3f) << 24));
            } while (ret >= 0x40000000 / lessthan * lessthan);
            return ret % lessthan;
        }

        /// <summary>
        /// 乱数を返す。(0～2の冪;2の冪通り)
        /// </summary>
        /// <param name="digit">2進数で何桁取るか(2の何乗通りとるか)</param>
        /// <returns>乱数</returns>
        private int getrandombybit(int digit)
        {
            byte[] rn = new byte[1];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(rn);
            return (int)rn[0] & ((1 << digit) - 1); //下digit桁取る
        }

        private void gameclear()
        {
            toplabel.Text = "Game Clear!";
            bottomlabel.Text = "S・R→リスタート　Q→やめる\r\nU or BS→アンドゥON/OFF切り替え";
            tilenum = -2;
        }

        private void copytable(ref int[,] to, ref int[,] from)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    to[i, j] = from[i, j];
                }
            }
        }

        private void backup()
        {
            if (!isundoable) return;
            if (nextwrite == record)
            { //既に記録されているところに上書き
                record = (record + 1) % 21;
                if (record == 0) backupfilled = true;
            }
            copytable(ref backnumber[nextwrite], ref tiles); //現在のタイル状態をコピー
            pastscore[nextwrite] = score;
            pasttilenum[nextwrite] = tilenum;
            nextwrite = (nextwrite + 1) % 21;
        }

        private void undotile()
        {
            if (nextwrite == (record + 1) % 21 || !backupfilled && nextwrite == 1) return; //限界
            if (tilenum == -1)
            {
                toplabel.Text = "";
                bottomlabel.Text = "R→リスタート" + (isundoable ? "　U or BS→アンドゥ" : "") + "\r\nQ→やめる　矢印→動かす";
            }
            nextwrite = (nextwrite + 20) % 21; //1つ前
            int cpyfrm = (nextwrite + 20) % 21; //コピー元
            copytable(ref tiles, ref backnumber[cpyfrm]);
            score = pastscore[cpyfrm];
            tilenum = pasttilenum[cpyfrm];
        }

        private bool ismovable()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    int k;
                    if (i < 3)
                    {
                        for (k = i + 1; k < 3 && tiles[k, j] == 0; k++) ;
                        if (tiles[i, j] == tiles[k, j]) return true;
                    }
                    if (j < 3)
                    {
                        for (k = j + 1; k < 3 && tiles[i, k] == 0; k++) ;
                        if (tiles[i, j] == tiles[i, k]) return true;
                    }
                }
            return false;
        } 

        private bool puttile(int pos)
        {
            int tilecount = 0;
            if(tilenum == 16) return false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tiles[i, j] == 0)
                    {
                        if (tilecount == pos)
                        {
                            tiles[i, j] = ToBool(getrandombybit(3)) ? 1 : 2;
                            tilenum++;
                            goto loopbreak;
                        }
                        tilecount++;
                    }
                }
            }
            loopbreak:;
            return true;
        }

        private void putinittiles()
        {
            int i = 0;
            int[] tilepos = new int[2] {getrandombybit(4),getrandom(15)};
            if (tilepos[1] >= tilepos[0]) tilepos[1]++;
            int[] tiletyp = new int[2] { getrandombybit(3),getrandombybit(3)};
            for (; i < 2; i++)
            {
                tiles[tilepos[i] >> 2, tilepos[i] & 3] = ToBool(tiletyp[i]) ? 1 : 2;
            }
            tilenum = 2;
            score = 0;
            toplabel.Text = "";
            bottomlabel.Text = "R→リスタート" + (isundoable ? "　U or BS→アンドゥ" : "") + "\r\nQ→やめる　矢印→動かす";
            nextwrite = 0;
            record = 0;
            backup();
        }

        private bool uptiles()
        {
            int j;
            bool moved = false;
            for (int i = 0; i < 4; i++)
            { //列
                int dest = 0; //タイルの移動先の行
                int val = 0; //結合候補
                for (j = 0; j < 4; j++)
                { //行
                    if (tiles[j, i] != 0) //数のタイル発見
                    {
                        if (tiles[j, i] == val) //結合候補のタイルと番号が同じ
                        {
                            score += 2 << val; //得点加算
                            if(++tiles[dest - 1, i] == 11) cleared = true; //タイルを結合、移動先はそのまま ついでにクリア判定
                            tiles[j, i] = 0; //現在位置は消去
                            val = 0; //結合しない設定に
                            tilenum--; //1つタイルが減る
                            moved = true;
                        }
                        else
                        {
                            if (j == dest) //タイルが連続(動かせない)
                            {
                                dest++; //移動先候補をすぐ下に
                                val = tiles[j, i]; //結合候補のタイル変更
                            }
                            else //タイルの間に隙間がある(詰めないといけない)
                            {
                                val = tiles[j, i];
                                tiles[dest++, i] = tiles[j, i]; //タイルコピー、結合候補も移動
                                tiles[j, i] = 0; //現在位置は消去
                                moved = true;
                            }
                        }
                    }

                }
            }
            if (cleared)
            {
                gameclear();
                return true;
            }
            if (tilenum == 16 && !ismovable())
            {
                gameover();
                return false;
            }
            if (!moved) return false; //動かせなかったら抜ける
            puttile(getrandom(16-tilenum));
            if (isundoable) backup();
            return true;
        }
        private bool downtiles()
        {
            int j;
            bool moved = false;
            for (int i = 0; i < 4; i++)
            { //列
                int dest = 3; //タイルの移動先の行
                int val = 0; //結合候補
                for (j = 3; j >= 0; j--)
                { //行
                    if (tiles[j, i] != 0) //数のタイル発見
                    {
                        if (tiles[j, i] == val) //結合候補のタイルと番号が同じ
                        {
                            score += 2 << val; //得点加算
                            if(++tiles[dest + 1, i] == 11) cleared = true; //タイルを結合、移動先はそのまま
                            tiles[j, i] = 0; //現在位置は消去
                            val = 0; //結合しない設定に
                            tilenum--; //1つタイルが減る
                            moved = true;
                        }
                        else
                        {
                            if (j == dest) //タイルが連続(動かせない)
                            {
                                dest--; //移動先候補をすぐ上に
                                val = tiles[j, i]; //結合候補のタイル変更
                            }
                            else //タイルの間に隙間がある(詰めないといけない)
                            {
                                val = tiles[j, i];
                                tiles[dest--, i] = tiles[j, i]; //タイルコピー、結合候補も移動
                                tiles[j, i] = 0; //現在位置は消去
                                moved = true;
                            }
                        }
                    }

                }
            }
            if (cleared)
            {
                gameclear();
                return true;
            }
            if (tilenum == 16 && !ismovable())
            {
                gameover();
                return false;
            }
            if (!moved) return false; //動かせなかったら抜ける
            puttile(getrandom(16 - tilenum));
            if (isundoable) backup();
            return true;
        }
        private bool lefttiles()
        {
            int i;
            bool moved = false;
            for (int j = 0; j < 4; j++)
            { //行
                int dest = 0; //タイルの移動先の列
                int val = 0; //結合候補
                for (i = 0; i < 4; i++)
                { //列
                    if (tiles[j,i] != 0) //数のタイル発見
                    {
                        if (tiles[j,i] == val) //結合候補のタイルと番号が同じ
                        {
                            score += 2 << val; //得点加算
                            if(++tiles[j,dest-1] == 11) cleared = true; //タイルを結合、移動先はそのまま
                            tiles[j,i] = 0; //現在位置は消去
                            val = 0; //結合しない設定に
                            tilenum--; //1つタイルが減る
                            moved = true;
                        }
                        else
                        {
                            if (i == dest) //タイルが連続(動かせない)
                            {
                                dest++; //移動先候補をすぐ右に
                                val = tiles[j,i]; //結合候補のタイル変更
                            }
                            else //タイルの間に隙間がある(詰めないといけない)
                            {
                                val = tiles[j,i];
                                tiles[j,dest++] = tiles[j,i]; //タイルコピー、結合候補も移動
                                tiles[j,i] = 0; //現在位置は消去
                                moved = true;
                            }
                        }
                    }

                }
            }
            if (cleared)
            {
                gameclear();
                return true;
            }
            if (tilenum == 16 && !ismovable())
            {
                gameover();
                return false;
            }
            if (!moved) return false; //動かせなかったら抜ける
            puttile(getrandom(16 - tilenum));
            if (isundoable) backup();
            return true;
        }
        private bool righttiles()
        {
            int i;
            bool moved = false;
            for (int j = 0; j < 4; j++)
            { //行
                int dest = 3; //タイルの移動先の列
                int val = 0; //結合候補
                for (i = 3; i >= 0; i--)
                { //列
                    if (tiles[j, i] != 0) //数のタイル発見
                    {
                        if (tiles[j, i] == val) //結合候補のタイルと番号が同じ
                        {
                            score += 2 << val; //得点加算
                            if(++tiles[j,dest+1] == 11) cleared = true; //タイルを結合、移動先はそのまま
                            tiles[j, i] = 0; //現在位置は消去
                            val = 0; //結合しない設定に
                            tilenum--; //1つタイルが減る
                            moved = true;
                        }
                        else
                        {
                            if (i == dest) //タイルが連続(動かせない)
                            {
                                dest--; //移動先候補をすぐ左に
                                val = tiles[j, i]; //結合候補のタイル変更
                            }
                            else //タイルの間に隙間がある(詰めないといけない)
                            {
                                val = tiles[j, i];
                                tiles[j,dest--] = tiles[j, i]; //タイルコピー、結合候補も移動
                                tiles[j, i] = 0; //現在位置は消去
                                moved = true;
                            }
                        }
                    }

                }
            }
            if (cleared)
            {
                gameclear();
                return true;
            }
            if (tilenum == 16 && !ismovable())
            {
                gameover();
                return false;
            }
            if (!moved) return false; //動かせなかったら抜ける
            puttile(getrandom(16 - tilenum));
            if (isundoable) backup();
            return true;
        }

        private void FormOnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                    if (tilenum > 0) return;
                    if (tilenum < 0) goto case Keys.R;
                    putinittiles();
                    break;
                case Keys.Q:
                    if (tilenum == 0) return;
                    cleartiles();
                    toplabel.Text = "2048 on PC";
                    bottomlabel.Text = "S→スタート\r\nU or BS→アンドゥON/OFF切り替え";
                    break;
                case Keys.R:
                    if (tilenum == 0) return;
                    cleartiles();
                    putinittiles();
                    break;
                case Keys.U:
                case Keys.Back:
                    if (tilenum == 0 || tilenum == -2)
                    { //ゲーム中でない(Classic/Practice切り替え)
                        isundoable = !isundoable;
                        undolabel.Text = "UNDO" + (isundoable ? "○" : "×");
                    }
                    else
                    {
                        if (!isundoable) return;
                        undotile();
                    }
                    break;
                case Keys.Up:
                    if (tilenum <= 0) return;
                    if (!uptiles()) return;
                    break;
                case Keys.Right:
                    if (tilenum <= 0) return;
                    if (!righttiles()) return;
                    break;
                case Keys.Down:
                    if (tilenum <= 0) return;
                    if (!downtiles()) return;
                    break;
                case Keys.Left:
                    if (tilenum <= 0) return;
                    if (!lefttiles()) return;
                    break;
                default:
                    return;
            }
            drawtiles();
        }
    }
}
