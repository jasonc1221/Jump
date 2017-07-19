using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{

    public GameObject platform;
    bool PushPlat = false;
    // Use this for initialization
    void Start()   {

    }

    // Update is called once per frame
    void Update()
    {   
        //pushing down to platforms
        if (PushPlat == true)
        {
    
                platform.transform.position = new Vector3(platform.transform.position.x, platform.transform.position.y - 1);
                PushPlat = false;  
        }
         
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PushPlat = true;
        print("trigger");
    }

    void OnBecameInvisible()
    {
        Destroy(this);
    }


}
