using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour {

    private SpriteRenderer indicator;

	void Start () {

        indicator = transform.Find("Indicator/Image").GetComponent<SpriteRenderer>();
	
	}
	

	void Update () {
	
	}


    void OnTriggerEnter()
    {
        Debug.Log("Detectou colisao");
        indicator.color = Color.red;
    }

    void OnTriggerExit()
    {

        indicator.color = Color.green;
    }
}
