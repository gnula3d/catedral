using UnityEngine;
using System.Collections;

public class MoveObjectWithButton : MonoBehaviour {
	public Transform position1;

	public Transform myObject;
	// Use this for initialization
	void Start () {
		
	}

	public void OnMouseDown(){
		
			myObject.transform.position = position1.transform.position;

		

			


	}
}