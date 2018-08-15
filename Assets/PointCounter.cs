using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {

	private int points = 0;
	public Text PointCountText;

		void OnCollisionEnter(Collision other) {
			
		// タグによってpointを変える
		if (other.gameObject.tag == "SmallStarTag") {
			points += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			points += 20;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			points += 15;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			points += 70;	
		}
		PointCountText.text = points.ToString();
	}

}
