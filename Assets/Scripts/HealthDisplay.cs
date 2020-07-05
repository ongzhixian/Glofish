using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

    private int health = 5;
    public Text HealthText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.text = "Health : " + health;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }
	}
}
