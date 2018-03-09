﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    //tjekker om bolden har ramt noget
	void OnCollisionEnter (Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); ;
        }
        
    }
}
