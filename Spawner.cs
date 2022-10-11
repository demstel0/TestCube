using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
using System.Globalization;

public class Spawner : MonoBehaviour
{
    public static Vector3 target { get; private set; }
    private float needPosX;
    public static float speed { get; private set; }
    public GameObject cube;
    private float timerSpawn;
    private float cdSpawn;
    private bool go;
    [SerializeField] TMP_InputField speedField;
    [SerializeField] TMP_InputField timerField;
    [SerializeField] TMP_InputField posField;
    [SerializeField] Button btnApply;
    public void Apply()
    {
        speed = float.Parse(speedField.text);
        needPosX = float.Parse(posField.text);
        cdSpawn = float.Parse(timerField.text);
        speedField.text = string.Empty;
        posField.text = string.Empty;
        timerField.text = string.Empty;
        target = new Vector3(needPosX, 0, 0);
        go = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (speedField.text != string.Empty && posField.text != string.Empty && timerField.text != string.Empty) btnApply.interactable = true;
        else btnApply.interactable = false;
        if (timerSpawn>0)
        {
            timerSpawn -= Time.deltaTime;
        }
        else
        {
            if (go)
            {
                Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
                timerSpawn = cdSpawn;
            }
        }
    }
}
