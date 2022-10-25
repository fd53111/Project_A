using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraTest : MonoBehaviour
{
    private float xRotate, yRotate, xRotateMove, yRotateMove;
    public float rotateSpeed = 500.0f;

    void Update()
    {
        //if (Input.GetMouseButton(0)) // Ŭ���� ���
        //{
        xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
        yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

        yRotate = transform.eulerAngles.y + yRotateMove;
        //xRotate = transform.eulerAngles.x + xRotateMove; 

        xRotate = xRotate + xRotateMove;

        xRotate = Mathf.Clamp(xRotate, -50, 50); // ��, �Ʒ� ����

        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        // }
    }
}
