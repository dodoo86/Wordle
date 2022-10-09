using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Squirreldle.Model;

namespace Squirreldle.ViewModel;

public partial class GameViewModel : ObservableObject
{
    private int rowIndex;
    private int columnIndex;

    [ObservableProperty]
    private WordRow[] rows;

    [RelayCommand]
    public void Enter()
    {

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

    [RelayCommand]
    public void EnterLetter(char letter)
    {

    }
}
