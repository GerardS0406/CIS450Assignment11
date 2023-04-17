/*
 * Gerard Lamoureux
 * InstructionsPanel
 * Assignment 11
 * Handles the Instructions Panel
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsPanel : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}
