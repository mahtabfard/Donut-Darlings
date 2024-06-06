using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomText : MonoBehaviour
{
    public TextMeshPro randomText;
        public string[] words = { "Blue", "Green", "Red" , "Pink" };

    // Start is called before the first frame update
    void Start()
    {
         string randomWord = words[Random.Range(0, words.Length)];
                          randomText.text = randomWord;

    }

    
}
