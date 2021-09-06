using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    public interface IServiceSql
    {
        [OperationContract]
        void Remove(string text);

        [OperationContract]
        void Add(string text);

        [OperationContract]
        string GetBlackList();
    }
}
