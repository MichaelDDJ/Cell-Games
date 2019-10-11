using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {

    public Transform PlayerTransform;

    private Vector3 camOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;


    // Use this for initialization
    void Start ()
    {
        camOffset = transform.position - PlayerTransform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPos = PlayerTransform.position + camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
	}
}
