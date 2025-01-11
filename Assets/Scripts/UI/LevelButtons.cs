using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtons : MonoBehaviour
{
  

    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ForestButton()
    {
        SceneManager.LoadScene("forest");
    }
    public void VillageButton()
    {
        SceneManager.LoadScene("village");
    }
    public void DungeanButton()
    {
        SceneManager.LoadScene("dungeon");
    }

   
}
