using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class clickLevel : MonoBehaviour {
	public int level;

	// Use this for initialization
	public void OnMouseDown() {


		SceneManager.LoadScene (level);

	}

}
