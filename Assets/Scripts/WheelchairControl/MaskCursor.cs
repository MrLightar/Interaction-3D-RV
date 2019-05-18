using UnityEngine;
using System.Collections;

public class MaskCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            if(Cursor.visible)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            } else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
		}
	}
}
