using System;
using UnityEngine;

public abstract class CollisionInteraction : MonoBehaviour
{
    public virtual event Action OnInteraction = delegate { };
    private CollisionDetection _collisionDetection;

    private void Awake()
    {
        _collisionDetection = GetComponent<CollisionDetection>();

        _collisionDetection = GetComponent<CollisionDetection>();
        _collisionDetection.OnCollision += OnCollision;
    }

    protected virtual void OnCollision(Collider col)
    {
        OnInteraction();
    }
}
