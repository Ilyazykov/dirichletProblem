using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dirichletProblem.getterOfValues
{
    abstract class GetterOfValues
    {
        public GetterOfValues()
        {}

        abstract public List<List<double>> getValues(int sizeX, int sizyY);
    }
}
