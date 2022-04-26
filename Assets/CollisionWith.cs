using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWith : MonoBehaviour
{

    public AudioSource[] audio;
    public AudioSource noise1;
    public AudioSource noise2;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponents<AudioSource>();
        noise1 = audio[0];
        noise2 = audio[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tile = "";
        if(collision.gameObject.name == "Counter_01" || collision.gameObject.name == "Counter_02")
        {
            noise2.Play();
            noise2.loop = false;
        }
        else
        {
            for (int i = 0; i < 75; i++)
            {
                tile = "Int_WB_01_Floor_01 (" + (i + 1).ToString() + ")";
                if (collision.gameObject.name == "Counter_01" || collision.gameObject.name == tile)
                {
                    noise1.Play();
                    noise1.loop = false;
                }
            }
        }      
    }


}
