using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int turn = 1;
        string sentence = "";
        while (turn <= 7)
        {
            int randomIndex = Random.Range(0, words.Length);
            sentence += words[randomIndex] + " ";
            turn++;
        }
        Debug.Log(sentence);
    }
}
