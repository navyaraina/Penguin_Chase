using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocoin : MonoBehaviour
{
    AudioSource coinSound;
    
    // Start is called before the first frame update
    void Start()
    {
        coinSound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("collectables")){
            coinSound.Play();
        }
    }
}
