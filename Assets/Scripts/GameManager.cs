using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    int indexLevel = 0;
    private int health = 15;

    [SerializeField]
    TextMeshProUGUI textMesh;

    public override void Awake()
    {
        base.Awake ();
        DontDestroyOnLoad(this);
        textMesh.text = health.ToString();
    }

    void Start()
    {
        LoadNextLevel();
    }


    public void AddHealth(int newHealth)
    {
        health += newHealth;
        textMesh.text = health.ToString();
    }

    void LoadNextLevel()
    {
        indexLevel++;
        SceneManager.LoadScene(indexLevel);
    }
}
