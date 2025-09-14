using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int hitCount = 0;
    public int maxCount = 5;
    public static GameManager Instance;
    public Transform player;
    public GameObject restartPannel;
    private Mover moverComp;
    [SerializeField] GameObject Player;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        hitCount = maxCount;
        moverComp = Player.GetComponent<Mover>();
    }
    void Update()
    {
        if (hitCount <= 0 || player.position.y <3)
        {
            // Invoke("GameOver", 0.5f);
            restartPannel.SetActive(true);
            moverComp.enabled = false;
        }
    }
    public void HitCounter()
    {
        hitCount--;
        UIController.Instance.UpdateEnergySlider(hitCount, maxCount);
    }
    public void GameOver()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
