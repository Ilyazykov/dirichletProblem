using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dirichletProblem.getterOfValues;

namespace dirichletProblem
{
    public partial class Form1 : Form
    {
        int sizeX = 4;
        int sizeY = 5;
        List<List<double>> values;
        GetterOfValues getter;

        public Form1()
        {
            InitializeComponent();

            getter = new DifferentialEquation();
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            values = getter.getValues(sizeX, sizeY);
            fillTable();
        }

        private void fillTable()
        {
            dataGrid.RowCount = sizeX;
            dataGrid.ColumnCount = sizeY;

            for (int x = 0; x < sizeX; ++x)
            {
                for (int y = 0; y < sizeY; ++y)
                {
                    dataGrid.Rows[x].Cells[y].Value = values[x][y];
                }
            }
        }
    }
}
