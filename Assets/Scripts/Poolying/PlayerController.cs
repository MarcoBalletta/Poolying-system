using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    List<PoolableObject> objects = new List<PoolableObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var go = GameManager.instance.Pooler.GetEntity();
            go.transform.SetParent(transform);
            objects.Add(go);
            go.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameManager.instance.Pooler.DisposeEntity(objects[0]);
            objects.RemoveAt(0);
        }
    }
}
