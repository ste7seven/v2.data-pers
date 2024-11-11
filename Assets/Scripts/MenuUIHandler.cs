using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{

    public TMP_InputField nameInputField; // Verknüpfe dein InputField im Inspector

    public TextMeshProUGUI highScoreText; // Referenz auf den TextMeshPro-Text für den Highscore


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Diese Methode wird aufgerufen, wenn der Start-Button gedrückt wird
    public void OnStartButtonClicked()
    {
        // Hol dir den eingegebenen Spielernamen und speichere ihn im DataManager
        string playerName = nameInputField.text;
        DataManager.Instance.playerName = playerName;

        // Lade die nächste Szene (z.B. "MainScene")
        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
        //MainManager.Instance.SaveColor();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }


 

}
