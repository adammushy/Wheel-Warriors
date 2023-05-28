using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts = 1;
    public static int OpponentsCount;
    public static int CashAmount;
    public static bool Saving = false;
    public static string PlayerName = "PLAYER";
    public static int RacesWon = 0;
    public static int RacesLost = 0;
    void Start()
    {
        DontDestroyOnLoad(this);
        LoadStats();
    }

    public void Update()
    {
        if(Saving == true)
        {
            Saving = false;
            SaveStats();
        }
    }
    public void SaveStats()
    {
        PlayerPrefs.SetInt("MyCash", CashAmount);
        PlayerPrefs.SetString("PlayName", PlayerName);
        PlayerPrefs.SetInt("WonRaces", RacesWon);
        PlayerPrefs.SetInt("LostRaces", RacesLost);

    }
    public void LoadStats()
    {
        CashAmount = PlayerPrefs.GetInt("MyCash");
        PlayerName = PlayerPrefs.GetString("PlayName");
        RacesWon = PlayerPrefs.GetInt("WonRaces");
        RacesLost = PlayerPrefs.GetInt("LostRaces");
    }

    // Update is called once per frame
   
}
