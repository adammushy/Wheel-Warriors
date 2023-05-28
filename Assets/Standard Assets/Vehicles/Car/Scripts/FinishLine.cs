using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject Leaderboard;
    public string PlayerName;
    public static int PlayerFinishPosition;
    public static string PName;

    void Start()
    {
        PlayerName = UniversalSave.PlayerName;
        PName = PlayerName;

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.FinishPositionID++;
            PlayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
            Leaderboard.SetActive(true);
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
