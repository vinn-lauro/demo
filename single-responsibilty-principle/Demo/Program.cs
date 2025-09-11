namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        var report = new WorkReport();
        report.Add(new WorkReportEntry { ProjectCode = "123Dc", ProjectName = "Project A", SpentHours = 5 });
        report.Add(new WorkReportEntry { ProjectCode = "981Wc", ProjectName = "Project B", SpentHours = 3 });
        report.Add(new WorkReportEntry { ProjectCode = "D2vMp", ProjectName = "Project C", SpentHours = 7 });
        report.Add(new WorkReportEntry { ProjectCode = "M01Zs", ProjectName = "Project D", SpentHours = 1 });

        var scheduler = new Scheduler();
        scheduler.Add(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
        scheduler.Add(new ScheduleTask { TaskId = 2, Content = "Create something now.", ExecuteOn = DateTime.Now.AddDays(10) });
        scheduler.Add(new ScheduleTask { TaskId = 3, Content = "Remove something now.", ExecuteOn = DateTime.Now.AddDays(2) });
        scheduler.Add(new ScheduleTask { TaskId = 4, Content = "Edit something now.", ExecuteOn = DateTime.Now.AddDays(3) });
        scheduler.Add(new ScheduleTask { TaskId = 5, Content = "Configure something now.", ExecuteOn = DateTime.Now.AddDays(15) });

        Console.WriteLine(report.ToString());
        Console.WriteLine(scheduler.ToString());

        var saver = new FileSaver();
        saver.SaveToFile(@"Reports", "WorkReport.txt", report);
        saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
    }
}

