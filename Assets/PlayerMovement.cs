using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float thrust;
    public float rotate;
    public float hp;


    // Use this for initialization
    void Start(){
        
    }


	
	// Update is called once per frame
	void Update () {

        float moveForward = Input.GetAxis("Vertical") * speed;
        float Turn = Input.GetAxis("Horizontal") * -rotate;

        moveForward *= Time.deltaTime;
        Turn *= Time.deltaTime;

        transform.Translate(0,(thrust + moveForward), 0);
        transform.Rotate(0, 0, Turn);
	}
}
