using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Frame : MonoBehaviour 
{
    int FrameMaxCount = 16;
    List<Contents> ContentsList = new List<Contents>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetMaxCount(int maxCount)
    {
        FrameMaxCount = maxCount;
        NewGame();
    }

    public void NewGame()
    {
        ContentsList.Clear();
        for(int i = 0; i < FrameMaxCount; ++i)
        {
            Contents newContents = new Contents();
            newContents.SetNumber(0);

            ContentsList.Add(newContents);
        }

        ContentsList[FrameMaxCount - 1].SetNumber(1);
    }
}