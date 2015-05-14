using UnityEngine;
using System.Collections;

public class Opposite_Last : ColorSwitcher_Parent {

	void OnEnable(){
		OppositeAll.Opposite_Event += SwitchToOpposite;
	}
	
	void OnDisable(){
		OppositeAll.Opposite_Event -= SwitchToOpposite;
	}
		
		public override void Start(){
			base.Start();
			ChangeColor_mat(myCurrColor);
		}
		
		public override void OnTriggerEnter(Collider person){
		base.OnTriggerEnter(person);
			switch(person.GetComponent<Collider_Memory>().myLastColor){
			case MyColor.Red:
				if(myColor == MyColor.Red){
				ChangeColor_mat(greenColor);
				myColor = MyColor.Green;
				GameManager.IncTotalGreen();
			}
				break;
			case MyColor.Green:
			if(myColor == MyColor.Green){
				ChangeColor_mat(redColor);
				myColor = MyColor.Red;
				GameManager.DecTotalGreen();
			}
				break;
			default:
				Debug.Log ("NO COLOR ASSIGNED ON TRIG ENTER");
				break;
			}
		}
}
