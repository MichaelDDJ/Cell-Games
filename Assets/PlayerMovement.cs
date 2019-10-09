using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float maxspeed;
    public float speed;
    public float thrust;
    public float rotate;
    public float hp;
    


    // Use this for initialization
    void Start(){
        
    }



    // Update is called once per frame
    void Update() {


        maxspeed = 3;
        float moveForward = Input.GetAxis("Vertical") * maxspeed;
        float Turn = Input.GetAxis("Horizontal") * -rotate;
        Turn *= Time.deltaTime;
        transform.Rotate(0, 0, Turn);
        thrust = 0.01f;

        if (moveForward > 0)
        { 
            
            moveForward *= Time.deltaTime;
            transform.Translate(0, (thrust + moveForward), 0);
            
            
            moveForward = speed;
        }
        else if (0 > moveForward)
        {
            transform.Translate(0, 0, 0);
        }
        else if (moveForward == 0)
        {
            transform.Translate(0, thrust, 0);
        }
	}
}
