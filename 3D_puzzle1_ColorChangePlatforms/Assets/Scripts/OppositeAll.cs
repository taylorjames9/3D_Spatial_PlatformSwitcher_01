﻿using UnityEngine;
using System.Collections;

public class OppositeAll : ColorSwitcher_Parent {


	public delegate void Trig_Opposites_Action();
	public static event Trig_Opposites_Action Opposite_Event;

	void OnEnable(){
		Opposite_Event += base.SwitchToOpposite;
	}
	
	void OnDisable(){
		Opposite_Event -= base.SwitchToOpposite;
	}

	public override void Start ()
	{
		base.Start();
		//myColor = MyColor.Green;
		//myCurrColor = greenColor;
		ChangeColor_mat(myCurrColor);
	}

	public override void OnTriggerEnter (Collider other)
	{
		Opposite_Event();

	}

}
