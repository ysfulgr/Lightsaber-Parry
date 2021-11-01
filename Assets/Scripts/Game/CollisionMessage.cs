using TMPro;
using UnityEngine;

public class CollisionMessage : MonoBehaviour
{
    [SerializeField]
    private GameObject s_MessageTextPrefab;
    private GameObject s_Message { set; get; }
    [SerializeField]
    private GameObject s_MessageSpawnPoint;

    private void Start()
    {
        SpawnMessageTextPrefab();
        EventManager.AddEvent<string>(EventNames.EventCollisionMessage, ShowMessage);
    }
    void ShowMessage(string message)
    {
        s_Message.SetActive(true);
        s_Message.GetComponent<TextMeshProUGUI>().text = $"{message}";
    }
    void SpawnMessageTextPrefab()
    {
        GameObject textPrefab = Instantiate(s_MessageTextPrefab);
        textPrefab.transform.SetParent(s_MessageSpawnPoint.transform);
        textPrefab.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        textPrefab.gameObject.SetActive(false);
        s_Message = textPrefab;
    }
}
