using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    //[SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        //Self�� ������������ ������ �̵� World�� ������ �������� �̵�
        //Rotate�� ���������� Self�� ������������ ȸ�� World�� ������ �������� ȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }

}
