using CommunityToolkit.Mvvm.ComponentModel;

namespace Squirreldle.Model;

public class WordRow
{
    public WordRow()
    {
        Letters = new Letter[5]
        {
            new Letter(),
            new Letter(),
            new Letter(),
            new Letter(),
            new Letter()
        };
    }

    public Letter[] Letters { get; set; }
    public void Validate(char[] correctAnswer)
    {
        //Loop Trough Stuff.
    }
}

public partial class Letter : ObservableObject
{
    public Letter()
    {
        Color = Colors.Black;
    }

    [ObservableProperty]
    private char input;

    [ObservableProperty]
    private Color color;
    

}
