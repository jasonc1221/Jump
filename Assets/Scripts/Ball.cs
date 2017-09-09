using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float speed = 12.0f;    //speed at which the ball is moving
    public float bounce; //how much ball bounces once it hits platform
    float maxpoints=0;
    float point;
    //private ScoreKeepers scorekeeper;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        //movement of ball
        //var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        point = transform.position.y;
       /* if (maxpoints < point)
        {
            maxpoints = point;
            Debug.Log(maxpoints);
            //scorekeeper.Score(maxpoints);
            // put in round up fuc
        }*/
      //  if(transform.position)
        //transform.position += move * speed * Time.deltaTime;

	}
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        //allows ball to jump once it hits a platform
        if(other.gameObject.tag == "Platform")
        {
            this.transform.GetComponent<Rigidbody2D>().velocity = Vector3.up * bounce;
        }
       
        //sets walls so that ball can teleport
        if (other.gameObject.tag == "RightWall" || other.gameObject.tag == "LeftWall")
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
    }

}
