using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	public float apple = 5;

	// Use this for initialization
	void Start () {
			
		apple = 3;
		print ("this is a gooood apple");
	
	}
	
	// Update is called once per frame
	void Update () {
		/*Variables are basically used to contain information. If you were wanting to write a script to show a ball rolling you would create variables
		for the ball speed. Variables are always must be created in every script because without an ojbect there can be no action. We can't use functions
		without having a variable. 

		Conventions and Syntax- Unity uses functions, classes, code brackets, comments to make up their conventions. At the top using UnityEngine
		and System.Collection are name sakes that allow us to use code that has been pre-made in this class. Public class delcares the class and class name.
		We use functions to show the actions taking place within the code. For example Start function begins at the start of the scene and the update 
		function runs once per frame. Brackets are used to show when code is starting and ending. Comments can be made for a line of code by using //
		If you want to comment several lines use multi-code /* and reverse for  to end the comment.  
		*/
	

}
}
