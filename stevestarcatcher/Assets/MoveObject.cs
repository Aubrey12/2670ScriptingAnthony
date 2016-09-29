using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

    //this is the character controller component
   public CharacterController myCC;
    //temp var of datatype vector3 to move the character
    private Vector3 tempPos;
    //speed of the remp in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
	//sliding vars
	public int slideDuration = 100;
	public float slideTime = 0.01f;

	void Start (){

		myCC = GetComponent<CharacterController>();
		
	}

	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax -1)
        {
            jumpCount++;
			//adding jumpspeed
            tempPos.y = jumpSpeed;
        }

		if(myCC.isGrounded)
		{
			jumpCount = 0;
		}
		//adding the gravity var to the y position of the tempPos var
	
        tempPos.y -= gravity;
		//adding the speed var to the tempPos var x value with the right and left arrow keys

        tempPos.x = speed*Input.GetAxis("Horizontal");
		//Moves the charactor controller at an even pace (deltaTime)
        myCC.Move(tempPos * Time.deltaTime);

	
	}
}
