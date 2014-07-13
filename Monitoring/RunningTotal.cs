using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring
{
    public class RunningTotal<T> where T:class
    {
        public String Name;
        public T CurrentValue;

    private RunningTotal<T>(){}
    public RunningTotal<T>(String name):this(){this.Name = name;}
    public RunningTotal<T>(String name, T initalValue)this(){this.ApplyValue(T);}


public abstract T ApplyValue(T);
    }
}
