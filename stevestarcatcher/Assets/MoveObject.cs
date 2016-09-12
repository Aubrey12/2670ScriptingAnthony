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

    void Start() {
        myCC = GetComponent<CharacterController>();

    }      

	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax -1)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
        }
        

        tempPos.y -= gravity;

        tempPos.x = speed*Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);

	
	}
}
