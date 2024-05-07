using System;

namespace AdapterPattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IMailServer mailServer = new AdaptedGoogleMailServer();
      mailServer.ConnectAndSendEmail("vip@yakha.de", "We are planning to take over the software industry, keep secret.", "Very Important Person");
    }
  }
}
