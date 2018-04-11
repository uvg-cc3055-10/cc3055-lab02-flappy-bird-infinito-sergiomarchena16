using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

	public GameObject coin;
	public float spawnTime = 4f;
	public float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
			if (elapsedTime < spawnTime) {
				elapsedTime = elapsedTime + Time.deltaTime;
			} else {
				float randomX = Random.Range (0f, 5f);
				float randomY = Random.Range (-2f, 4f);
				Instantiate (coin, new Vector3 (randomX, randomY, 0), Quaternion.identity);
				elapsedTime = 0;
			}
		}	
	}
}
