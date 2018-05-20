
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;

    float mouseX, mouseY;
    [SerializeField] float lookSpeed;
    [SerializeField] Transform head;

    float movH, movV;
    [SerializeField] float speed;

    [SerializeField] GunController gun;

    void Start ()
    {
        controller = GetComponent<CharacterController>();
	}
	
	void Update ()
    {
        movV = Input.GetAxis("Vertical");
        movH = Input.GetAxis("Horizontal");

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        // Movement
        if (movV > 0.1f || -0.1f > movV || movH > 0.1f || -0.1f > movH) controller.SimpleMove(transform.forward * speed * movV + transform.right * speed * movH);

        // Turning
        if (mouseX > 0.1f || -0.1f > mouseX) transform.eulerAngles += new Vector3(0, mouseX * lookSpeed * Time.deltaTime, 0);

        //Looking up/down
        if (mouseY > 0.1f || -0.1f > mouseY) head.eulerAngles += new Vector3(-mouseY * lookSpeed * Time.deltaTime, 0, 0);

        //Shooting
        if (Input.GetMouseButtonDown(0)) gun.Shoot();
    }
}
