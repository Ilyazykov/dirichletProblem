using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dirichletProblem.Functions;

namespace dirichletProblem.getterOfValues
{
    class DifferentialEquation : GetterOfValues
    {
        Function F;
        Function U;

        public DifferentialEquation()
        {
            F = new FunctionF();
            U = new FunctionU();
        }

        public override List<List<double>> getValues(int sizeX, int sizeY) //TODO заглушка для тестирования
        {
            List<List<double>> res = new List<List<double>>();

            List<double> row = new List<double>();

            for (int y = 0; y < sizeY; y++)
            {
                row.Add(0.0d);
            }

            for (int x = 0; x < sizeX; x++)
            {
                res.Add(row);
            }

            return res;
        }
    }
}
