public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        string soccerPosition = "";
        switch (shirtNum)
        {
            case 1:
                soccerPosition = "goalie";
                break;
            case 2:
                soccerPosition = "left back";
                break;
            case 3:
            case 4:
                soccerPosition = "center back";
                break;
            case 5:
                soccerPosition = "right back";
                break;
            case 6:
            case 7:
            case 8:
                soccerPosition = "midfielder";
                break;
            case 9:
                soccerPosition = "left wing";
                break;
            case 10:
                soccerPosition = "striker";
                break;
            case 11:
                soccerPosition = "right wing";
                break;
            default:
                soccerPosition = "UNKNOWN";
                break;
        }
        return soccerPosition;
    }

    public static string AnalyzeOffField(object report)
    {
        string analyzeReport = "";
        switch (report)
        {
            case int supporters:
                analyzeReport = $"There are {supporters} supporters at the match.";
                break;
            case string announcement:
                analyzeReport = announcement;
                break;
            case Injury injury:
                analyzeReport = $"Oh no! {injury.GetDescription()} Medics are on the field.";
                break;
            case Incident incident:
                analyzeReport = incident.GetDescription();
                break;
            case Manager manager when manager.Club != null:
                analyzeReport = $"{manager.Name} ({manager.Club})";
                break;
            case Manager manager:
                analyzeReport = manager.Name;
                break;
            default:
                break;
        }
        return analyzeReport;
    }
}





public class Manager
{
    public string Name { get; }

    public string? Club { get; }

    public Manager(string name, string? club)
    {
        this.Name = name;
        this.Club = club;
    }
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int player;

    public Injury(int player)
    {
        this.player = player;
    }

    public override string GetDescription() => $"Player {player} is injured.";
}