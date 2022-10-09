using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Squirreldle.Model;

namespace Squirreldle.ViewModel;

public partial class GameViewModel : ObservableObject
{
    // 0 - 5
    private int rowIndex;

    // 0 - 4
    private int columnIndex;

    [ObservableProperty]
    private WordRow[] rows;

    [RelayCommand]
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

    [RelayCommand]
    public void EnterLetter(char letter)
    {

        if (columnIndex == 5)
            return;

        //Letters Here 
        //testtest
    }

}
