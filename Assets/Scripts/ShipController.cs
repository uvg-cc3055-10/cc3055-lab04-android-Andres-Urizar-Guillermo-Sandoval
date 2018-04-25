using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Guillermo Sandoval #17577
 * @author Andres Urizar #17632
 */

public class ShipController : MonoBehaviour {

    public float speed= 5f;
    public Rigidbody2D rb;
    public static ShipController instance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
	}
}
