using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class MatchPooler : MonoBehaviour
{
    public static MatchPooler Instance { get; private set; }

    public Dictionary<string, List<GameObject>> poolDict;
    [ReadOnly] public int poolAmount;
    public int poolSafenet = 5;
    public Object[] objectsTest;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void Setup()
    {
        //poolDict = new Dictionary<string, List<GameObject>>();

        //objectsTest = Resources.LoadAll("prefabs", typeof(GameObject));

    }

    //public GameObject GetPooledObject(Transform parent)
    //{
    //    if (pooledObjects.Count < 1) return null;
    //    for (int i = 0; i < poolAmount; i++)
    //    {
    //        if (!pooledObjects[i].activeInHierarchy)
    //        {
    //            if (parent != null)
    //                pooledObjects[i].transform.SetParent(parent);
    //            return pooledObjects[i];
    //        }
    //    }
    //    return null;
    //}

    //public void ReturnToPool(GameObject gameObject)
    //{
    //    gameObject.SetActive(false);
    //    gameObject.transform.SetParent(transform);
    //}
}
