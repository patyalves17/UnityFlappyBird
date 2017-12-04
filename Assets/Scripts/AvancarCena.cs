using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AvancarCena : MonoBehaviour {

	public string cena;

	
	// Update is called once per frame
	void Update () {
		//Fire1 --> touch, ctrl+left, click+left
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadScene (cena);
		}	
	}
}
