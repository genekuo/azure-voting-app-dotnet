namespace AzureVote.Data;

public class Vote
{
    public Vote(string label, long count)
    {
        Label = label;
        Count = count;
    }

    public string Label { get; set; }
    public long Count { get; set; }
}