﻿using UnityEngine;
using System.Collections;

public class GameManagerDD : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public PlayerControllerDD thePlayer;
	private Vector3 playerStartPoint;

	private PlatformDestroyerDD[] platformList;

	private ScoreManagerDD theScoreManager;

	// Use this for initialization
	void Start () {
		platformStartPoint = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;

		theScoreManager = FindObjectOfType<ScoreManagerDD>();
	
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartGame()
	{
		StartCoroutine ("RestartGameCo");
	}

	public IEnumerator RestartGameCo()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformList = FindObjectsOfType<PlatformDestroyerDD> ();
		for (int i = 0; i < platformList.Length; i++) 
		{
			platformList[i].gameObject.SetActive (false);
		}

		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);

		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	} 
}
