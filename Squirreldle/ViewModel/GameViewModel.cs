using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Squirreldle.Model;

namespace Squirreldle.ViewModel;

public partial class GameViewModel : ObservableObject
{
    // 0 - 5
    int rowIndex;

    // 0 - 4
    int columnIndex;

    char[] correctAnswer;

    [ObservableProperty]
    private WordRow[] rows;

    public GameViewModel()
    {
        rows = new WordRow[6]
        {
            new WordRow(),
            new WordRow(),
            new WordRow(),
            new WordRow(),
            new WordRow(),
            new WordRow()
        };

        correctAnswer = "david".ToCharArray();
    }

    [ICommand]
    public void Enter()
    {
        if (columnIndex != 5)
            return;

        var valid = true;

        if (valid)
        {
            if(rowIndex == 5)
            {
                //end of game
            }
            else
            {
                rowIndex++;
                columnIndex = 0;
            }
        }
    }

    [ICommand]
    public void EnterLetter(char letter)
    {

        if (columnIndex == 5)
            return;

        //Letters Here 
    }

}
