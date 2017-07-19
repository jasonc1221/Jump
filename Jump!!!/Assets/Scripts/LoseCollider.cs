using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public Ball ball;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
       
        ball.transform.position = new Vector3(0, 3f, 0);
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

}
