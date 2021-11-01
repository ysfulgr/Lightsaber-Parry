using UnityEngine;

public class GameManager:MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            return _instance;
        }
    }

    [SerializeField]
    private GameObject[] m_LightsaberPrefabs;

    [SerializeField]
    private LightsaberManager[] m_LightsaberManager;


    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        LightsaberSpawn();
    }

    void LightsaberSpawn()
    {
        for (int i = 0; i < m_LightsaberManager.Length; i++)
        {
            // create them, set players color.
            m_LightsaberManager[i].m_Instance = Instantiate(m_LightsaberPrefabs[i], m_LightsaberManager[i].m_SpawnPoint.GetSpawnPoint(), Quaternion.identity) as GameObject;
            m_LightsaberManager[i].m_SpawnPoint.SetParent(m_LightsaberManager[i].m_Instance);
            m_LightsaberManager[i].m_Instance.transform.localRotation = Quaternion.Euler(0, 0, 0);
            m_LightsaberManager[i].m_Instance.transform.localPosition = new Vector3(0, 0, 0);
            m_LightsaberManager[i].Setup();
        }
    }


}
