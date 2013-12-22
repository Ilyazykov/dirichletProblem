using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dirichletProblem.getterOfValues
{
    abstract class getterOfValues
    {
        public getterOfValues()
        {}

        abstract public List<List<double>> getValues();
    }
}
