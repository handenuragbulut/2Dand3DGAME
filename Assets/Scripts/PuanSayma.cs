using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanSayma : MonoBehaviour
{

    Text text;
    public static int sayma;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = "TOPLAM PUAN : " + sayma.ToString();
    }
}
