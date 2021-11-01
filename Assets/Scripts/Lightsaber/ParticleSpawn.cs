using UnityEngine;
[RequireComponent(typeof (Particle))]
public class ParticleSpawn : MonoBehaviour
{
    private Particle _particle;
    public Particle particle
    {
        get
        {
            if (_particle == null)
                _particle = GetComponent<Particle>();

            return _particle;
        }
    }
    private void Start()
    {

        EventManager.AddEvent<Vector3>(EventNames.EventSpawnParticle, SpawnParticle) ;
    }

    void SpawnParticle(Vector3 point)
    {
        particle.SpawnParticle(point);
    }


}
