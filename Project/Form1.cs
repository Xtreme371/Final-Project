using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            grpbSimulation.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        // alfabet represents the row of buttons on the form

        //FIND SHORTEST ROUTE
        string a0 = "E", a1 = "-", a2 = "-", a3 = "-", a4 = "-", a5 = "-";  // E is the end point
        string b0 = "-", b1 = "-", b2 = "-", b3 = "-", b4 = "-", b5 = "-";
        string c0 = "-", c1 = "-", c2 = "-", c3 = "-", c4 = "-", c5 = "-";
        string d0 = "-", d1 = "-", d2 = "-", d3 = "-", d4 = "-", d5 = "-";
        string e0 = "-", e1 = "-", e2 = "-", e3 = "-", e4 = "-", e5 = "S"; // S is the starting point
        

        public class matrixNode
        {
            public int fr = 0, to = 0, sum = 0;
            public int x, y;
            public matrixNode parent;
        }

        public static matrixNode AStar(string[][] matrix, int fromX, int fromY, int toX, int toY)
        {

            //the keys for greens and reds are x.ToString() + y.ToString() of the matrixNode 


            Dictionary<string, matrixNode> greens = new Dictionary<string, matrixNode>(); //open 
            Dictionary<string, matrixNode> reds = new Dictionary<string, matrixNode>(); //closed 

            matrixNode startNode = new matrixNode { x = fromX, y = fromY };
            string key = startNode.x.ToString() + startNode.x.ToString();
            greens.Add(key, startNode);

            Func<KeyValuePair<string, matrixNode>> smallestGreen = () =>
            {
                KeyValuePair<string, matrixNode> smallest = greens.ElementAt(0);

                foreach (KeyValuePair<string, matrixNode> item in greens)
                {
                    if (item.Value.sum < smallest.Value.sum)
                        smallest = item;
                    else if (item.Value.sum == smallest.Value.sum
                            && item.Value.to < smallest.Value.to)
                        smallest = item;
                }

                return smallest;
            };
            //add these values to current nodes x and y to get the left/up/right/bottom neighbors
            List<KeyValuePair<int, int>> fourNeighbors = new List<KeyValuePair<int, int>>()
                                            { new KeyValuePair<int, int>(-1,0),
                                              new KeyValuePair<int, int>(0,1),
                                              new KeyValuePair<int, int>(1, 0),
                                              new KeyValuePair<int, int>(0,-1) };

            int maxX = matrix.GetLength(0);
            if (maxX == 0)
                return null;
            int maxY = matrix[0].Length;

            while (true)
            {
                if (greens.Count == 0)
                    return null;

                KeyValuePair<string, matrixNode> current = smallestGreen();
                if (current.Value.x == toX && current.Value.y == toY)
                    return current.Value;

                greens.Remove(current.Key);
                reds.Add(current.Key, current.Value);

                foreach (KeyValuePair<int, int> plusXY in fourNeighbors)
                {
                    int nbrX = current.Value.x + plusXY.Key;
                    int nbrY = current.Value.y + plusXY.Value;
                    string nbrKey = nbrX.ToString() + nbrY.ToString();
                    if (nbrX < 0 || nbrY < 0 || nbrX >= maxX || nbrY >= maxY
                        || matrix[nbrX][nbrY] == "X" //obstacles marked by 'X'
                        || reds.ContainsKey(nbrKey))
                        continue;

                    if (greens.ContainsKey(nbrKey))
                    {
                        matrixNode curNbr = greens[nbrKey];
                        int from = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                        if (from < curNbr.fr)
                        {
                            curNbr.fr = from;
                            curNbr.sum = curNbr.fr + curNbr.to;
                            curNbr.parent = current.Value;
                        }
                    }
                    else
                    {
                        matrixNode curNbr = new matrixNode { x = nbrX, y = nbrY };
                        curNbr.fr = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                        curNbr.to = Math.Abs(nbrX - toX) + Math.Abs(nbrY - toY);
                        curNbr.sum = curNbr.fr + curNbr.to;
                        curNbr.parent = current.Value;
                        greens.Add(nbrKey, curNbr);
                    }
                }
            }
        }
        public void StartFly()//method to start the mission
        {
            grpbSimulation.SendToBack();
            lblScout.BringToFront();

            string[][] matrix = new string[6][];        // jagged array
            matrix[0] = new string[6] {a0, a1, a2, a3, a4, a5 };
            matrix[1] = new string[6] { b0, b1, b2, b3, b4, b5 };
            matrix[2] = new string[6] { c0, c1, c2, c3, c4, c5 };
            matrix[3] = new string[6] { d0, d1, d2, d3, d4, d5 };
            matrix[4] = new string[6] { e0, e1, e2, e3, e4, e5 };  
        }
        public void FlyBack() //method to end mission and go home
        {
            lblHomebase.BringToFront();

            // changes start and end point 
            a5 = "S";
            e0 = "E";

            //flip the coordinates
            string[][] matrix = new string[5][];
            matrix[4] = new string[5] { a5, a4, a3, a2, a1 };
            matrix[3] = new string[5] { b5, b4, b3, b2, b1 };
            matrix[2] = new string[5] { c5, c4, c3, c2, c1 };
            matrix[1] = new string[5] { d5, d4, d3, d2, d1 };
            matrix[0] = new string[5] { e5, e4, e3, e2, e1 };

            int fromX = 7, fromY = 7, toX = 0, toY = 0;
            matrixNode endNode = AStar(matrix, fromX, fromY, toX, toY);
            //what happens when start button is clicked
        }
            public void BtnStart_Click(object sender, EventArgs e)
        {
            // can't place objects in an entire row. If row if full there will be no routes to take
            if (a0 == "X" && a1 == "X" && a2 == "X" && a3 == "X" && a4 == "X" && a5 == "X")
            {
                a0 = "-";
                a1 = "-";
                a2 = "-";
                a3 = "-";
                a4 = "-";
                a5 = "-";
                throw new NoRouteException("No routes were found with the current setting");//custom exception class
            }
            if (b0 == "X" && b1 == "X" && b2 == "X" && b3 == "X" && b4 == "X" && b5 == "X")
            {
                b0 = "-";
                b1 = "-";
                b2 = "-";
                b3 = "-";
                b4 = "-";
                b5 = "-";
                throw new NoRouteException("No routes were found with the current setting");//requires custom exception class
            }
            else if (c0 == "X" && c1 == "X" && c2 == "X" && c3 == "X" && c4 == "X" && c5 == "X")
            {
                c0 = "-";
                c1 = "-";
                c2 = "-";
                c3 = "-";
                c4 = "-";
                c5 = "-";
                throw new NoRouteException("No routes were found with the current setting");
            }
            else if (d0 == "X" && d1 == "X" && d2 == "X" && d3 == "X" && d4 == "X" && d5 == "X")
            {
                d0 = "-";
                d1 = "-";
                d2 = "-";
                d3 = "-";
                d4 = "-";
                d5 = "-";
                throw new NoRouteException("No routes were found with the current setting");
            }
            else if (e0 == "X" && e1 == "X" && e2 == "X" && e3 == "X" && e4 == "X" && e5 == "X")
            {
                e0 = "-";
                e1 = "-";
                e2 = "-";
                e3 = "-";
                e4 = "-";
                e5 = "-";
                throw new NoRouteException("No routes were found with the current setting");
            }
            else
            {
                //if there possible route the the following happens
                StartFly();
                // show enemy territory for 5 seconds
                EnemyTerritory open = new EnemyTerritory(); // we need to this 
                open.Show();
                Thread.Sleep(5000);
                open.Hide();

                Thread.Sleep(500);
                MessageBox.Show("Enemy spotted and eliminated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string strikeTime = DateTime.Now.ToString("h:mm:ss tt");

                //return home
                FlyBack();
                MessageBox.Show("You have arrived at homebase", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //The points on form that act as coordinates in matrix
        private void Btn1_Click(object sender, EventArgs e)
        {
            a0 = "E";
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            a5 = "X";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            a4 = "X";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            a3 = "X";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            a2 = "X";
        }

        

        private void Btn7_Click(object sender, EventArgs e)
        {
            b0 = "X";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            b1 = "X";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            b2 = "X";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            b3 = "X";
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            b4 = "X";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            b5 = "X";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            c0 = "X";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            c1 = "X";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            c2 = "X";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            c3 = "X";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            c4 = "X";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            c5 = "X";
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            d0 = "X";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            d1 = "X";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            d2 = "X";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            d3 = "X";
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            d4 = "X";
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            d5 = "X";
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            e0 = "X";
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            e1 = "X";
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            e2 = "X";
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            e3 = "X";
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            e4 = "X";
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            e5 = "S";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            a1 = "X";
        }


        //exit the program 
        private void BtnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
