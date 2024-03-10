using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scene_1, scene_2, scene_3, scene_4, 
        scene_5, scene_6, scene_7, scene_8, scene_9, 
        scene_10, scene_11, scene_12, scene_13, scene_14, scene_15, 
        scene_16, scene_17, scene_18, scene_19, scene_20, scene_21;
    public GameObject decisions_1, decisions_2, decisions_3, decisions_4, decisions_5;
    public GameObject ending_1, ending_2, ending_3, ending_4;

    public GameObject[] Scenes;
    public int ActiveScene;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        SceneChanger();
    }

    public void SceneChanger()
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == ActiveScene);
        }
    }

    // MAIN BUTTONS & FUNCTIONS

    public void startButton()
    {
        ActiveScene = 1;
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void restartButton()
    {
        ActiveScene = 0;
    }

    public void continueButton()
    {
        if (ActiveScene == 5 || ActiveScene == 12)
        {
            ActiveScene = 6; // ENDING 1
        }
        else if (ActiveScene == 13 || ActiveScene == 30)
        {
            ActiveScene = 14; // ENDING 2
        }
        else if (ActiveScene == 22)
        {
            ActiveScene = 23; // ENDING 3
        }
        else if (ActiveScene == 24 || ActiveScene == 29)
        {
            ActiveScene = 25; // ENDING 4
        }
        else if (ActiveScene == 17 || ActiveScene == 19)
        {
            ActiveScene = 20; // DECISIONS 5
        }
        else
        {
            ActiveScene++;
        }

        SceneChanger();
    }

    // SET A CHOICES
    public void convoRandomStudent()
    {
        ActiveScene = 2;
    }

    public void straightToClass()
    {
        ActiveScene = 7;
    }

    public void blendIn()
    {
        ActiveScene = 15;
    }

    // SET B CHOICES - from head to class
    public void exploreSchool()
    {
        ActiveScene = 8;
    }

    // SET C CHOICES - from explore school grounds
    public void engageConvoCourtyard()
    {
        ActiveScene = 11;
    }

    public void declineAndGainSolitude()
    {
        ActiveScene = 13;
    }

    // SET D CHOICES - from blending in
    public void engageConvoFriendly()
    {
        ActiveScene = 17;
    }

    public void excuseWalkAway()
    {
        ActiveScene = 18;
    }

    public void deafWalkAway()
    {
        ActiveScene = 26;
    }

    // SET E CHOICES - from the group of students 
    public void acceptInvite()
    {
        ActiveScene = 21;
    }
    public void ignoreInvite()
    {
        ActiveScene = 30;
    }

    public void excuseDecline()
    {
        ActiveScene = 24;
    }

}
