using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public Transform Player;
    public Vector3 DestroyOffset;
    public PlatformCountText PlatformCountText;
   [SerializeField] private ParticleSystem _particle; 

    void Update()
    {
        transform.position = Player.transform.position + DestroyOffset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Platform platform))
        {
            _particle.Play();
            platform.gameObject.SetActive(false);
            PlatformCountText.PlatformsCount++;
        }
    }
}
