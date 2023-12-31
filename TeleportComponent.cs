using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportComponent : MonoBehaviour
{
    [SerializeField] private Transform _destPosition;

    public void Teleport(GameObject target)
    {
        target.transform.position = _destPosition.position;
    }

}
