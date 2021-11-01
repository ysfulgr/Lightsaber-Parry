using UnityEngine;

public class Particle : ParticleBase
{
    [SerializeField] private int p_Amount;

    public override void SpawnParticle(Vector3 spawnPoint)
    {
        for (int i = 0; i < p_Amount; i++)
        {
            GameObject particle = Instantiate(p_EffectPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
