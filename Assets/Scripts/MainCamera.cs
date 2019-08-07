using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    float inputHorizontal;
    float inputVertical;  


    GameObject Camera;
    GameObject Player;

    CharacterController controller; 
    Vector3 moveDirection;

    Transform verRot;
    Transform horRot;

    float fSpeed = 10.0f; 
    

    // Use this for initialization
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();

        Camera = GameObject.Find("Camera");

        controller = GetComponent("CharacterController") as CharacterController;
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation, 0);
        horRot.transform.Rotate(-Y_Rotation, 0, 0);

        Vector3 forward = Camera.transform.TransformDirection( Vector3.forward ); 
        Vector3 right = Camera.transform.TransformDirection( Vector3.right ); 
        moveDirection = Input.GetAxis("Horizontal") * right + Input.GetAxis("Vertical") * forward; 
        moveDirection *= fSpeed; 
 
        // 移動 
        controller.Move( moveDirection * Time.deltaTime );

    }
        
}