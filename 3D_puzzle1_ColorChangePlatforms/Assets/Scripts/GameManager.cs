using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	public Text greenCounterText;
	public Text objectivePlusWinState;


	void Update( ){
		greenCounterText.text = totalNumGreen.ToString();
		if(totalNumGreen >= 3){
			objectivePlusWinState.text = "You Win!";
		} else{
			objectivePlusWinState.text = "Turn All Platforms to Green";

		}
	}


	private static int totalNumGreen = 0;

	public static void DecTotalGreen(){
		totalNumGreen -= 1;
	}

	public static void IncTotalGreen(){
		totalNumGreen += 1;
	}

}
