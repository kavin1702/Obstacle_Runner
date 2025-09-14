using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject UIpannel;
    [SerializeField] GameObject Player;
    private Mover moverComp;

    void Start()
    {
        moverComp = Player.GetComponent<Mover>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIpannel.SetActive(true);
            moverComp.enabled = false;
        }
    }
    
}
