using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;
    [SerializeField] private Transform _pointToSpawn;
    private int n = 0;

    public T GetNewInstance()
    {
        Vector3 pos = new Vector3(_pointToSpawn.position.x + n, _prefab.transform.position.y, _pointToSpawn.position.z);
        n++;
        return Instantiate(_prefab, pos, Quaternion.identity);
    }
}