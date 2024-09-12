using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.SOLID.SRPtask.with_srp;

public class Notificator
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Report has been generated successfully!");
    }

}
