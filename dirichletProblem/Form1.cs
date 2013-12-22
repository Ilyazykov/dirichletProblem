using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dirichletProblem.getterOfValues;
using dirichletProblem.Functions;

namespace dirichletProblem
{
    public partial class Form1 : Form
    {
        int sizeX = 4;
        int sizeY = 3;

        Rectangle rectangle;
        Function u;

        Table tableOne;
        Table tableTwo;

        GetterOfValues one;
        GetterOfValues two;

        int numberOfIteration = 50;
        double eps = 0.000001;

        public Form1()
        {
            InitializeComponent();

            one = new testFunction();
            two = new DifferentialEquation();
            u = new FunctionU();
            rectangle = new Rectangle(-1, 1, -1, 1);
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            BorderValues borderValues = new BorderValues(rectangle, sizeX, sizeY, u);

            tableOne = one.getValues(borderValues);
            tableTwo = two.getValues(borderValues, numberOfIteration, eps);

            fillTable();
        }

        private void fillTable()
        {
            dataGrid.RowCount = tableOne.sizeY;
            dataGrid.ColumnCount = tableOne.sizeX;

            for (int x = 0; x < sizeX; ++x)
            {
                dataGrid.Columns[x].HeaderText = tableOne.top[x].ToString();
            }

            for (int y = 0; y < sizeY; ++y)
            {
                dataGrid.Rows[y].HeaderCell.Value = tableOne.left[y].ToString();
            }

            for (int y = 0; y < sizeY; ++y)
            {
                for (int x = 0; x < sizeX; ++x)
                {
                    dataGrid.Rows[y].Cells[x].Value = tableOne[x, y];
                }
            }
        }
    }
}
