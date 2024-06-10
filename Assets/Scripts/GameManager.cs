using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using  UnityEngine.UI;
using System.Linq;
using UnityEngine.Color;

public class GameManager : MonoBehaviour
{
   public Color colorToPick;
     public Image[] img;
     int [] arraysOfNums={0,1,2,3,4,5,6,7};
     Dictionary<string, Color> colors;
     public int score;
     public TextMeshPro pickTxt;
     public TextMeshPro scoreTxt;
    public void Awake(){
                DontDestroyOnLoad(this.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
      colors = new Dictionary<string , Color>();
      colors.add("Blue",Color.blue);
       colors.add("Pink",Color.pink);
        colors.add("Green",Color.green);
         colors.add("Magenta",Color.Magenta);
          colors.add("Red",Color.red);
           colors.add("Orange",Color.orange);
            colors.add("Yellow",Color.yellow);
             colors.add("Purple",Color.purple);
      
      img=GetComponentsInChildren<Image>();
      setupColors();
      setupText();
    }

    // Update is called once per frame
    void Update()
    {
         
       
    }
    public void setupText(){
      int rand = Random.Range(0,colors.Count);
      pickTxt.text=colors.ElementAt(rand).Key;
      colorToPick=colors.ElementAt(rand).Value;
      scoreTxt.text="Score"+score;
          }
    public void setupColors(){
      img=GetComponentsInChildren<Image>();
         arraysOfNums=arraysOfNums.OrderBy(i=> Random.Range(0,img.Length)).ToArray();
             int newNum=0;
             foreach (Image image in img)
             {
               image.Color=setColor(arraysOfNums[newNum]);
               newNum++;
             }
    }
    public  Color setColor(int numInArray){
      switch(numInArray){
         case 0:
         return Color.blue;
         case 1:
         return Color.pink;
          case 2:
         return Color.green;
         case 3:
         return Color.magenta;
          case 4:
         return Color.red;
         case 5:
             return Color.orange;
          case 6:
             return Color.yellow;
         case 7:
            return Color.purple;
         default:
         return Color.clear;
      }
    }
      public void checkColor(Image image){
         if(image.color==colorToPick){
            setupColors();
            setupText();
            score++;
            scoreTxt.text="Score"+score;
         }
      }
    
      
}