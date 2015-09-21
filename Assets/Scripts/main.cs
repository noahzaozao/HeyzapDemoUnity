using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Your Publisher ID is: 78a1f195d49dd1fb055962b88a3c912d
		HeyzapAds.start("78a1f195d49dd1fb055962b88a3c912d", HeyzapAds.FLAG_NO_OPTIONS);
		HeyzapAds.showMediationTestSuite ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
