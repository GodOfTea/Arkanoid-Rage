using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	[SerializeField]
	PlayerController player1;
	[SerializeField]
	float xPush = 3f, yPush = 15f;

	Vector2 playerToBallVector;
	Vector2 player1Pos;

	public bool hasStarted;

	void Start ()
    {
        StartConfig();
    }

    public void StartConfig()
    {
        playerToBallVector = transform.position - player1.transform.position; //ball - player
        hasStarted = false;
    }

    void Update () 
	{
		if (!hasStarted) 
		{
			StartBallLook ();
			StartBallFromPlayer ();
		}
	}

	void StartBallFromPlayer ()
	{
		if (Input.GetMouseButtonDown (0) || (Input.GetKeyDown(KeyCode.Space))) 
		{
			hasStarted = true;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (xPush, yPush);
		}
	}

	void StartBallLook ()
	{
		player1Pos = new Vector2 (player1.transform.position.x, player1.transform.position.y);
		transform.position = player1Pos + playerToBallVector;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
            GetComponent<AudioSource>().Play();
    }
}

