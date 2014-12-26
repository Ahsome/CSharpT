using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
    {
    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

    public GUISkin skin;

    public Rect timerRect;

    public Color warningColorTimer;
    public Color defaultColorTimer;

    public float startTime;
    private string currentTime;

    void Update()
        {
        startTime -= Time.deltaTime;
        currentTime = string.Format("{0:0.0}", startTime);
        if (startTime <= 0)
            {
            startTime = 0;
            Application.LoadLevel(0);
            }
        }

    void Start()
        {
        DontDestroyOnLoad(gameObject);

        }
    public static void CompleteLevel()
        {
        if (currentLevel < 2)
            {
            currentLevel += 1;
            Application.LoadLevel(currentLevel);
            }
        else
            print("You Win");
        }
    void OnGUI()
        {
        GUI.skin = skin;
        if (startTime < 5f)
            skin.GetStyle("Timer").normal.textColor = warningColorTimer;
        else
            skin.GetStyle("Timer").normal.textColor = defaultColorTimer;
        GUI.Label(timerRect, currentTime, skin.GetStyle("Timer"));
        }
    }
