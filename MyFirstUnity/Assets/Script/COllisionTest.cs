using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COllisionTest : MonoBehaviour
{
    // �浹�� �������� ��
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("�÷��̾�� �ε����� �Ѿ��� �������� �ش�.");

    }

    // �浹 ���� ��
    private void OnCollisionStay(Collision collision)
    {
        
    }

    // �浹�� ������ ��
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
