using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    //public GameObject itembulletcnt;
    // Start is called before the first frame update
    void Start()
    {
        //menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Game_Exit()
    {
        Debug.Log("²¿½Ã´Ù ¸Àµ¿»ê~~");
        Application.Quit();
    }
    public void GO_Pick()
    {
        SceneManager.LoadScene("CharactorPickScene");
    }
    public void GO_MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Go_Menu()
    {
        menu.SetActive(true);
    }
    public void Go_Game()
    {
        menu.SetActive(false);
    }
    /*public void Go_ItemBulletcnt()
    {
        itembulletcnt.SetActive(true);
    }
    public void Go_BasicShell()
    {
        itembulletcnt.SetActive(false);
    }*/
}
