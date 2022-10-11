﻿using CommunityToolkit.Mvvm.ComponentModel;
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

    public char[] KeyboardRow1 { get; }
    public char[] KeyboardRow2 { get; }
    public char[] KeyboardRow3 { get; }

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

        correctAnswer = "DAVID".ToCharArray();
        KeyboardRow1 = "QWERTYUIOP".ToCharArray();
        KeyboardRow2 = "ASDFGHJKL".ToCharArray();
        KeyboardRow3 = "<ZXCVBNM>".ToCharArray();
    }

    public void Enter()
    {
        if (columnIndex != 5)
            return;

        var correct = Rows[rowIndex].Validate(correctAnswer);

        if (correct)
        {
            App.Current.MainPage.DisplayAlert("YOU WON!","You are so smart !", "ok");
            return;
        }
        if(rowIndex == 5)
        {
            App.Current.MainPage.DisplayAlert("Game Over!", "You Lose !", "ok");
        }
        else
        {
            rowIndex++;
            columnIndex = 0;
        }
    }

    [ICommand]
    public void EnterLetter(char letter)
    {
        if(letter == '>')
        {
            Enter();
            return;
        }

        if(letter == '<')
        {
            if (columnIndex == 0)
                return;
            columnIndex--;
            Rows[rowIndex].Letters[columnIndex].Input = '\0';
            return;
        }

        if (columnIndex == 5)
            return;

        Rows[rowIndex].Letters[columnIndex].Input = letter;
        columnIndex++;
    }

}
