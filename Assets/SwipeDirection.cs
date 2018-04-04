using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDirection : MonoBehaviour {


    private float LeftRoutePosition;
    private float RightRoutePosition;
    private float xPos;
    private float swipeDelta;
    private Vector3 CurrentPosition;
    

    private void Start()
    {
        LeftRoutePosition = transform.position.x - 1;
        RightRoutePosition = transform.position.x + 1;
        CurrentPosition = this.GetComponent<Transform>().position;
    }
    private void Update()
    {



    }

    void ResetPosition()
    {

        CurrentPosition = this.GetComponent<Transform>().position;

    }
    void OnMouseDown()
    { 
        xPos = Input.mousePosition.x;
    }


    void OnMouseUp()
    {
              swipeDelta = xPos - Input.mousePosition.x;


        // Did we cross the deadzone?
        if (swipeDelta > (float)0.1 && LeftRoutePosition < transform.position.x)
        {
           

            this.GetComponent<Transform>().position = new Vector3(CurrentPosition.x - 1,
               CurrentPosition.y,
               CurrentPosition.z);
            ResetPosition();

        
        }
        else if (swipeDelta < (float)0.1 && RightRoutePosition > transform.position.x)
        {
            this.GetComponent<Transform>().position = new Vector3(CurrentPosition.x + 1,
                   CurrentPosition.y,
                   CurrentPosition.z);
            ResetPosition();

        }

    }





}
