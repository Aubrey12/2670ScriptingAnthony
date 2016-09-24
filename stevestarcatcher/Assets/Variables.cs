using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	public int apple = 5;


	// Use this for initialization
	void Start () {
		int i = 0;
		for (i = 0; apple > i; ++i);

	}


	void Update () {

		if (apple > 0)
			print("apples!!!");

	/*Access Modifiers can be stated by using "public" or "private" before a variable. When set to private a variable can only be accessed within that
	class. If set to public it can be accessed in other classes and in the inspector. Scope is a class's parameters which are set using the curly 
	braces. If the access modifier is not specified the variable will default to private automatically. You are able to change the variable value in the
	inspector but it will be over ridden by the value stated within code. 

*/
	}
}
