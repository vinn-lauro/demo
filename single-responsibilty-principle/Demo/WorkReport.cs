namespace Demo;

public class WorkReport : IEntryManager<WorkReportEntry>
{
    private readonly List<WorkReportEntry> _entries;
    public WorkReport()
    {
        _entries = new List<WorkReportEntry>();
    }

    public void Add(WorkReportEntry entry) => _entries.Add(entry);
    public void Remove(int index) => _entries.RemoveAt(index);

    public override string ToString() =>
        String.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
}



