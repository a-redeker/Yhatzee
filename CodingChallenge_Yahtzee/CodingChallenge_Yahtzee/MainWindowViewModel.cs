using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Data.Mask;
using DevExpress.XtraExport;

namespace CodingChallenge_Yahtzee
{
    public class MainWindowViewModel
    {
        Random ran = new Random();
        Stopwatch x = new Stopwatch();
        Stopwatch y = new Stopwatch();
        BackgroundWorker worker = new BackgroundWorker();

        public virtual int upperBonus { get; set; } = 35;
        public virtual int rolled { get; set; }
        public virtual bool canRoll { get; set; } = true;
        public virtual bool canNext { get; set; }
        public virtual bool activeBonus { get; set; }
        public virtual bool allowBonus { get; set; }
        private bool yesFH2 { get; set; }
        private bool yesFH3 { get; set; }

        public virtual ObservableCollection<int> scoring { get; set; } =
            new ObservableCollection<int>(new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        );
        public virtual ObservableCollection<int> dieIn { get; set; } =
            new ObservableCollection<int>(new List<int>() { 1, 1, 1, 1, 1 });
        public virtual ObservableCollection<int> count { get; set; } =
            new ObservableCollection<int>(new List<int>() { 0, 0, 0, 0, 0, 0 });
        public virtual ObservableCollection<bool> canScore { get; set; } =
            new ObservableCollection<bool>(new List<bool>()
            {
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false,
                false
            });
        public virtual ObservableCollection<bool> unused { get; set; } =
            new ObservableCollection<bool>(new List<bool>()
            {
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                true
            });
        public virtual ObservableCollection<bool> scored { get; set; } =
            new ObservableCollection<bool>(new List<bool>()
            {
                false, //1's            0
                false, //2's            1
                false, //3's            2
                false, //4's            3
                false, //5's            4
                false, //6's            5
                false, //Upper Bonusd   6
                false, //3 of a kind    7
                false, //4 of a kind    8
                false, //YAHTZEE        9
                false, //YAHTZEE BONUS  10
                false, //LG Straight    11
                false, //SM Straight    12
                false, //Full House     13
                false  //Chance         14
            });
        public virtual ObservableCollection<bool> hold { get; set; } =
            new ObservableCollection<bool>(new List<bool>()
            {
                false,
                false,
                false,
                false,
                false
            });

        public MainWindowViewModel()
        {
            worker.DoWork += Worker_DoWork;

        }

        public virtual void nextTurn()
        {
            canRoll = true;
            rolled = 0;
            canNext = false;

            for (int i = 0; i < 5; i++)
            {
                hold[i] = false;
                dieIn[i] = 1;
            }

        }

        public virtual void roll()
        {
            if (rolled < 2)
            {
                try
                {
                    worker.RunWorkerAsync();
                }
                catch (InvalidOperationException e)
                {

                }

                used();
            }

            else
            {
                try
                {
                    worker.RunWorkerAsync();
                }
                catch (InvalidOperationException e)
                {

                }

                used();

                canRoll = false;
            }

            rolled++;
            canNext = true;
        }

        public virtual void sort()
        {
            for (int i = 0; i < 5; i++)
            {
                if (dieIn[i] == (1))
                {
                    count[0]++;
                }
                if (dieIn[i] == (2))
                {
                    count[1]++;
                }
                if (dieIn[i] == (3))
                {
                    count[2]++;
                }
                if (dieIn[i] == (4))
                {
                    count[3]++;
                }
                if (dieIn[i] == (5))
                {
                    count[4]++;
                }
                if (dieIn[i] == (6))
                {
                    count[5]++;
                }
            }
        }

        public virtual void used()
        {
            for (int i = 0; i < 15; i++)
            {
                canScore[i] = unused[i];
            }
            if (allowBonus)
            {
                activeBonus = true;
            }
        }

        public virtual void done()
        {
            if (!unused[0] && !unused[1] && !unused[2] && !unused[3] && !unused[4] && 
                !unused[5] && !unused[7] && !unused[8] && !unused[9] && !unused[10] && 
                !unused[11] && !unused[12] && !unused[13] && !unused[14])
            {
                MessageBoxResult result =
                    MessageBox.Show("Game Over! You Scored: " + scoring[17] + " Do you want to play again?",
                        "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    for (int i = 0; i < 17; i++)
                    {
                        scoring[i] = 0;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        canScore[i] = false;
                        unused[i] = true;
                        scored[i] = false;
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        count[i] = 0;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        dieIn[i] = 1;
                        hold[i] = false;
                    }
                }
            }
        }

        public virtual void totalScore()
        {
            scoring[17] = scoring[15] + scoring[16];
        }

        public virtual void upperScore()
        {
            scoring[15] = scoring[0] + scoring[1] + scoring[2] + scoring[3] +
                          scoring[4] + scoring[5] + scoring[6];

            if (scoring[15] > 62)
            {
                scoring[6] = 35;
            }

            totalScore();
        }

        public virtual void lowerScore()
        {
            scoring[16] = scoring[7] + scoring[8] + scoring[9] + scoring[10] +
                          scoring[11] + scoring[12] + scoring[13] + scoring[14];

            totalScore();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
                count[i] = 0;
            }

            x.Start();
            while (x.Elapsed < TimeSpan.FromSeconds(1.8))
            {
                y.Start();
                if (!hold[0])
                {
                    while (y.Elapsed < TimeSpan.FromSeconds(0.18))
                        dieIn[0] = ran.Next(1, 7);
                }
                if (!hold[1])
                {
                    while (y.Elapsed < TimeSpan.FromSeconds(0.36))
                        dieIn[1] = ran.Next(1, 7);
                }
                if (!hold[2])
                {
                    while (y.Elapsed < TimeSpan.FromSeconds(0.54))
                        dieIn[2] = ran.Next(1, 7);
                }
                if (!hold[3])
                {
                    while (y.Elapsed < TimeSpan.FromSeconds(0.72))
                        dieIn[3] = ran.Next(1, 7);

                }
                if (!hold[4])
                {
                    while (y.Elapsed < TimeSpan.FromSeconds(0.9))
                        dieIn[4] = ran.Next(1, 7);

                }
                y.Reset();
            }
            x.Reset();

            sort();
        }

        public virtual void ones()
        {
            unused[0] = false;

            canRoll = false;

            scoring[0] = 1 * count[0];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();
        }

        public virtual void twos()
        {
            unused[1] = false;

            canRoll = false;

            scoring[1] = 2 * count[1];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();

        }

        public virtual void threes()
        {
            unused[2] = false;

            canRoll = false;

            scoring[2] = 3 * count[2];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();

        }

        public virtual void fours()
        {
            unused[3] = false;

            canRoll = false;

            scoring[3] = 4 * count[3];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();

        }

        public virtual void fives()
        {
            unused[4] = false;

            canRoll = false;

            scoring[4] = 5 * count[4];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();

        }

        public virtual void sixes()
        {
            unused[5] = false;

            canRoll = false;

            scoring[5] = 6 * count[5];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            upperScore();
            done();

        }

        public virtual void kind3()
        {
            unused[7] = false;

            canRoll = false;

            if (count[0] == 4)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else if (count[1] == 3)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else if (count[2] == 3)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else if (count[3] == 3)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else if (count[4] == 3)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else if (count[5] == 3)
            {
                scoring[7] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
            else
            {
                scoring[7] = 0;
            }

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void kind4()
        {
            unused[8] = false;

            canRoll = false;

            
                if (count[0] == 4)
                {
                    scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
                }
                else if (count[1] == 4)
                {
                scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
                else if (count[2] == 4)
                {
                    scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
                else if (count[3] == 4)
                {
                    scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
                else if (count[4] == 4)
                {
                    scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
            }
                else if (count[5] == 4)
                {
                    scoring[8] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];
                }
            else
                {
                    scoring[8] = 0;
                }
            

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void yahtzee()
        {
            unused[9] = false;

            canRoll = false;


            if (count[0] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else if (count[1] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else if (count[2] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else if (count[3] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else if (count[4] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else if (count[5] == 5)
            {
                scoring[9] = 50;
                allowBonus = true;
                unused[10] = true;
            }
            else
            {
                scoring[9] = 0;
            }


            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void yBonus()
        {
            unused[10] = false;

            activeBonus = false;

            canRoll = false;


            if (count[0] == 5)
            {
                scoring[10] += 100;
            }
            else if (count[1] == 5)
            {
                scoring[10] += 100;
            }
            else if (count[2] == 5)
            {
                scoring[10] += 100;
            }
            else if (count[3] == 5)
            {
                scoring[10] += 100;
            }
            else if (count[4] == 5)
            {
                scoring[10] += 100;
            }
            else if (count[5] == 5)
            {
                scoring[10] += 100;
            }
            else
            {
                scoring[10] += 0;
                allowBonus = false;
            }


            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void lgStraight()
        {
            unused[11] = false;

            canRoll = false;

            activeBonus = false;


            if ((count[0] == 1) && (count[1] == 1) && (count[2] == 1) && (count[3] == 1) && (count[4] == 1))
            {
                scoring[11] = 40;
            }
            else if ((count[1] == 1) && (count[2] == 1) && (count[3] == 1) && (count[4] == 1) && (count[5] == 1))
            {
                scoring[11] = 40;
            }
            else
            {
                scoring[11] = 0;
            }


            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void smStraight()
        {
            unused[12] = false;

            canRoll = false;

            activeBonus = false;

            if ((count[0] >= 1) && (count[1] >= 1) && (count[2] >= 1) && (count[3] >= 1))
            {
                scoring[12] = 30;
            }
            else if ((count[1] >= 1) && (count[2] >= 1) && (count[3] >= 1) && (count[4] >= 1))
            {
                scoring[12] = 30;
            }
            else if ((count[2] >= 1) && (count[3] >= 1) && (count[4] >= 1) && (count[5] >= 1))
            {
                scoring[12] = 30;
            }
            else
            {
                scoring[12] = 0;
            }

            lowerScore();
            done();

        }

        public virtual void fullHouse()
        {
            unused[13] = false;

            canRoll = false;

            activeBonus = false;

            for (int i = 0; i < 6; i++)
            {
                if (count[i] == 3)
                {
                    yesFH3 = true;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (count[i] == 2)
                {
                    yesFH2 = true;
                }
            }

            if (yesFH2 && yesFH3)
            {
                scoring[13] = 25;
            }

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }

        public virtual void chance()
        {
            unused[14] = false;

            canRoll = false;

            activeBonus = false;

            scoring[14] = dieIn[0] + dieIn[1] + dieIn[2] + dieIn[3] + dieIn[4];

            for (int i = 0; i < 15; i++)
            {
                canScore[i] = false;
            }

            lowerScore();
            done();

        }
    }
}