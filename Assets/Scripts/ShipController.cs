using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @author Guillermo Sandoval #17577
 * @author Andres Urizar #17632
 */

public class ShipController : MonoBehaviour {

    public float speed= 5f;
    public Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.gameOver = true;
        SceneManager.LoadScene("Menu");
    }
}
