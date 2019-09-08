using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    public int spawnrate;
    private Vector3 _randomPosition;
    public bool _canInstantiate;
    public GameObject enemy;
    private void Start()
    {
        SetRanges();
    }
    private void Update()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
        
        InstantiateRandomObjects();
        
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(2, 20, 0); //Random value.
        Max = new Vector3(20, 30, 30); //Another ramdon value, just for the example.
    }
    private void InstantiateRandomObjects()
    {

        if (_canInstantiate)
        {
        Instantiate(enemy, _randomPosition, Quaternion.identity);
        }

    }
}
