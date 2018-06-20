using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {

	private int point = 0;
	private GameObject pointText;

	// Use this for initialization
	void Start () {
		this.pointText = GameObject.Find("Point");		
	}
	
	// Update is called once per frame
	void Update () {
		this.pointText.GetComponent<Text> ().text = "Point : " + this.point.ToString();
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallCloudTag") {
			this.point += 10;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.point += 15;
		} else if (other.gameObject.tag == "SmallStarTag") {
			this.point += 20;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.point += 30;
		}
	}
}
