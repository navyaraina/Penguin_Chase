using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class countdisplay : MonoBehaviour{
    public TMP_Text countText;
    static int coinCount;
    public TMP_Text WinText;

    // Start is called before the first frame update
    void Start()
    {
        countText.text="0";
        WinText.text = "";
    }

    // Update is called once per frame
    void Update(){
        countText.text="Count: " + coinCount.ToString();
        WinCheck();
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("collectables")){
            coinCount+=1;
        }
    }
    void WinCheck(){
        if (coinCount==10)
        {
            WinText.text = "you win!";
            Debug.Log("WinCheck called");
            StartCoroutine(StartSceneAfterDelay(4f));
        }
    }
    IEnumerator StartSceneAfterDelay(float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("playQuit");
    }
}