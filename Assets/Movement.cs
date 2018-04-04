using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speedPlate;
    // Use this for initialization
    void Start () {
        speedPlate = 3;

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * Time.deltaTime * speedPlate);
    }
}
