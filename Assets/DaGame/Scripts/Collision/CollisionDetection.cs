using System;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public event Action<Collider> OnCollision = delegate {}; 

    [SerializeField]
    private LayerMask _interactionLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if ((_interactionLayerMask.value & (1 << other.gameObject.layer)) != 0)
            OnCollision(other);
    }
}
