using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    void Start()
    {
        StartCoroutine(InstantiateEnemy());
    }

    IEnumerator InstantiateEnemy()
    {
        Instantiate(enemy);
        yield return new WaitForSeconds(1f);
    }
}
