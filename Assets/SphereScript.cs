using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
