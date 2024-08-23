using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController2 : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //���� ����
        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime, Space.Self);

        //ȸ��
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime);
    }
}
