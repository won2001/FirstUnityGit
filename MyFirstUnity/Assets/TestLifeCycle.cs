using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("멋진 소년이 있다.");
    }
    void Start()
    {
        Debug.Log("소년은 던전으로 들어갔다.");
    }
    private void OnEnable()
    {
        Debug.Log("소년은 돌맹이를 들었다.");
    }
    private void OnDisable()
    {
        Debug.Log("소년은 돌맹이를 버렸다.");
    }
    void Update()
    {
        Debug.Log("소년은 던전을 탐험하고 있다.");
    }
    private void OnDestroy()
    {
        Debug.Log("소년은 던전을 탐험하다가 쓰러졌다.");
    }
}
