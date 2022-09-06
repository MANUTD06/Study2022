using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _angularSpeed;

    private void Update()
    {
        transform.Rotate(_angularSpeed * Time.deltaTime);
    }
}
