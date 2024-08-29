using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] Transform camTransform;
    [SerializeField] float rotateSpeed;
    [SerializeField] float moveSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        Move();
        Look();

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * x * moveSpeed * Time.deltaTime);
    }

    private void Look()
    {
        float x = Input.GetAxis("Mouse X");// ���콺 �¿� �����ӷ�
        float y = Input.GetAxis("Mouse Y");// ���콺 ���Ʒ� �����ӷ�

        transform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime);
        camTransform.Rotate(Vector3.right, rotateSpeed * -y * Time.deltaTime);
    }

    private void Fire()
    {
       if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
        {
            GameObject instance = hit.collider.gameObject;
            Target target = instance.GetComponent<Target>();

            if (target != null)
            {
                target.TakeHit();
            }
        }
    }
}
