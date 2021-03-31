using System;

public class ClassifiquedNote
{
    public string noteA;
    public string noteB;
    public string noteC;

    public ClassifiquedNote()
    {
        noteA = "Your Note is A";
        noteB = "Your Note is B";
        noteC = "Your Note is C";
    }
}

public class ResultNote:ClassifiquedNote
{
    public ResultNote(int note)
    {
            
    }     
}

class Program:ResultNote
{
    static void Main()
    {
        
    }
}