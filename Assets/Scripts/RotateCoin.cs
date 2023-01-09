using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour {
	public AudioSource Ses;
	public GameObject BizimCoin;

	// Use this for initialization
	void Update(){
		transform.Rotate (0, 4, 0, Space.World);
	}

	void OnTriggerEnter (Collider other){
		Ses.Play ();
		BizimCoin.SetActive (false);
	}
} 
