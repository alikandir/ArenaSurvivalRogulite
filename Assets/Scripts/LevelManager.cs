using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager main;
    [SerializeField] Transform startingPoint;
    [SerializeField] Transform[] path;
    private void Awake()
    {
        main=this;
    }

    private void Start()
    {
        return;
    }

    private void Update()
    {
        
    }
}
