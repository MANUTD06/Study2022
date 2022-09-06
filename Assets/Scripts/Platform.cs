using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _audio.Play();
            player.CurrentPlatform = this;
        }

        
    }
}
