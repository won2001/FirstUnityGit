using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTester : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float power;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up *  power, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddTorque(Vector3.up * power, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigid.velocity = new Vector3(1, 0, 1);
        }
    }
}
