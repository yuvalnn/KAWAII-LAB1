using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealDamage : MonoBehaviour {
    //Define Enum
    public enum Props_Enum { desertProps, boatProps, snowProps ,skyProps, trainProps };
    //This what you need to show in the inspector.
    private Props_Enum Current_props;
    private string Current_Plane;
    public Slider HealthBar;
    public float MaxHealth;
    public static float CurrentHealth;
    public GameObject Panel;
    private bool isHit;
    private bool isPickup;
    public GameObject points;
    public static int Gamepoints;
    




    // Use this for initialization
    void Start () {

        CurrentHealth = MaxHealth;
        HealthBar.value = CalaulateDamage();
        Debug.Log("start");
        points.gameObject.GetComponent<Text>().text = "Points:  ";

    }


    // Update is called once per frame
    void Update () {
        Current_props = (Props_Enum)Drag.CurrentenumIndex;
        Deal_Damage(1);
        if (HealthBar.value <= 0 )
        {
            Panel.gameObject.SetActive(true);
           // Canvas.
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Obstacle" && other.gameObject.tag != "pickup")
        {

            Current_Plane = other.gameObject.tag;
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            isHit = true;
        }
        else if (other.gameObject.tag == "pickup")
        {
            Debug.Log("pickup");
            isPickup = true;
        }

        //Debug.Log(other.gameObject.tag);
        Deal_Damage(1);
        Current_props = (Props_Enum)Drag.CurrentenumIndex;



    }
    private void Deal_Damage(float DamageValue)
    {
        if (Current_Plane == "desert")
        {
            if (Current_props != Props_Enum.desertProps)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Plane == "water")
        {
            if (Current_props != Props_Enum.boatProps)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Plane == "snow")
        {
            if (Current_props != Props_Enum.snowProps)

            {

               CurrentHealth -= DamageValue;
               HealthBar.value = CalaulateDamage();

            }
        }
        if (Current_Plane == "sky")
        {
            if (Current_props != Props_Enum.skyProps)

            {

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();

            }
        }
        if (Current_Plane == "train")
        {
            if (Current_props != Props_Enum.trainProps)

            {

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();

            }
        }

        if (isHit)
        {
          

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
                isHit = false;

            
        }

        if (isPickup)
        {

            Gamepoints += 1;
            points.gameObject.GetComponent<Text>().text = "Points:  " +
                                                          Gamepoints.ToString();
            isPickup = false;


        }





    }

    float CalaulateDamage()
    {
        return CurrentHealth / MaxHealth;
    }


}
