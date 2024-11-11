using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance; // Singleton-Instanz
    public string playerName; // Variable zum Speichern des Spielernamens


    private void Awake()
    {


        // Pr�fen, ob eine Instanz bereits existiert
        if (Instance != null)
        {
            Destroy(gameObject); // Zerst�re das aktuelle GameObject, falls eine Instanz existiert
            return;
        }

        // Singleton-Setup
        Instance = this;
        DontDestroyOnLoad(gameObject); // Verhindert, dass das Objekt beim Szenenwechsel zerst�rt wird


    }

}
