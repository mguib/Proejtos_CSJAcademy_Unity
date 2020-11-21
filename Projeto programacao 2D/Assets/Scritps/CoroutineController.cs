using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Test");
    }

    IEnumerator Test()
    {
        Debug.Log("So vai coroutine");
        yield return new WaitForSeconds(5f);
        Debug.Log("Executando depois de WaitForSeconds");
    }
}
