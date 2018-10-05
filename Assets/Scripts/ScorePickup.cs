﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {
    public Score scoreTracker;
    public int scoreValue = 1;
	
        
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())

        {
            scoreTracker.ChangeValue(scoreValue);

                Destroy(gameObject);

        }

    }

}
