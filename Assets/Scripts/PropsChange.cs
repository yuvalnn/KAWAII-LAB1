using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsChange : MonoBehaviour {
    private string Current_Floor;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}

    public void OnTriggerEnter(Collider other)
    {

        Current_Floor = other.gameObject.tag;
        Deal_Damage(6);

    }

    public void Deal_Damage(float DamageValue)
    {
        if (Current_Floor == "Blue")
        {
            Debug.Log("coliding");
        }
    }
    }
