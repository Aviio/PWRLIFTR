using System;
using Pwrliftr.Model;

namespace Pwrliftr.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("PWRLIFTR");
            callback(item, null);
        }
    }
}