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

        public override Table getValues(BorderValues borderValues) //TODO заглушка для тестирования
        {
            int sizeX = borderValues.sizeX;
            int sizeY = borderValues.sizeY;

            Table res = new Table(sizeX, sizeY, borderValues.rectangle);

            return res;
        }
    }
}
