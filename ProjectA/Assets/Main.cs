using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public UISprite sprite;
    private Frame frame = new Frame();
	// Use this for initialization
	void Start () 
    {
        sprite.spriteName = "2048";
        frame.Test();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
