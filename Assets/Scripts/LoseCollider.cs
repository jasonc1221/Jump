using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public Ball ball;
    public GameObject Platform;
    Vector3 offset;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    private float num = 4.8f;


    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.tag == "Platform")
        {
            int rand = Random.Range(-10, 10);
            if (rand <= 8 && rand >= -8)
            {
                Vector3 pos = new Vector3(rand, num, 0);
                Debug.Log(num);
                num = num + 4;
                trigger.transform.position = pos;
            }
            else if (rand >= 8)
            {
                Vector3 pos = new Vector3(7.72f,num , 0);
                Debug.Log(num);
                num = num + 4;
                trigger.transform.position = pos;
            }
            else if (rand <= -8)
            {
                Vector3 pos = new Vector3(-7.744f, num, 0);
                Debug.Log(num);
                num = num + 4;
                trigger.transform.position = pos;
            }
           
        }
        else if (trigger.gameObject.tag == "Player")
        {
            Debug.Log("Lost");
            LevelManager man = GameObject.Find("LevelManager").GetComponent<LevelManager>();
            man.LoadLevel("End");

        }
        else
        {
            DestroyObject(trigger.gameObject);
        }

    }
    
   

   void Update()
    {
        if (ball != null)
        {
            if (transform.position.y + 10 <= ball.transform.position.y)
            {
                // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
                //transform.position = ball.transform.position + offset + new Vector3(0,.01f,0);
                Vector3 targetPosition = ball.transform.position - new Vector3(ball.transform.position.x, 7, 0);
                transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            }
        }
       

      
    }

}
