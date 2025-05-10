using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideChatbox : MonoBehaviour
{
    public GameObject[] chatBox;
    void Start(){

    chatBox = GameObject.FindGameObjectsWithTag("Finish");
    }
    void Update()
    {
       foreach(GameObject cb in chatBox)
            cb.SetActive(false);
        
    }
}
