using UnityEngine;

public class BadCoinInteraction : CollisionInteraction
{
    protected override void OnCollision(Collider col)
    {
        base.OnCollision(col);

        ScoreManager.Instance.RegisterBadCoin();
        Destroy(this.gameObject);
    }
}
