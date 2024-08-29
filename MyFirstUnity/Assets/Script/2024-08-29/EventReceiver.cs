using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;

    public void Jump(float power)
    {
        rigid.AddForce(Vector3.up * power, ForceMode.Impulse);
    }
}
