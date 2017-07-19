using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Ball ball;
  

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D teleport)
    {
        var y = transform.position.y;
        if (teleport.tag == "RightWall") {
            
            ball.transform.position = new Vector3(-11.25f, y);
                }
        if (teleport.tag== "LeftWall")
        {
            ball.transform.position = new Vector3(11.25f, y);
        }
    }

   
}
