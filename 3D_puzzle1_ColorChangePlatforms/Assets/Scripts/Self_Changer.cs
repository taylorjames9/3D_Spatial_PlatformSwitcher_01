using UnityEngine;
using System.Collections;

public class Self_Changer : ColorSwitcher_Parent {

	void OnEnable(){
		OppositeAll.Opposite_Event += SwitchToOpposite;
	}
	
	void OnDisable(){
		OppositeAll.Opposite_Event -= SwitchToOpposite;
	}

	public override void Start(){
		base.Start();
		//myColor = MyColor.Red;
		//myCurrColor = redColor;
		ChangeColor_mat(myCurrColor);

	}

	public override void OnTriggerEnter(Collider other){
		switch(myColor){
		case MyColor.Red:
			ChangeColor_mat(greenColor);
			myColor = MyColor.Green;
			GameManager.IncTotalGreen();
			break;
		case MyColor.Green:
			ChangeColor_mat(redColor);
			myColor = MyColor.Red;
			GameManager.DecTotalGreen();
			break;
		default:
			Debug.Log ("NO COLOR ASSIGNED ON TRIG ENTER");
			break;
		}
	}
}
