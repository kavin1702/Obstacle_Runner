using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [SerializeField] private Slider energySlider;
    [SerializeField] private TMP_Text energyText;
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        energySlider.value = 100;
    }
    public void UpdateEnergySlider(float current, float max)
    {
        energySlider.maxValue = max;
        energySlider.value = Mathf.RoundToInt(current);
        energyText.text = energySlider.value + "/" + energySlider.maxValue;
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainLevel");
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
}