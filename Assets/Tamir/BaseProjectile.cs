using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour
{

    
    public float Bspeed;
    private float FirstTime;
    public float BulletEndTime = 5;
    private bool isBack;





    //[SerializeField] float speesd = 4f; // not public but visible on inspector

    // Use this for initialization
    void Start ()
    {
        FirstTime = Time.time;
        isBack = false;

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (isBack== false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Bspeed);
        }
        else if (isBack)
        {
            transform.Translate(Vector3.back * Time.deltaTime * Bspeed);
        }
        

        if (BulletEndTime < FirstTime)
        {
            //Destroy(this);

        }
      


    }

    public void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Player")
        {
            Debug.Log("HIT Player");
            isBack = true;

        }



    }





    //public abstract void FireProjectile(GameObject launcher, GameObject target, int damage, float attackSpeed);


}
