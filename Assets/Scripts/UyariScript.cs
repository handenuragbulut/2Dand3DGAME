using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UyariScript : MonoBehaviour {

    public float mesafe;
    public GameObject HedefMetin;
    public GameObject UyariMetin;
    public GameObject para;
    

	
	// Update is called once per frame
	void Update () {
        mesafe = OyuncuRaycast.HedeftanUzakligi;
    }
    void OnMouseOver()
    {
        if (mesafe <= 3)
        {
            HedefMetin.SetActive(true);
            UyariMetin.SetActive(true);
        }
        else
        {
            HedefMetin.SetActive(false);
            UyariMetin.SetActive(false);
        }

    }

    void OnMouseExit()
    {
        HedefMetin.SetActive(false);
        UyariMetin.SetActive(false);

    }
}
