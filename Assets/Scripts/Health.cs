using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer dmg = collision.GetComponent<DamageDealer>();
        if (dmg != null)
        {
            TakeDamage(dmg.GetDamage());
            dmg.Hit();
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
