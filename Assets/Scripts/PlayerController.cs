
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]float minX = 1.15f, maxX = 14.85f;

	[SerializeField]
	float screenWidthInUints = 16f;
	float HalfOfScreenWidthInUints;
	private Vector2 playerPos;
	private float mousePosInUnits;

	void Start () {
		HalfOfScreenWidthInUints = screenWidthInUints/2;
	}
	

	void Update ()
    {
        PlayerMove();
        
    }

    private void PlayerMove()
    {
        mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUints;
        //Debug.Log (mousePosInUnits);
        playerPos = new Vector2(transform.position.x, -4.5f); //why?
        playerPos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        this.transform.position = playerPos;
    }
}
