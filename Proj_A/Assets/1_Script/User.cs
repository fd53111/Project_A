using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public Transform objectFrontVector;

    private float h = 0.0f;
    private float v = 0.0f;
    public float walkSpeed = 3.0f;
    public float runSpeed = 6.0f;
    private float moveSpeed = 3.0f;
    public float cameraH = 0.85f;

    private float yRotate, yRotateMove;
    public float rotateSpeed = 500.0f;

    void Start()
    {
        moveSpeed = walkSpeed;
    }


    void Update()
    {
        /* debug */
        Debug.DrawLine(transform.position, objectFrontVector.position, Color.red);

        /* player 이동 */
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        transform.Translate(moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        /* 회전 */
        //if (Input.GetMouseButton(0)) // 클릭한 경우
        // {
        yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

        yRotate = transform.eulerAngles.y + yRotateMove;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotate, 0);
        // }

        if (Input.GetKey(KeyCode.LeftShift))
        {

            moveSpeed = runSpeed;

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

            moveSpeed = walkSpeed;

        }

        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + cameraH, this.transform.position.z);
    }
}
