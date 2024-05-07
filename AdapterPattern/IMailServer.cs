namespace AdapterPattern;

public interface IMailServer
{
  public void ConnectAndSendEmail(string emailAddress, string content, string receiverName);
}
