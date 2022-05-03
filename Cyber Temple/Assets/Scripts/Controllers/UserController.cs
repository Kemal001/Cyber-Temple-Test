using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class UserController : Singleton<UserController>
{
    private double healTime = 5.0;

    private UserDataModel currentUserData;

    private void Start()
    {
        LoadUserData();
    }

    private void LoadUserData()
    {
        currentUserData = new UserDataModel
        {
            livesLeft = 0,
            lastHealedTime = DateTime.Now
        };
    }

    public UserDataModel GetUserData()
    {
        return currentUserData;
    }

    public void AddUserLives(int amount)
    {
        currentUserData.livesLeft += amount;
        currentUserData.lastHealedTime = DateTime.Now;
    }

    public float GetTimeUntilHeal()
    {
        double difference = healTime - (DateTime.Now - currentUserData.lastHealedTime).TotalSeconds;
        return Mathf.Clamp((float)difference, 0, (float)healTime);
    }

    public bool CanHeal()
    {
        double difference = (DateTime.Now - currentUserData.lastHealedTime).TotalSeconds;
        return difference > healTime;
    }
}

