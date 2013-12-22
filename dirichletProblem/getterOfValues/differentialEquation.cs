using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dirichletProblem.Functions;

namespace dirichletProblem.getterOfValues
{
    class differentialEquation : getterOfValues
    {
        Function F;
        Function U;

        public differentialEquation()
        {
            F = new FunctionF();
            U = new FunctionU();
        }

        public override List<List<double>> getValues() //TODO заглушка для тестирования
        {
            int sizeX = 4;
            int sizeY = 4;
            List<List<double>> res = new List<List<double>>(sizeX);
            for (int i = 0; i < sizeX; i++)
            {
                res[i] = new List<double>(sizeY);
            }
            return res;
        }
    }
}
