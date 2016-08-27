using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class IACar : AnimateCar
{



    protected override IEnumerator Animation()
    {
        _startAnimate = true;

        Debug.Log("Acelerando");
        v = 0.5f;
        yield return new WaitForSeconds(5f);
        Debug.Log("Manobrando");
        h = -0.5f;
        v = 0;
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Acelerando");
        h = 0;
        v = 0.3f;
        yield return new WaitForSeconds(2f);
        Debug.Log("Manobrando");
        h = -0.5f;
        v = 0;
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Acelerando");
        h = 0;
        v = 0.3f;
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Manobrando");
        h = -0.5f;
        v = 0;
        yield return new WaitForSeconds(2.3f);
        Debug.Log("Acelerando");
        h = 0;
        v = 0.3f;
        yield return new WaitForSeconds(2f);
        Debug.Log("Parando");
        h = 0;
        v = 0;
    }
}
