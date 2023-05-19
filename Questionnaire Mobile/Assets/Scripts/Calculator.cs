using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calculator : MonoBehaviour
{
    public Text examText1;
    public Text examText2;
    public Text examText3;
    public Text examText4;
    public Text examText5;
    public Text examText6;
    public Text examText7;
    public Text examText8;
    public Text examText9;
    public Text examText10;
    public InputField examScore1;
    public InputField examScore2;
    public InputField examScore3;
    public InputField examScore4;
    public InputField examScore5;
    public InputField examScore6;
    public InputField examScore7;
    public InputField examScore8;
    public InputField examScore9;
    public InputField examScore10;
    public static int Score;
    public static int CountScore;
    public static int TotalScore;
    public static int sum1;
    public static int sum2;
    public static int sum3;
    public static int sum4;
    public static int sum5;
    public static int sum6;

    List<string> allExamName;
    List<string> allExamScore;
    List<int> allActiveExamScore;
    Dictionary<string, int> resultExam;
    Dictionary<string, List<string>> resEdu = new Dictionary<string, List<string>>()
    {
        {"Прикладная информатика",
            new List<string> {
                "Русский язык",
                "Математика",
                "Информатика",
                "Физика",
                "Химия"
            }
         },

        {"Медиакоммуникации",
            new List<string> {
                "Русский язык",
                "Обществознание",
                "Творческий конкурс",
                "Литература",
                "История"
            }
        },

        {"Реклама и связи с общественностью",
            new List<string> {
                "Русский язык",
                "Обществознание",
                "Творческий конкурс",
                "Литература",
                "История"
            }
        },

        {"Музыкальное искусство эстрады",
            new List<string> {
                "Русский язык",
                "Музыкальное искусство эстрады",
                "Обществознание",
                "Иностранный язык",
                "Литература",
                "История"
            }
        },

        {"Народная художественная культура",
            new List<string>{
                "Русский язык",
                "Обществознание",
                "Художественное творчество",
                "Литература",
                "История",
                "Иностранный язык"
            }
        },

        {"Социально-культурная деятельность",
            new List<string>{
                "Русский язык",
                "Обществознание",
                "Литература",
                "История",
                "Иностранный язык"
            }
        }
    };

    void Awake()
    {
        Task.n1 = 0;
        Task.n2 = 0;
        Task.n3 = 0;
        Task.n4 = 0;
        Task.n5 = 0;
        Task.n6 = 0;

        sum1 = 0;
        sum2 = 0;
        sum3 = 0;
        sum4 = 0;
        sum5 = 0;
        sum6 = 0;

        Score = 0;
        CountScore = 0;
        TotalScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        allExamName = new List<string> { examText1.text, examText2.text, examText3.text, examText4.text, examText5.text, examText6.text, examText7.text, examText8.text, examText9.text, examText10.text };
    }

    public void Calculation()
    {
        resultExam = new Dictionary<string, int>() { };
        allExamScore = new List<string>() { examScore1.text, examScore2.text, examScore3.text, examScore4.text, examScore5.text, examScore6.text, examScore7.text, examScore8.text, examScore9.text, examScore10.text };
        for (int i = 0; i < allExamScore.Count; i++)
        {
            if (allExamScore[i] != "")
            {
                resultExam.Add(allExamName[i], int.Parse(allExamScore[i]));
                Score += int.Parse(allExamScore[i]);
            }
        }

        foreach (var category1 in resultExam)
        {
            foreach (var category2 in resEdu)
            {
                for (int i = 0; i < category2.Value.Count; i++)
                {
                    if (category1.Key.ToString() == category2.Value[i].ToString())
                    {
                        if (category1.Value >= 30 && category1.Value <= 100)
                        {
                            switch (category2.Key.ToString())
                            {
                                case "Прикладная информатика":
                                    Calculator.sum1 += category1.Value;
                                    Task.n1++;
                                    break;
                                case "Медиакоммуникации":
                                    Calculator.sum2 += category1.Value;
                                    Task.n2++;
                                    break;
                                case "Реклама и связи с общественностью":
                                    Calculator.sum3 += category1.Value;
                                    Task.n3++;
                                    break;
                                case "Музыкальное искусство эстрады":
                                    Calculator.sum4 += category1.Value;
                                    Task.n4++;
                                    break;
                                case "Народная художественная культура":
                                    Calculator.sum5 += category1.Value;
                                    Task.n5++;
                                    break;
                                case "Социально-культурная деятельность":
                                    Calculator.sum6 += category1.Value;
                                    Task.n6++;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        if (Calculator.sum1 >= 210)
        {
            Task.n1++;
        }

        if (Calculator.sum2 >= 280)
        {
            Task.n2++;
        }

        if (Calculator.sum3 >= 280)
        {
            Task.n3++;
        }

        if (Calculator.sum4 >= 280)
        {
            Task.n4++;
        }

        if (Calculator.sum5 >= 280)
        {
            Task.n5++;
        }

        if (Calculator.sum6 >= 280)
        {
            Task.n6++;
        }
    }

    public void ChekBttns()
    {
        if (Score > 200)
        {
            SceneManager.LoadScene(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Score = 0;
        CountScore = 0;
    }
}