using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OyuncuRaycast : MonoBehaviour {

	public static float HedeftanUzakligi;
    public float Hedef;
	
	void Update () {
        RaycastHit Hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit)) 
        {
            Hedef = Hit.distance;
            HedeftanUzakligi = Hit.distance;
        }
	}
}
