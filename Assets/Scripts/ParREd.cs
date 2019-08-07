using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParREd : MonoBehaviour
{
    GameObject GUI;
    // Use this for initialization
    void Start()
    {
        GUI = GameObject.Find("GUI");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {

        GameObject.Find("GUIText").GetComponent<Text>().text = "可愛さ２上がるで";
        GUI.GetComponent<Animator>().SetBool("GUI", true);

    }
    void OnTriggerExit(Collider collider)
    {
        GUI.GetComponent<Animator>().SetBool("GUI", false);
    }
}
