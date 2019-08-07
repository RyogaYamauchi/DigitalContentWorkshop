using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour {
    GameObject TreeObj;
	// Use this for initialization
	void Start () {
        TreeObj = GameObject.Find("GUI");
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        
        GameObject.Find("GUIText").GetComponent<Text>().text = "めっちゃ木の近くおるで";
        TreeObj.GetComponent<Animator>().SetBool("GUI", true);

    }
    void OnTriggerExit(Collider collider){
        TreeObj.GetComponent<Animator>().SetBool("GUI", false);
    }
}
