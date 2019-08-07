using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    GameObject Camera;
    float x;
    float y;
    float z;
	// Use this for initialization
	void Start () {
        Camera = GameObject.Find("Camera");
	}
	
	// Update is called once per frame
	void Update () {
        x = Camera.transform.position.x;
        y = Camera.transform.position.y;
        z = Camera.transform.position.z;
        this.transform.position = new Vector3(x,y,z);
	}
}
