using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	//Load the game scene
	public void StartGame(){
		Application.LoadLevel ("Dataloss_scene");
	}

	//Load the Main Menu
	public void LoadMainMenu(){
		Application.LoadLevel ("Dataloss_menu_interface");
	}
	
	//End the game
	public void EndGame(){
		Application.Quit ();
	}
}