using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region producer Message
            DefaultMQProducer producer = null;
            try
            {
               
                producer = new DefaultMQProducer("wuTest");

                 
                producer.setNamesrvAddr("172.17.22.11:9876");
                producer.start();

   
                Message msg = new Message("Go_Ticket_WuLang_Test", "TagA", Encoding.UTF8.GetBytes("RocketMQ  "));
                SendResult sendResult = producer.send(msg);
            }
            finally
            {
                producer.shutdown();
            }
            #endregion

        }
    }
}
