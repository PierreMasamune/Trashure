using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    private int Cash;
    public TMP_Text cashText;
    public int StartingCash = 1000;
    public static PlayerStats Instance;
    private void Awake()
    {
        // Singleton check
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Cash = StartingCash;
        UpdateScore();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    private void UpdateScore()
    {
        cashText.text = "Cash: " + Cash.ToString();
    }


    public void AddCash(int amount)
    {
        Cash += amount;
        UpdateScore();
    }
    public void RemoveCash(int amount) {
        Cash -= amount;
        UpdateScore();
    }   
    public int GetCash()
    {
        return Cash;
    }
}
