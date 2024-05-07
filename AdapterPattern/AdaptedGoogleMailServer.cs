namespace AdapterPattern;

public class AdaptedGoogleMailServer : IMailServer
{
  private GoogleMailServer googleMailServer;
  public AdaptedGoogleMailServer()
  {
    googleMailServer = new GoogleMailServer();
  }
  public void ConnectAndSendEmail(string emailAddress, string content, string receiverName)
  {
    googleMailServer.BuildConnection();
    string encryptedEmail = EncryptMail(content);
    googleMailServer.SendEmail(emailAddress, content);
  }
  private string EncryptMail(string content)
  {
    Console.WriteLine("Encrypting Email");
    Console.WriteLine("...");
    Console.WriteLine("Email successfully encrypted");

    return content;
  }
}
