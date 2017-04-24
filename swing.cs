using UnityEngine;
using System.Collections;

public class swing : MonoBehaviour {

    //Mimic Centripital Force that occurs in a Swing Ride.

    float speed = 360; // rotation speed - Velocity
    float radius = 80; // radius of base
    float gravity = 10; // gravity
    float rot = 0; // rotation angle

    double timer = 120; // run time

    bool centripetalForce = true; // used to determin if Centripetal force is in play
    bool run = true; // used to determine when rotation is happening.
    
    void Start()
    {
        
    }
    void Update()
    {

  
        // if run is true, rotation of swings will occur
        if(run == true) 
        {
            if (timer > 0)
            {
                if (centripetalForce == true) // rotates outward - Centripetal Force
                {
                    rot = Mathf.Atan((speed / (radius * gravity))); // determine angle due to centipital force

                    transform.Rotate(new Vector3(0, 0, rot)); // rotate swings

                    timer = timer - 1; // decreases timer count

                    transform.Translate(Time.deltaTime*4, Time.deltaTime*2, 0); // adjusts position, after rotation
                }
                else
                {
                    rot = Mathf.Atan((360 / (radius * gravity))); // undo rotation due to centipital force

                    transform.Rotate(new Vector3(0, 0, -rot)); // rotates

                    timer = timer - 1; // decrease timer count

                    transform.Translate(-Time.deltaTime*4, -Time.deltaTime*2, 0); // adjust position after rotation
                }
            }
            else 
            {
                run = false; // sets run to false, to restore count

                // changes which way swing will rotate
                if (centripetalForce == true)
                {
                    centripetalForce = false;
                }
                else
                    centripetalForce = true;
            }
            
        }
        else
        {
            if (timer <= 80) // increases timer
            {
                timer++;
            }
            else
            {
                run = true; // triggers rotation system to run again.
            }
        }
       


    }
}


