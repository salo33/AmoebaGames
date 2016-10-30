using UnityEngine;
using System.Collections;

public class Contents
{
    int curNumber;

    public void SetNumber(int number)
    {
        if(curNumber != number)
        {
            curNumber = number;
        }
    }

    public int GetNumber()
    {
        return curNumber;
    }

}
