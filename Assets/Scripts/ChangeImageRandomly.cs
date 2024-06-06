using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImageRandomly : MonoBehaviour
{
    public Sprite[] sprites;
   public  GameObject existingPrefab ;
public  static string chosenSprites;

    void Start()
    {
             InstantiatePrefab();
    }
     void InstantiatePrefab()
    {
          int randomIndex = Random.Range(0, sprites.Length);
           existingPrefab.GetComponent<SpriteRenderer>().sprite = sprites[randomIndex];
           chosenSprites = sprites[randomIndex].name;
    }
}
