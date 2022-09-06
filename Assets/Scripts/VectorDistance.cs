using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDistance : MonoBehaviour
{
    [SerializeField] private Transform _vector1;
    [SerializeField] private Transform _vector2;

    private void Update()
    {
        float distance = Vector3.Distance(_vector1.position, _vector2.position);
        transform.position = new Vector3(distance, distance, distance);
        Debug.Log(distance);
    }
}
