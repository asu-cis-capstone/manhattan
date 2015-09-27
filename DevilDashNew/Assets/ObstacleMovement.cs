using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	public float speed = 0;

	public float switchTime = 2;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;
	
		InvokeRepeating ("Switch", 0, switchTime);
	}
	
	// Update is called once per frame
	void Switch () {
		GetComponent<Rigidbody2D>().velocity *= -1;


	}
}
