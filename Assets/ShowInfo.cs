using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour {

	[SerializeField]GameObject bananaInfo, watermelonInfo, appleInfo, infoBTN;
	[SerializeField]MeshRenderer bananaRND, watermelonRND, appleRND;

	void Start () {
		bananaInfo.SetActive (false);
		watermelonInfo.SetActive (false);
		appleInfo.SetActive (false);
	}

	void Update () {

		if (bananaRND.enabled || watermelonRND.enabled || appleRND.enabled) {
			infoBTN.SetActive (true);
		} else {
			if (bananaInfo.activeInHierarchy || watermelonInfo.activeInHierarchy ||
			    appleInfo.activeInHierarchy) {
				infoBTN.SetActive (true);
			} else {
				infoBTN.SetActive (false);
			}

		}
	} 

	bool willShowInfo = false;
	public void showInfo(){

		willShowInfo = !willShowInfo;

		bananaInfo.SetActive (false);
		watermelonInfo.SetActive (false);
		appleInfo.SetActive (false);

		if (willShowInfo) {
		
			if (bananaRND.enabled) {
				bananaInfo.SetActive (true);
			} else if (watermelonRND.enabled) {
				watermelonInfo.SetActive (true);
			} else if (appleRND.enabled) {
				appleInfo.SetActive (true);
			}
		}

	}
}
