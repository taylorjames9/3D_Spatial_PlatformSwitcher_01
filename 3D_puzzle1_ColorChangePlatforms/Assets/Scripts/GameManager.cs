using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	public Text greenCounterText;
	public Text objectivePlusWinState;
	public Text turnCounterText;
	
	private static int totalNumGreen = 0;
	private static int totalTurns = 0; 

	void OnEnable(){
		ResetAll();

	}

	void Start(){
		objectivePlusWinState.text = "Turn All Platforms to Green";
	}

	void Update( ){
		greenCounterText.text = totalNumGreen.ToString();
		turnCounterText.text = totalTurns.ToString();
		if(totalNumGreen >= 3){
			objectivePlusWinState.text = "You Win!";
		} else{
			objectivePlusWinState.text = "Turn All Platforms to Green";

		}
	}

	public static void DecTotalGreen(){
		totalNumGreen -= 1;
	}

	public static void IncTotalGreen(){
		totalNumGreen += 1;
	}

	public static void IncTotalTurns(){
		totalTurns += 1;
	}

	public void Reload(){
		Debug.Log ("Button HIT");
		Application.LoadLevel("3D_PuzzlerWScripts");

	}

	public static void ResetAll(){
		totalNumGreen = 0;
		totalTurns = 0;

	}



}
