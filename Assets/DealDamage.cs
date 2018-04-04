using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealDamage : MonoBehaviour {
    //Define Enum
    public enum Props_Enum { waterProps, fireProps, forestProps };
    //This what you need to show in the inspector.
    private Props_Enum Current_props;
    private string Current_Plane;
    public Slider HealthBar;
    public float MaxHealth;
    private float CurrentHealth;
    // Use this for initialization
    void Start () {

        CurrentHealth = MaxHealth;
        HealthBar.value = CalaulateDamage();

    }
	
	// Update is called once per frame
	void Update () {
        Current_props = (Props_Enum)Drag.CurrentenumIndex;
        Deal_Damage(1);

    }
    public void OnTriggerEnter(Collider other)
    {
        
        Current_Plane = other.gameObject.tag;
        Debug.Log(other.gameObject.tag);
        Deal_Damage(1);
        Current_props = (Props_Enum)Drag.CurrentenumIndex;
        

    }
    private void Deal_Damage(float DamageValue)
    {
        if (Current_Plane == "Water")
        {
            if (Current_props != Props_Enum.waterProps)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Plane == "Fire")
        {
            if (Current_props != Props_Enum.fireProps)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Plane == "Forest")
        {
            if (Current_props != Props_Enum.forestProps)

            {

               CurrentHealth -= DamageValue;
               HealthBar.value = CalaulateDamage();

            }
        }

       


    }

    float CalaulateDamage()
    {
        return CurrentHealth / MaxHealth;
    }

}
