using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirreldle.Model;

public class WordRow
{

    public Letter[] Letters { get; set; }
    public void Validate(char[] correctAnswer)
    {
        //Loop Trough Stuff.
    }
}
public partial class Letter : ObservableObject
{
    [ObservableProperty]
    private char input;

    [ObservableProperty]
    private Color color;
    

}
