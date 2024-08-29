using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSMover : MonoBehaviour
{
    // 게임창에서 마우스 우클릭하면 그 위치로 이동하는 캐릭터
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
        //마우스 우클릭 했을때 움직이기
        if (Input.GetMouseButtonDown(1))
        {
            MovePlayer();
        }
    }
    private void MovePlayer()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))//여기에다 광선을 쐈을때
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.2f);//부딪히면
            Vector3 destination = hit.point;
            playerMover.Move(destination);//거기로 이동
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.2f);
        }
    }
}
