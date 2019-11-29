using System;
using Microsoft.Extensions.Configuration;

namespace JsonTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1]
            Console.WriteLine("新数据源之json文件解析");

            IConfiguration configuration =
                new ConfigurationBuilder().SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appSettings.json")
                .Build();

            Console.WriteLine($"LoginId is {configuration["LoginId"].ToString()}");
            Console.WriteLine($"server is {configuration["DbConn:server"].ToString()}");
            Console.WriteLine($"uid is {configuration["DbConn:uid"].ToString()}");

            Console.ReadKey();
        }
    }
}
