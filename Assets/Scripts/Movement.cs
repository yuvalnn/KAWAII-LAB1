using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speedPlate;
    public GameObject planestoplocation;
    // Use this for initialization
    void Start () {
        speedPlate = 8;

    }
	
	// Update is called once per frame
	void Update () {
        if  (planestoplocation.transform.position.z < 10 && planestoplocation.tag == "bos")
        {
            //transform.Translate(Vector3.back * Time.deltaTime * speedPlate); // no traansform
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime * speedPlate);
        }
        
    }
}
