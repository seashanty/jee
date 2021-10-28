using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivy = 250f;
    public float minXAngle = -80f;
    public float maxAngle = 90f;

    Transform playerbody;
    private float mouseX;

    private float mouseY;
    private float xRotation = 0f;
    public CursorLockMode mode;
    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState =mode;
      playerbody = gameObject.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
         mouseX = Input.GetAxis("Mouse X") *mouseSensitivy * Time.deltaTime;
         mouseY = Input.GetAxis("Mouse Y") *mouseSensitivy * Time.deltaTime;   
         xRotation -= mouseY;

         xRotation = Mathf.Clamp(xRotation,minXAngle,maxAngle);
         transform.localRotation = Quaternion.Euler(xRotation,0 ,0);
         playerbody.Rotate(Vector3.up * mouseX);
         
    }
         


}
