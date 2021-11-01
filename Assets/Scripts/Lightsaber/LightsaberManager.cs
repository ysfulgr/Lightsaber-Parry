using UnityEngine;
using System;


[Serializable]
public class LightsaberManager
{
    [SerializeField] Color m_LightColorStart;

    public SpawnPoint m_SpawnPoint;

    [HideInInspector] public GameObject m_Instance;
    private LightsaberBase m_Lightsaber;
    public void Setup()
    {
        m_Lightsaber = m_Instance.GetComponentInChildren<Lightsaber>();
        m_Lightsaber.l_LightColorStart = m_LightColorStart;
        m_Lightsaber.SetColor();
    }
}
