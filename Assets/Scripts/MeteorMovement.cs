using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour {

    private float scrollingSpeed = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver == false)
        {
            transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime);
            if (transform.position.y < -6)
            {
                Destroy(gameObject);
            }   
        }
        
	}
}
