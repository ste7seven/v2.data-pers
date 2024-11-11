using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameDisplay : MonoBehaviour
{
    public TMP_Text playerNameText; // Verknüpfe dein TextMeshPro-Textobjekt im Inspector

    private void Start()
    {
        // Hole den Spielernamen aus dem DataManager und setze ihn im Text
        playerNameText.text = "Best Score: " + DataManager.Instance.playerName;
    }
}
