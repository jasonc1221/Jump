using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public GameObject ball;
    Vector3 cameraHeight;

	// Use this for initialization
	void Start () {
        cameraHeight = transform.position;
    }
	
	//// Update is called once per frame
	//void Update () {
 //       if (ball.transform.position.y >= 3)
 //       {
 //           cameraHeight.y = ball.transform.position.y -3;
 //           this.transform.position = cameraHeight;
 //       }
 //   }
}



