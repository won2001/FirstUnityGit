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
        float y = Input.GetAxis("Jump");

        Vector3 moveDir = new Vector3(x, y, z);
        if (moveDir == Vector3.zero)
            return;

        //�̵�
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.World);

        //ȸ��
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        //transform.rotation = lookRot;
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, rate * rotateSpeed);
    }
}
