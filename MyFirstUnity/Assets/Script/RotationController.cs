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

    private void RotationRotate()//축으로 회전하기 (값으로)
    {
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

    private void RotateRotate()//축으로 회전하기 (각도로)
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
    
    private void RotateAroundRotate()//기준점을 중심으로 회전하기
    {
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void LookAtRotate()//기준점을 바라보도록 회전하기
    {
        transform.LookAt(target.position);
    }
}
