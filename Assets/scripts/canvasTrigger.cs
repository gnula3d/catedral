using UnityEngine;
using System.Collections;

public class canvasTrigger: MonoBehaviour {
	public GameObject canvas;

	void OnTriggerEnter(Collider other)
	{	
		canvas.SetActive(true);
	}


	void OnTriggerExit(Collider other)
	{	
		canvas.SetActive(false);

	}

}