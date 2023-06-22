using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellor : MonoBehaviour
{
    public GameObject prop;
	public GameObject propBlured;

	public bool engenOn;

    // Update is called once per frame
    void Update()
    {
        if (engenOn) {
			prop.SetActive (false);
			propBlured.SetActive (true);
			propBlured.transform.Rotate (1000 * Time.deltaTime, 0, 0);
		} else {
			prop.SetActive (true);
			propBlured.SetActive (false);
		}
    }
}
