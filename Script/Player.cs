using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform leftTopCorner;
    public Transform RightBottomCorner;


    [Range(1, 50)]
    public float HorizontalSpeed = 40;
    [Range(1, 50)]
    public float VerticalSpeed = 40;

    void Update()
    {
        movment();

        if (transform.position.z < leftTopCorner.position.z)
            transform.position = new Vector3(transform.position.x, transform.position.y, leftTopCorner.position.z);

        if(transform.position.x > leftTopCorner.position.x)
            transform.position = new Vector3(leftTopCorner.position.x, transform.position.y, transform.position.z);

        if (transform.position.z > RightBottomCorner.position.z)
            transform.position = new Vector3(transform.position.x, transform.position.y, RightBottomCorner.position.z);

        if (transform.position.x < RightBottomCorner.position.x)
            transform.position = new Vector3(RightBottomCorner.position.x, transform.position.y, transform.position.z);
    }
    void movment()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeed);
    }
}
