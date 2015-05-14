using UnityEngine;
using System.Collections;

public class Collider_Memory : MonoBehaviour {


	public GameObject myLastCollision;
	public MyColor myLastColor; 

	public void OnTriggerEnter(Collider other){
		Debug.Log ("TriggerEnter Called on Character");
		if(myLastCollision != null && other.GetComponent<Opposite_Last>() == null){
		myLastCollision = other.gameObject;
		myLastColor = other.gameObject.GetComponent<ColorSwitcher_Parent>().GetMyColor();
		}
	}
}
