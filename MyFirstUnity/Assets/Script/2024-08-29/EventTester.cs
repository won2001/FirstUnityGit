using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    [SerializeField] float screamVolume;

    //public event Action OnScream1;
    public UnityEvent<float> OnScream;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scream();
        }
    }

    private void Scream()
    {
        Debug.Log("�Ҹ�����");
        OnScream?.Invoke(screamVolume); //�̺�Ʈ �߻���Ű��
    }
}
