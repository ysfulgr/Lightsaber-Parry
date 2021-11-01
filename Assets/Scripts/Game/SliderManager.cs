using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    [SerializeField]
    private Slider s_Slider;
    [SerializeField]
    private Slider s_SliderOther;
    [SerializeField]
    private Button s_ButtonSimulate;
    public void Start()
    {
        s_ButtonSimulate.onClick.AddListener(Simulate);
        s_Slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        s_SliderOther.onValueChanged.AddListener(delegate { ValueChangeCheckOther(); });
    }
    public void ValueChangeCheck()
    {
        EventManager.CallEvent<float>(EventNames.LightsaberAngle, s_Slider.value);

    }
    public void ValueChangeCheckOther()
    {
        EventManager.CallEvent<float>(EventNames.LightsaberAngleOther, s_SliderOther.value);

    }
    void Simulate()
    {
        EventManager.CallEvent<bool>(EventNames.EventSimulate, true);
        EventManager.CallEvent<bool>(EventNames.EventSimulateOther, true);
    }
}
