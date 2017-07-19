using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float speed = 12.0f;    //speed at which the ball is moving
    public float bounce; //how much ball bounces once it hits platform


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        //movement of ball
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        //allows ball to jump once it hits a platform
        this.transform.GetComponent<Rigidbody2D>().velocity = Vector3.up * bounce;

        //sets walls so that ball can teleport
        if (other.gameObject.name == "RightWall" || other.gameObject.name == "LeftWall")
        {
            transform.position = new Vector2(transform.position.x / Mathf.Abs(transform.position.x) - transform.position.x, transform.position.y);
        }
    }

}
