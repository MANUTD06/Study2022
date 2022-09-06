using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMultiply : MonoBehaviour
{
    [SerializeField] private Transform _object;
    [SerializeField] private float _multiply;

    private void Update()
    {
        transform.position = _object.position * _multiply;
    }
}
