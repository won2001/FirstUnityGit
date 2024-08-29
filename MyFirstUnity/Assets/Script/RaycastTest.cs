using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint;
    [SerializeField] float maxDistance;
    [SerializeField] LayerMask layerMask;
    private void Update()
    {
        //Physices.Raycast(��� ��ġ, ��� ����, RaycastHit(�ε��� ����), �ִ� �Ÿ�, ���̾��ũ(Ÿ�� �׷�)
       if (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))
        {
            // �������� �ε����� ������
            Debug.Log($"{hit.collider.gameObject.name}�̶� �ε�����, �Ÿ��� {hit.distance}m �������ִ�.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }

    }


}
