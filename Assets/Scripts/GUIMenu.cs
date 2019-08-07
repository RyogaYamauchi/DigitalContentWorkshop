using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GUIMenu : MonoBehaviour
{
    GameObject GUI;
    GameObject Twitter;
    GameObject Google;
    GameObject Option;

    void Start()
    {
        GUI = GameObject.Find("Menu");
        Twitter = GameObject.Find("TwitterButton");
        Google = GameObject.Find("GoogleButton");
        Option = GameObject.Find("OptionButton");
    }

    public void PointerEnterAnimator(){
        
            GUI.GetComponent<Animator>().SetBool("Menu", true);
        GameObject.Find("Text1").GetComponent<Animator>().SetBool("GUITwitter", true);
        GameObject.Find("Text2").GetComponent<Animator>().SetBool("GUIGoogle", true);
        GameObject.Find("Text3").GetComponent<Animator>().SetBool("GUIOption", true);


    }

    public void PointerExitAnimator(){
        GUI.GetComponent<Animator>().SetBool("Menu", false);
        GameObject.Find("Text1").GetComponent<Text>().color = new Color (210f,255f,220f,0f);
        GameObject.Find("Text2").GetComponent<Text>().color = new Color(210f, 255f, 220f, 0f);
        GameObject.Find("Text3").GetComponent<Text>().color = new Color(210f, 255f, 220f, 0f);
        GameObject.Find("Text1").GetComponent<Animator>().SetBool("GUITwitter", false);
        GameObject.Find("Text2").GetComponent<Animator>().SetBool("GUIGoogle", false);
        GameObject.Find("Text3").GetComponent<Animator>().SetBool("GUIOption", false);

    }
}