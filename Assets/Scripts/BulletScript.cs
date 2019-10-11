using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float bspeed = 20f;

    public Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * bspeed;
	}

    private void OnTriggerEnter2D(Collider hitInfo)
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
