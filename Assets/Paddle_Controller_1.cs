using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Controller : MonoBehaviour {

    public float movement_Speed = 0.2f;
    Rigidbody2D rb;
    Vector2 movement = new Vector2(0.0f, 1f);

	// Use this for initialization
	void Start () {

       rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Input.GetKey(KeyCode.W))
        { transform.Translate(movement * movement_Speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.S))
        { transform.Translate(movement * -movement_Speed * Time.deltaTime); }

        Debug.Log(movement_Speed);
    }
}
