using UnityEngine;
using System.Collections;
using System;

public enum Cameras
{

    MAIN,
    TOP
}

public class CameraManager : MonoBehaviour {

    
    public Camera[] cameras;

	void Start () {
	

	}
	

	void Update () {

        if (Input.GetKey(KeyCode.Space))
            SwitchCamera();
	}

    private void SwitchCamera()
    {
        if(cameras[(int)Cameras.MAIN].enabled == true)
        {

            cameras[(int)Cameras.MAIN].enabled = false;
            cameras[(int)Cameras.TOP].enabled = true;
        }
        else
        {
            cameras[(int)Cameras.TOP].enabled = false;
            cameras[(int)Cameras.MAIN].enabled = true;
            
        }

    }


}
