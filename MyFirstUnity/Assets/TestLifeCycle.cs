using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("���� �ҳ��� �ִ�.");
    }
    void Start()
    {
        Debug.Log("�ҳ��� �������� ����.");
    }
    private void OnEnable()
    {
        Debug.Log("�ҳ��� �����̸� �����.");
    }
    private void OnDisable()
    {
        Debug.Log("�ҳ��� �����̸� ���ȴ�.");
    }
    void Update()
    {
        Debug.Log("�ҳ��� ������ Ž���ϰ� �ִ�.");
    }
    private void OnDestroy()
    {
        Debug.Log("�ҳ��� ������ Ž���ϴٰ� ��������.");
    }
}
