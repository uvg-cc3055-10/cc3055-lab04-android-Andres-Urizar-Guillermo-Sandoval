using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

    public GameObject meteor;
    float spawnTime = 4f;
    float elapsedTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameController.instance.gameOver == false)
        {
            if(elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-3f, 3f);
                Instantiate(meteor, new Vector3(random, 7, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
	}
}
