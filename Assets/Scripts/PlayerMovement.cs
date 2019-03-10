using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerRB;
    public bool firstPerson = true;
    public Camera thirdPersonCam;
    public Camera firstPersonCam;
    public float moveSpeed = 100;
    public GameObject backGround;
    Vector3 playerMover;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) // Switch from first to third person.
        {
            if (firstPerson == true) // Change to Third Person
            {
                firstPerson = false;

                thirdPersonCam.enabled = true;
                firstPersonCam.enabled = false;

                transform.rotation = backGround.transform.rotation;
            }
            else // Change to First Person
            {
                firstPerson = true;

                thirdPersonCam.enabled = false;
                firstPersonCam.enabled = true;
            }
        }

        if (firstPerson == false) // Third Person
        {
            if (Input.GetKey(KeyCode.UpArrow)) // Up
            {
                playerMover = new Vector3(moveSpeed, 0, 0);
                playerRB.AddForce(playerMover);
            }

            if (Input.GetKey(KeyCode.DownArrow)) // Down
            {
                playerMover = new Vector3(-moveSpeed, 0, 0);
                playerRB.AddForce(playerMover);
            }

            if (Input.GetKey(KeyCode.LeftArrow)) // Left
            {
                playerMover = new Vector3(0, 0, moveSpeed);
                playerRB.AddForce(playerMover);
            }

            if (Input.GetKey(KeyCode.RightArrow)) // Right
            {
                playerMover = new Vector3(0, 0, -moveSpeed);
                playerRB.AddForce(playerMover);
            }
        }
        else // First Person
        {
            if (Input.GetKey(KeyCode.UpArrow)) // Forward
            {
                playerMover = transform.forward * moveSpeed;
                playerRB.AddForce(playerMover);
            }

            if (Input.GetKey(KeyCode.DownArrow)) // Back
            {
                playerMover = ((transform.forward * moveSpeed) * -1);
                playerRB.AddForce(playerMover);
            }

            if (Input.GetKey(KeyCode.LeftArrow)) // Turn Left
            {
                transform.Rotate(0, -1.6f, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow)) // Turn Right
            {
                transform.Rotate(0, 1.6f, 0);
            }
        }
    }
}
