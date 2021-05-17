using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Camera : MonoBehaviour
{
    [SerializeField]
    private float sensivity;

    private Transform camera;
    float mouseXDir;
    float mouseYDir;

    void Start() 
    {
        camera = transform;
    }

    // Update is called once per frame
    void Update()
    {
        mouseXDir += Input.GetAxis("Mouse X") * sensivity;
        mouseYDir += Input.GetAxis("Mouse Y") * sensivity;
        mouseYDir = Mathf.Clamp(mouseYDir, -90, 90);

        Vector3 cameraRot = new Vector3(-mouseYDir, mouseXDir, 0);

        //gameObject.transform.localEulerAngles = new Vector3(0, cameraRot.y, 0);
        camera.eulerAngles = cameraRot;
    }
}
