using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandleGameProgress : MonoBehaviour {
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Plane4;
    public GameObject Plane5;
    public GameObject Plane6;
    private Vector3 zPosiotion1;
    private Vector3 zPosiotion2;
    private Vector3 zPosiotion3;
    private Vector3 zPosiotion4;
    private Vector3 zPosiotion5;
    private Vector3 zPosiotion6;
    public GameObject Panel;
    public GameObject PanelHome;
    public GameObject Boss;
    public GameObject GamePoints;
    public Slider HealthBar;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    
    private Transform childObj;


    // Use this for initialization
    void Start () {

        zPosiotion1 = Plane1.GetComponent<Transform>().position;
        zPosiotion2 = Plane2.GetComponent<Transform>().position;
        zPosiotion3 = Plane3.GetComponent<Transform>().position;
        zPosiotion4 = Plane4.GetComponent<Transform>().position;
        zPosiotion5 = Plane5.GetComponent<Transform>().position;
        zPosiotion6 = Plane6.GetComponent<Transform>().position;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame()
    {
        Plane1.GetComponent<Transform>().position = zPosiotion1;
        Plane2.GetComponent<Transform>().position = zPosiotion2;
        Plane3.GetComponent<Transform>().position = zPosiotion3;
        Plane4.GetComponent<Transform>().position = zPosiotion4;
        Plane5.GetComponent<Transform>().position = zPosiotion5;
        Plane6.GetComponent<Transform>().position = zPosiotion6;

        /*Plane1.GetComponent<Movement>().enabled = false;
        Plane2.GetComponent<Movement>().enabled = false;
        Plane3.GetComponent<Movement>().enabled = false;
        Plane4.GetComponent<Movement>().enabled = false;
        Plane5.GetComponent<Movement>().enabled = false;
        Plane6.GetComponent<Movement>().enabled = false;*/
        DealDamage.CurrentHealth = 100;
        HealthBar.value = 100;
        Panel.gameObject.SetActive(false);
        GetComponent<DealDamage>().enabled = true;
        Boss.gameObject.SetActive(true);
        GamePoints.gameObject.GetComponent<Text>().text = "Points : 0";
        Drag.CurrentenumIndex = 0;
        Drag.startLiveTime = 0;
        ResetAnimation();
        InitAnimation();
        DealDamage.Gamepoints = 0;





    }

    public void MainMenu()
    {
        Plane1.GetComponent<Transform>().position = zPosiotion1;
        Plane2.GetComponent<Transform>().position = zPosiotion2;
        Plane3.GetComponent<Transform>().position = zPosiotion3;
        Plane4.GetComponent<Transform>().position = zPosiotion4;
        Plane5.GetComponent<Transform>().position = zPosiotion5;
        Plane6.GetComponent<Transform>().position = zPosiotion6;

        Plane1.GetComponent<Movement>().enabled = false;
        Plane2.GetComponent<Movement>().enabled = false;
        Plane3.GetComponent<Movement>().enabled = false;
        Plane4.GetComponent<Movement>().enabled = false;
        Plane5.GetComponent<Movement>().enabled = false;
        Plane6.GetComponent<Movement>().enabled = false;
        GetComponent<DealDamage>().enabled = false;

        Panel.gameObject.SetActive(false);
        PanelHome.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(true);
        btn4.gameObject.SetActive(true);
        btn5.gameObject.SetActive(true);

        Boss.gameObject.SetActive(false);

    }
    private void ResetAnimation()
    {
        for (int i = 0; i < GetComponent<Transform>().childCount; i++)
        {
            childObj =
            GetComponent<Transform>().GetChild(i);
            //CurrentenumIndex = enumIndex;
            childObj.gameObject.SetActive(false);
            childObj =
            GetComponent<Transform>().GetChild(i).gameObject.transform.GetChild(0);
            childObj.gameObject.SetActive(false);
            //    Debug.Log(Player.GetComponent<Transform>().GetChild(i).name);
        }
    }

    private void InitAnimation()
    {
        childObj =
           GetComponent<Transform>().GetChild(0);

        childObj.gameObject.SetActive(true);
        childObj =
        GetComponent<Transform>().GetChild(0).gameObject.transform.GetChild(0);
        childObj.gameObject.SetActive(true);
    }
}
