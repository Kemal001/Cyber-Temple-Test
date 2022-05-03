using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameMenuView : MonoBehaviour
{
    public Button backButton;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI livesText;
    public Button heal;
    public int healAmount = 10;

    private void Awake()
    {
        backButton.onClick.AddListener(BackToMainMenu);
        heal.onClick.AddListener(Heal);
    }

    private void Start()
    {
        StartCoroutine(UpdateTime());
    }

    private IEnumerator UpdateTime()
    {
        while (true)
        {
            heal.gameObject.SetActive(UserController.Instance.CanHeal());
            UpdateUserInfoUI();

            yield return new WaitForSeconds(0.01f);
        }
    }

    private void Heal()
    {
        if (!UserController.Instance.CanHeal())
        {
            return;
        }

        UserController.Instance.AddUserLives(healAmount);
        
        UpdateUserInfoUI();
    }

    private void UpdateUserInfoUI()
    {
        timerText.text = $"{UserController.Instance.GetTimeUntilHeal():0.00} s";
        livesText.text = $"Lives: {UserController.Instance.GetUserData().livesLeft}";
    }

    private void BackToMainMenu()
    {
        SceneController.Instance.LoadMainMenu();
    }
}
