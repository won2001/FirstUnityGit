using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;


public class MoveController2 : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float upSpeed;
    

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        float y = Input.GetAxisRaw("Jump");
        

        //전진 후진
        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime, Space.Self);

        //회전
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * y * upSpeed * Time.deltaTime, Space.Self);
        }
        
        if (transform.position.y > 50)
        {
            transform.position = new Vector3(transform.position.x, 60, transform.position.z);
        }


    }
}
