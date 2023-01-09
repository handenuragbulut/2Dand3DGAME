using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinToplama : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter()
    {
        
        PuanSayma.sayma += 10;
        Destroy(gameObject);
    }
}
