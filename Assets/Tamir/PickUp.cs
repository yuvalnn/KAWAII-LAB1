using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(AudioSource))]
public class PickUp : MonoBehaviour {
    
    


    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            GetComponent<AudioSource>().Play();
            Debug.Log("play");
        }
    }
    

 

}
