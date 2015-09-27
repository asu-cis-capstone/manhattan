using UnityEngine;
using System.Collections;

public class PickupPointsDD : MonoBehaviour {

	public int scoreToGive;

	private ScoreManagerDD theScoreManager;

	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManagerDD> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			theScoreManager.AddScore (scoreToGive);
			gameObject.SetActive (false);
		}
	}
}
