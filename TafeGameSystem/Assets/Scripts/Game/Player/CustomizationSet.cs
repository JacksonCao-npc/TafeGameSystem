using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomizationSet : Stats
{
    #region Variables
    #endregion
    public string characterName;
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();


    [Header("Index")]

    public int skinIndex;
    public int mouthIndex, eyesIndex, hairIndex, clothesIndex, armourIndex, helmIndex;

    [Header("Rederer")]

    public Renderer character;
    public Renderer helm;

    [Header("Max Index")]

    public int skinMax;
    public int mouthMax, eyesMax, hairMax, clothMax, armorMax, helmMax;

    public string[] materialNames = new string[7] { "Skin", "Mouth", "Eyes", "Hair", "Clothes", "Armour", "Helm" };
    public Vector2 screen;
    #region Start
    private void Start()
    {
        for(int i = 0; i<skinMax;i++)
        {
            Texture2D temp = Resources.Load("Character/Skin_" + i) as Texture2D;
            skin.Add(temp);
        }

        for (int i =0;i<mouthMax;i++)
        {
            Texture2D temp = Resources.Load("Character/Mouth_"+i) as Texture2D;
            mouth.Add(temp);
        }

        for(int i = 0; i< eyesMax; i ++)
        {
            Texture2D temp = Resources.Load("Character/Eyes_" + i) as Texture2D;
            eyes.Add(temp);
        }

        for (int i= 0; i < hairMax;i++)
        {
            Texture2D temp = Resources.Load("Character/Hair_" + i) as Texture2D;
            hair.Add(temp);
        }

        for (int i =0; i< clothMax;i++)
        {
            Texture2D temp = Resources.Load("Character/Clothes_" + i) as Texture2D;
            clothes.Add(temp);
        }

        for (int i = 0; i < armorMax; i ++)
        {
            Texture2D temp = Resources.Load("Character/Armour_" + i) as Texture2D;
            armour.Add(temp);
        }
     
        character = GameObject.Find("Mesh").GetComponent<Renderer>();
        helm = GameObject.Find("Cap").GetComponent<Renderer>();
    }
    #endregion
    #region SetTexture

    public void SetTexture(string type, int dir)
    {
        int index = 0, max = 0, matIndex = 0;
        Texture2D

        Texture2D curRedn = new Rederer();

        switch(type)
        {
            case "Skin"
                index = skinIndex;
                max = skinMax;
                Texture = skin.ToArray();
                matIndex = 1;
                curRend = skin;
                break;
                
        }
           
        if(index <0)
        {
            index = max = 1;
        }
        if(index>max-1)
        {
            index = 0;
        }

        Material[] mat = curRend.Materials;

        mat[matIndex].mainTexture = texture[index];
        curRend.materials = mat;

        switch(type)
        {

            case "Skin":
                skinIndex = index;
                break;
            case "Hair":
                hairIndex = index;
                break;
            case "Eyes":
                eyesIndex = index;
                break;
            case "Mouth":
                mouthIndex = index;
                break;
            case "Clothes":
                clothesIndex = index;
                break;
            case "Armour":
                armourIndex = index;
                break;
            case "Helm":
                helmIndex = index;
                break;
        }
    }
    #endregion;
}
