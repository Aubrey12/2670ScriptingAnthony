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

	//Coroutine for sliding Character
	IEnumerator Slide ()
	{
		int durationTemp = slideDuration;
		float speedTemp = speed;
		speed += speed;
		//while loop runs /while/ the slideDuration >0
		while (slideDuration > 0) {
			//decrement the slideDuration
			slideDuration--;
			yield return new WaitForSeconds (slideTime);
			print ("sliding");
		}
		speed = speedTemp;
		slideDuration = durationTemp;

	}

    void Start() {
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

		//start sliding
		if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S)) 
		{
			StartCoroutine(Slide());
		}
		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown (KeyCode.S)) 
		{
			StartCoroutine(Slide());
		}

		if(myCC.isGrounded)
		{
			jumpCount = 0;
		}

        tempPos.y -= gravity;

        tempPos.x = speed*Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);

	
	}
}
