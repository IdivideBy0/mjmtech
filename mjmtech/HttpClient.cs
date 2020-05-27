using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mjmtech
{

    public class Computer
    {
        public string compName { get; set; }
        public string ipAddress { get; set; }
        public string winVersion { get; set; }

        



    }

    class HttpClient
    {
        public string GetIpAddress()
        {
            return "";
        }

        public string GetComputerName()
        {
            return "";

        }

        public void GetMjmTech()
        {

            var ipaddress = GetIpAddress();

            var client = new RestClient("http://mjmtechservices.com/api/mjmtech");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 1JVHFjhXrxvH21W23ngdkM7ro2mGnYpDU5GM4pBiP5Ps7ltuWwFYyrGy1SeQ3VLkohKdbY0GwmBqNgvtlbw50mtV-fTCvoDHDy9GX61fzpweUjKLAfmx4SsGKXPD_6rSc4tpU0dPS2GyFhVg-p8IiCdw-3nUn_e1USEg9S0kOhj83q3HMv8isyDmRTo-fk3Yrex939cQ23JbpB5toZyQ8CsLLjZ11HOvQEdmbAPqeKt75YyyzqHxbLC7iiE8qXXUJUKqWXP1Fg3PJ7YsqghMTbXUtwkp6pbaWbIqiobieco7nKADG2z3dvR_GWby0tk7lPKqyyaGIkIIVwXZsHdyiLF0UEChRPCfwD8ejRfonYTpZenmQwT0a443J4FT5WD7s6Xr2bjM6-q1KwxxjUiNI-YDE5g8xbmt3gU7ZSsgUGS0M5S3Ry6yI1JTIrefkbPCuoYETM8VQ6McoJEN6iZtI8ntGXy1DGRjbw2F8ZB-DW0");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }


    }
}
