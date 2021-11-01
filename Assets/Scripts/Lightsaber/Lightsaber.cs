using UnityEngine;
public class Lightsaber : LightsaberBase
{
    private ParticleSystem _particleSystem;
    public ParticleSystem particleSystem
    {
        get
        {
            if (_particleSystem == null)
                _particleSystem = GetComponentInChildren<ParticleSystem>();

            return _particleSystem;
        }
    }

    [SerializeField]
    EventNames l_EventNames;
    private void Start()
    {
        particleSystem.Play();
    }
    public override void SetColor()
    {
        particleSystem.startColor = l_LightColorStart;
    }
}
