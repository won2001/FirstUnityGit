using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSMover : MonoBehaviour
{
    // ����â���� ���콺 ��Ŭ���ϸ� �� ��ġ�� �̵��ϴ� ĳ����
    [SerializeField] Camera cam;
    [SerializeField] GameObject playerObject;
    [SerializeField] PlayerMover playerMover;
    [SerializeField] LayerMask layerMask;

    private void Start()
    {
        cam = Camera.main;
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerMover = playerObject.GetComponent<PlayerMover>();
    }

    private void Update()
    {
        //���콺 ��Ŭ�� ������ �����̱�
        if (Input.GetMouseButtonDown(1))
        {
            MovePlayer();
        }
    }
    private void MovePlayer()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))//���⿡�� ������ ������
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.2f);//�ε�����
            Vector3 destination = hit.point;
            playerMover.Move(destination);//�ű�� �̵�
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.2f);
        }
    }
}
