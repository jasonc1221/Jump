using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBreak : MonoBehaviour {

    public int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        //counter to break platform once you bounce on more than once
        if(other.gameObject.tag == "Player")
        {
            counter++;
            if (counter == 2)
            {
                Destroy(gameObject);
            }
        }
    }

}
