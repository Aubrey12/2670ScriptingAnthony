using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float Speed = 1;
	private Vector3 tempPos;
	
	// Update is called once per frame
	void Update () 
	{
		tempPos.x = Speed * Time.deltaTime;
		transform.Translate (tempPos);
	
	}
}
