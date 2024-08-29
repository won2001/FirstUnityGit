using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{

    private void Start()
    {
       Coroutine coroutine = StartCoroutine(Routine());
    }
    private void Update()
    {
        Debug.Log("Update");
    }

    IEnumerator Routine()
    {
        Debug.Log("coroutine 0");
        yield return new WaitForSeconds(1f);
        Debug.Log("coroutine 1");
        yield return new WaitForSeconds(1f);
    }
}
