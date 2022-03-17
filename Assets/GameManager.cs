using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int point = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        point = 0;
    }
}
