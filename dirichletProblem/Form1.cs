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
        Function u = new FunctionU();

        double a = -1;
        double b = 1;
        double c = -1;
        double d = 1;

        int sizeX = 4;
        int sizeY = 3;
        Table table;
        GetterOfValues getter;

        public Form1()
        {
            InitializeComponent();

            getter = new testFunction();
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(a, b, c, d);
            BorderValues borderValues = new BorderValues(rectangle, sizeX, sizeY, u);
            table = getter.getValues(borderValues);
            fillTable();
        }

        private void fillTable()
        {
            dataGrid.RowCount = table.sizeY;
            dataGrid.ColumnCount = table.sizeX;

            for (int x = 0; x < sizeX; ++x)
            {
                dataGrid.Columns[x].HeaderText = table.top[x].ToString();
            }

            for (int y = 0; y < sizeY; ++y)
            {
                dataGrid.Rows[y].HeaderCell.Value = table.left[y].ToString();
            }

            for (int y = 0; y < sizeY; ++y)
            {
                for (int x = 0; x < sizeX; ++x)
                {
                    dataGrid.Rows[y].Cells[x].Value = table[x, y];
                }
            }
        }
    }
}
