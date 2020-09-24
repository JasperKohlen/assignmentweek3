using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMoveCube : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 v = new Vector3(-7, 4, 1);
        cube.transform.position = v;
    }
}
