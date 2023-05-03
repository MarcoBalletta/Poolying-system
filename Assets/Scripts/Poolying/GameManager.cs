using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PoolerEntity pooler;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public PoolerEntity Pooler { get => pooler; }
}
