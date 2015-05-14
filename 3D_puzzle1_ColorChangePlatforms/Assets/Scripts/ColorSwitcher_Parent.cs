using UnityEngine;
using System.Collections;

public enum MyColor {Red, Green};

public class ColorSwitcher_Parent : MonoBehaviour {
		
		public Color greenColor = Color.green;
		public Color redColor = Color.red;
		public Color myCurrColor;
		public MyColor myColor;
		
		public virtual void Start(){
		switch(myColor){
		case MyColor.Green:
			GameManager.IncTotalGreen();
			myCurrColor = greenColor;
			break;
		case MyColor.Red:
			myCurrColor = redColor;
			break;
		default:
			break;
		}
		}
		
		public virtual void OnTriggerEnter(Collider other){
			
		}
		
		public void ChangeColor_mat(Color my_colr){
			Material mat = GetComponent<Renderer>().material;
			mat.color = my_colr;
	}

		public virtual MyColor GetMyColor(){
			return myColor;
		}

		public virtual void SwitchToOpposite(){
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
			Debug.Log ("Something about opposite switcher no worky");
			break;
		}
		}
}
