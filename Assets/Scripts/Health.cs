using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    [SerializeField] ParticleSystem hitParticle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer dmg = collision.GetComponent<DamageDealer>();
        if (dmg != null)
        {
            TakeDamage(dmg.GetDamage());
            PlayHitParticles();
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

    void PlayHitParticles()
    {
        if (hitParticle != null)
        {
            ParticleSystem part = Instantiate(hitParticle, transform.position, Quaternion.identity);
            Destroy(part, 1);
        }
    }
}
