﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	private Move player;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Move> ();
	}



	// Update is called once per frame
	void Update () {
	
	}

	//Respawn Player
	public void RespawnPlayer(){
		Debug.Log("Player has Respawned!");
		player.transform.position = currentCheckPoint.transform.position;
	}

}
