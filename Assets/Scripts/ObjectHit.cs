using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material afterHitMaterial;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material = afterHitMaterial;
            gameObject.tag = "Hit";
        }
    }
}
