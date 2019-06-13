using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			SceneManager.LoadScene("Test_Grab");
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			SceneManager.LoadScene("Test_Push");
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			SceneManager.LoadScene("Test_Activation");
		} 
	}
}
