using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;

	public Text scoreText;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
		scoreText.text = "Score: " + GameController.instance.score.ToString ();
	}
	
	void Update () {
		if (GameController.instance.gameOver == false) {
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = Vector2.zero;
				rb.AddForce (Vector2.up * jumpForce);
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		GameController.instance.score++;
		scoreText.text = "Score: " + GameController.instance.score.ToString ();
	}
	private void OnCollisionEnter2D(Collision2D collision) {
		GameController.instance.gameOver = true;
	}
}