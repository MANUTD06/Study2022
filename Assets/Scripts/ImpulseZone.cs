using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseZone : MonoBehaviour
{
    public GameObject[] go;
    public string ZoneName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " is triggered " + ZoneName + " zone!");
        ImpulseObjects(go);
    }

    public void ImpulseObjects(GameObject[] gameobjects)
    {
        foreach (var item in gameobjects)
        {
            Rigidbody rigidbody = item.GetComponent<Rigidbody>();
            rigidbody.AddForce(new Vector3(0f, 20f, 0f), ForceMode.Impulse);
        }
    }

}
