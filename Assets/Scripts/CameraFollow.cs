using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player _player;
    [SerializeField] private Vector3 _platformToCameraOffset;
    public float Speed;

    private void Update()
    {
        if (_player.CurrentPlatform == null) return;

        Vector3 targetPosition = _player.CurrentPlatform.transform.position + _platformToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
