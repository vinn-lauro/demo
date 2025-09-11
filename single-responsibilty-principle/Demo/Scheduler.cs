namespace Demo;

public class Scheduler : IEntryManager<ScheduleTask>
{
    private readonly List<ScheduleTask> _tasks;
    public Scheduler()
    {
        _tasks = new List<ScheduleTask>();
    }

    public void Add(ScheduleTask task) => _tasks.Add(task);

    public void Remove(int index) => _tasks.RemoveAt(index);

    public override string ToString() =>
        String.Join(Environment.NewLine, _tasks.Select(t => $"Id: {t.TaskId}, Content: {t.Content}, Executed On: {t.ExecuteOn}"));
}



