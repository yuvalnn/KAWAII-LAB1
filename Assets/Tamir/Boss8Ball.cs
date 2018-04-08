using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss8Ball : MonoBehaviour
{

    private int Hit8Ball;
    public Texture Textures8;
    public Texture Textures7;
    public Texture Textures6;
    public Texture Textures5;
    public Texture Textures4;
    public Texture Textures3;
    public Texture Textures2;
    public Texture Textures1;
    public Texture CurrentTexture;
    public GameObject BossBallMesh;
    public GameObject BossBall;


    // Use this for initializationte
    void Start()
    {
        Hit8Ball = 8;
        CurrentTexture = Textures8;
        BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bullet")
        {
            Hit8Ball--;
            Debug.Log("HIT 8ball counter: " + Hit8Ball);


            if (Hit8Ball == 7)
            {
                CurrentTexture = Textures7;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            
            if (Hit8Ball == 6)
            {
                CurrentTexture = Textures6;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            
            if (Hit8Ball == 5)
            {
                CurrentTexture = Textures5;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            if (Hit8Ball == 4)
            {
                CurrentTexture = Textures4;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            if (Hit8Ball == 3)
            {
                CurrentTexture = Textures3;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            if (Hit8Ball == 2)
            {
                CurrentTexture = Textures2;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }

            if (Hit8Ball == 1)
            {
                CurrentTexture = Textures1;
                BossBallMesh.GetComponent<Renderer>().material.mainTexture = CurrentTexture;
            }



            if (Hit8Ball == 0)
            {
                DestroyGameObject();
            }

        }

        

    }

                void DestroyGameObject()
                {
                    Destroy(BossBall);
                }
}
