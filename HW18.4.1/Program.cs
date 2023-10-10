using HW18._4._1.Commands;
using HW18._4._1;

namespace HW18._4._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the link to the Youtube-video:");
            string url = Console.ReadLine();

            var sender = new Sender();
            var receiver = new Receiver();

            var getDescription = new GetDescriptionVideo(receiver, url);
            sender.SetCommand(getDescription);
            sender.Run();

            sender.SetCommand(new DownloadVideo(receiver, url));
            sender.Run();

            Console.ReadKey();
        }
    }
}