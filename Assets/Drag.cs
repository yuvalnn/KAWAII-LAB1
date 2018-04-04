using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Drag : MonoBehaviour
    {


    //Define Enum
    
    public enum Props_Enum { waterProps, fireProps, forestProps};
    public Animator GraphicsAnimation;
    

    private double ObjYPos = 1.441328;
    private Vector3 objPosition;
    private float startLiveTime;
    private float EndLiveTime;
    private Vector3 StartPosition;
    public GameObject Player;
    public GameObject Plane;
    public Props_Enum Current_props;
    private string Current_Plane;
    public int enumIndex;
    public static int CurrentenumIndex;
    private Transform childObj;

    private void Start()
    {
        //for ( int i = 0; i <= Player.GetComponent<Transform>().childCount; i++)
 {
            
        //    Debug.Log(Player.GetComponent<Transform>().GetChild(i).name);
        }
        // Inilazie Graphicis
        //        Player.GetComponent<Transform>().GetChild(enumIndex).gameObject.SetActive(false);

        //childObj.gameObject.SetActive(false);
        StartPosition = GetComponent<Transform>().position;
    }

    private void Update()
    {
        if (Time.time > startLiveTime)
        {
            GetComponent<Renderer>().enabled = true;
            
        }
    }
    void OnMouseDrag()
    {
        float distance = 4;
       
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;

    }

    public void OnMouseUp()
    {
        
        if (objPosition.y > ObjYPos)
        {
            setProps(enumIndex);   
        }
        else
        {
            GetComponent<Transform>().position = StartPosition;
        }

    }

    public void setProps(int enumIndex)
    {
        this.GetComponent<Renderer>().enabled = false;
        this.GetComponent<Transform>().position = StartPosition;
        startLiveTime = Time.time + 5;
        Current_props = (Props_Enum)enumIndex;
        SetUIByEnum();
        //Player.GetComponent<Renderer>().material.color = GetComponent<Renderer>().material.color;

    }

   

    private void SetUIByEnum()
    {
        ResetAnimation();
        switch (Current_props)
        {
            case Props_Enum.fireProps:
                
                SetAnimation();
                GraphicsAnimation.SetTrigger("fire_now");
                CurrentenumIndex = enumIndex;
                Debug.Log("Fire");
                break;
            case Props_Enum.forestProps:
                SetAnimation();
                GraphicsAnimation.SetTrigger("forest_now");
                // rend.material.color = new Color(0.859f, 0.404f, 0.827f);
                CurrentenumIndex = enumIndex;
                Debug.Log("forest");
                break;
            case Props_Enum.waterProps:
                
                SetAnimation();
                GraphicsAnimation.SetTrigger("Surf_now");
                CurrentenumIndex = enumIndex;
                Debug.Log("water");
                //  rend.material.color = Color.yellow;
                break;
                    
          
            default:
                //  rend.material.color = new Color(0.859f, 0.404f, 0.827f);
                break;
        }
    }

    private void ResetAnimation()
    {
        for ( int i = 0; i < Player.GetComponent<Transform>().childCount; i++)
        {
            childObj =
            Player.GetComponent<Transform>().GetChild(i);
            //CurrentenumIndex = enumIndex;
            childObj.gameObject.SetActive(false);
            childObj =
            Player.GetComponent<Transform>().GetChild(i).gameObject.transform.GetChild(0);
            childObj.gameObject.SetActive(false);
            //    Debug.Log(Player.GetComponent<Transform>().GetChild(i).name);
        }
    }

    private void SetAnimation()
    {
        childObj =
           Player.GetComponent<Transform>().GetChild(enumIndex);
        
        childObj.gameObject.SetActive(true);
        childObj =
        Player.GetComponent<Transform>().GetChild(enumIndex).gameObject.transform.GetChild(0);
        childObj.gameObject.SetActive(true);
    }



}

