using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Frame : MonoBehaviour 
{
    int FrameMaxRowCount = 4;
    List<Contents> ContentsList = new List<Contents>();

	// Use this for initialization
	void Start () {
        Test();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetMaxRowCount(int maxRowCount)
    {
        FrameMaxRowCount = maxRowCount;
        NewGame();
    }

    public void NewGame()
    {
        ContentsList.Clear();
        for (int i = 0; i < FrameMaxRowCount * FrameMaxRowCount; ++i)
        {
            Contents newContents = new Contents();
            newContents.SetNumber(0);

            ContentsList.Add(newContents);
        }

        ContentsList[FrameMaxRowCount * FrameMaxRowCount - 1].SetNumber(1);
    }

    public void Test()
    {
       
    }
}