using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePoolable : PoolableObject
{
    protected override void OnEnable()
    {
        base.OnEnable();
        Debug.Log("Pooled projectile");
    }
}
