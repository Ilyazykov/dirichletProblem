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

        public DifferentialEquation()
        {
            F = new FunctionF();
        }

        public override Table getValues(BorderValues borderValues, int numberOfIteration, double eps)
        {
            int sizeX = borderValues.sizeX;
            int sizeY = borderValues.sizeY;

            Table res = new Table(sizeX, sizeY, borderValues.rectangle);

            res = seidelMethod(borderValues, numberOfIteration, eps);

            return res;
        }

        private Table seidelMethod(BorderValues borderValues, int numberOfIteration, double eps)
        {
            throw new NotImplementedException();
        }
    }
}
