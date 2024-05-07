using System;

namespace AdapterPattern;
public class GoogleMailServer
{
  public GoogleMailServer() {}
  public void BuildConnection() 
  {
    Console.WriteLine("Connection to the mail account established.");
  }
  public void SendEmail(string receiverEmail, string content)
  {
    Console.WriteLine($"The email was sent to {receiverEmail}.");
    Console.WriteLine($"Content: {content}");
  }
}
