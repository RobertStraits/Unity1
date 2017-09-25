using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //Debug.Log("Hello. This code is inside of Start.");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("Called from update!!!");
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0.2f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}
        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    transform.Translate(0.2f, 0, 0);
        //}
        float HorizontalInput = Input.GetAxis("Horizontal");
        Debug.Log("horizontal input: " + HorizontalInput);
        float speed = 0.2f;
        transform.Translate(speed * HorizontalInput, 0, 0);
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }
    }
}