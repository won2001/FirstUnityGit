using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotationController : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float angle;

    [SerializeField] Transform target;

    private void Update()
    {
        
    }

    private void RotationRotate()//������ ȸ���ϱ� (������)
    {
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

    private void RotateRotate()//������ ȸ���ϱ� (������)
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
    
    private void RotateAroundRotate()//�������� �߽����� ȸ���ϱ�
    {
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void LookAtRotate()//�������� �ٶ󺸵��� ȸ���ϱ�
    {
        transform.LookAt(target.position);
    }
}
