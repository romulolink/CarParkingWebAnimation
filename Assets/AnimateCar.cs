using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.CrossPlatformInput;

public class AnimateCar : CarUserControl
{
    protected bool _startAnimate;

    void Start () {
	
	}

    private void FixedUpdate()
    {
        // pass the input to the car!
        //  h = CrossPlatformInputManager.GetAxis("Horizontal");
        //  v = CrossPlatformInputManager.GetAxis("Vertical");
        if (!_startAnimate)
            StartCoroutine(Animation());
#if !MOBILE_INPUT
        float handbrake = CrossPlatformInputManager.GetAxis("Jump");
        m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
    }

    protected virtual IEnumerator Animation()
    {
        _startAnimate = true;

        Debug.Log("Acelerando");
        v = 0.5f;
        yield return new WaitForSeconds(5f);
        Debug.Log("Manobrando");
        h = -0.5f;
        v = 0;
        yield return new WaitForSeconds(3.2f);
        Debug.Log("Dando Ré");
        v = -0.3f;
        h = 1f;
        yield return new WaitForSeconds(5.5f);
        Debug.Log("Parando");
        v = 0;
        h = 0;
        yield return new WaitForSeconds(2f);
        Debug.Log("Ajeitando o carro");
        v = 0.5f;
        yield return new WaitForSeconds(1.5f);
        Debug.Log("Ajeitando o carro");
        v = -0.5f;
        yield return new WaitForSeconds(2f);
        Debug.Log("Ajeitando o carro");
        v = 0f;

    }
}
