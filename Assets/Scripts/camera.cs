using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public GameObject ball;
    Vector3 offset;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;


    // Use this for initialization
    void Start () {
        Debug.Log(transform.position);
        offset = transform.position - ball.transform.position - new Vector3(0,3.5f,4);
        Debug.Log(offset);
    }
    void Update()
    {
        if (ball != null)
        {
            if (transform.position.y <= ball.transform.position.y)
            {
                // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
                //transform.position = ball.transform.position + offset + new Vector3(0,.01f,0);
                Vector3 targetPosition = ball.transform.position - new Vector3(ball.transform.position.x, 0, 0);
                transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime) + offset;
            }
        }
        
        //transform.position = ball.transform.position;
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



