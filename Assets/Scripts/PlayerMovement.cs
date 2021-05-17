using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform playerCamera;

    private CharacterController controller;

    private Transform playerTransform;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMovement = Input.GetAxisRaw("Vertical");
        float rightMovement = Input.GetAxisRaw("Horizontal");
        Vector3 newForwardVector = new Vector3(playerCamera.forward.x, 0, playerCamera.forward.z) * forwardMovement;
        Vector3 newRightVector = new Vector3(playerCamera.right.x, 0, playerCamera.right.z) * rightMovement;
        controller.Move((newForwardVector + newRightVector).normalized * speed * Time.deltaTime);
    }
}
