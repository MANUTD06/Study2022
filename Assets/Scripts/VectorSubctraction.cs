using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorSubctraction : MonoBehaviour
{
    [SerializeField] private Transform _vector1;
    [SerializeField] private Transform _vector2;

    private void Update()
    {
        transform.position = _vector1.position - _vector2.position;
    }
}
