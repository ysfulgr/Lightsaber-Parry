using UnityEngine;
public abstract class ParticleBase : MonoBehaviour
{
    public GameObject p_EffectPrefab;
    public abstract void SpawnParticle(Vector3 spawnPoint);

}
