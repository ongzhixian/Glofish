using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour {

    public int width;
    public int height;

    public void SetWidth(int newWidth)
    {
        this.width = newWidth;
    }

    public void SetHeight(int newHeight)
    {
        this.height = newHeight;
    }

    public void SetRes()
    {
        Screen.SetResolution(this.width, this.height, false);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
