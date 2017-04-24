using UnityEngine;
using System.Collections;

public class turning : MonoBehaviour {

    //Rotates the Top and swings of Ride

    //Rotation and Speed Variables
    private Vector3 rotation = Vector3.up;
    private float speed = -80.0f;

    //Timer Variables
    double timer = 240;
    bool run = true; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (run == true)// Ride is running
        {
            transform.Rotate(rotation, speed * Time.deltaTime); // Rides run rotation speed

            //Decreases run timer
            if (timer > 0)
            {
                timer--;
            }
            else
                run = false;

        }
        else // ride is not running, and slows
        {
            transform.Rotate(rotation, -35.0f * Time.deltaTime); // slows ride

            //Restores run timer
            if (timer < 160)
            {
                timer++;
            }
            else
                run = true; // triggers Ride to run again
        }
    }
}
