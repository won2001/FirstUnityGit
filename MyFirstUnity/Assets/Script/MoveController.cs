using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float rate;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(x, 0, z);
        if (moveDir == Vector3.zero)
            return;

        //이동
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.World);

        //회전
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        //transform.rotation = lookRot;
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, rate * rotateSpeed);
    }
}
