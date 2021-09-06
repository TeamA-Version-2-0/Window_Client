using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class NetworkClient
    {
        public string ServiceAddress { get; set; }
        public string ServiceName { get; set; }

        public NetworkClient() { }

        public IServiceSql Connect()
        {
            this.ServiceAddress = "";
            this.ServiceName = "";
            Uri uri = new Uri("http://koelson1-001-site1.itempurl.com/Service1.svc");
            EndpointAddress endPoint = new EndpointAddress(uri);
            BasicHttpBinding httpBinding = new BasicHttpBinding();
            ChannelFactory<IServiceSql> factory = new ChannelFactory<IServiceSql>(httpBinding, endPoint);
            return factory.CreateChannel();
        }

    }
}
