using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTester : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Collider[] colls;

    public void Start()
    {
        target = gameObject.GetComponent<Transform>();
        colls = gameObject.GetComponentsInChildren<Collider>();

        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log($"{i} - {transform.GetChild(i).gameObject.name}");
        }
        
    }
}
