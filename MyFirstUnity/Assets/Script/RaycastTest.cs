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
        //Physices.Raycast(쏘는 위치, 쏘는 방향, RaycastHit(부딪힌 정보), 최대 거리, 레이어마스크(타겟 그룹)
       if (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))
        {
            // 레이저에 부딪힌게 있을때
            Debug.Log($"{hit.collider.gameObject.name}이랑 부딪혔고, 거리는 {hit.distance}m 떨어져있다.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }

    }


}
