using System;
using Grpc.Core;
using Helloworld;

namespace grpc
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50001", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(new HelloRequest{ Name = "lin" });
            Console.WriteLine("来自" + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
