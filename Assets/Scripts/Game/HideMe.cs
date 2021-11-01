using UnityEngine;

public class HideMe : MonoBehaviour
{
    [SerializeField]
    float h_Delay;
    private void OnEnable()
    {
        Invoke("Hide", h_Delay);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
