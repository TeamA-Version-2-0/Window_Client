using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class NetworkClient
    {
        private NetworkClient() { }

        private static IServiceSql connection()
        {
            Uri uri = new Uri("http://koelson1-001-site1.itempurl.com/Service1.svc");
            EndpointAddress endPoint = new EndpointAddress(uri);
            BasicHttpBinding httpBinding = new BasicHttpBinding();
            ChannelFactory<IServiceSql> factory = new ChannelFactory<IServiceSql>(httpBinding, endPoint);
            return factory.CreateChannel();
        }

        public static IServiceSql GetInstance()
        {
            if (connection() == null)
                return null;

            return connection();
        }

    }
}
