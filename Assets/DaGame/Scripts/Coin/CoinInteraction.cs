using UnityEngine;

[RequireComponent(typeof(CollisionDetection))]
public class CoinInteraction : CollisionInteraction
{
    protected override void OnCollision(Collider col)
    {
        base.OnCollision(col);

        ScoreManager.Instance.RegisterCoin();
        Destroy(this.gameObject);
    }
}
