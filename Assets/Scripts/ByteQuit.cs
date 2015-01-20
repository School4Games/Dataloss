using UnityEngine;
using System.Collections;

public class ByteQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)){
			Application.LoadLevel ("Dataloss_menu_interface");
	
}
}
}