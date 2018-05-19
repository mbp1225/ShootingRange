
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;

    [SerializeField] float speed;
    [SerializeField] float lookSpeed;

    float movH, movV;
    float mouseX, mouseY;

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

        if (movV > 0.1f || -0.1f > movV || movH > 0.1f || -0.1f > movH) controller.SimpleMove(transform.forward * speed * movV + transform.right * speed * movH);

        if (mouseX > 0.1f || -0.1f > mouseX) transform.eulerAngles += new Vector3(0, mouseX * lookSpeed * Time.deltaTime, 0);
    }
}
