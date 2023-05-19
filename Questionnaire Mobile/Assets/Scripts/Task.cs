using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Task : MonoBehaviour
{
    public QuestionList[] questions;
    public Text[] answersText;
    public Text qText;
    public Text CountText;
    public static int count;
    public static int n1;
    public static int n2;
    public static int n3;
    public static int n4;
    public static int n5;
    public static int n6;

    List<object> qList;
    List<object> qList2;
    int randQ;

    Dictionary<string, List<string>> q = new Dictionary<string, List<string>>()
        {
            {"���������� �����������",
                new List<string> {
                "�� ������������ � �������, ������ ����� ��������� ����� ��������� � ���������� ��� ����� �� � ���� �����������?",
                "�������� ����� ���������� �� �������, ���� ��������� ������ ��� ��� ��������?",
                "���� ������ �������� ������ ������, ��� ����� ����� ������, \"������\" ������ ��� ��������?",
                "���� ��������� ���������, ������� ���� ����������� ����������� ����������� ������������ ���� � ���������� �� ����?"
                }
            },

            {"�����������������",
                new List<string> {
                    "���� ����������� ������� � ���������� ����� � ���� �� ���� �������� ������ �� ������� ��������� � ���������� �����?",
                    "���� �������� �� �������� ��������� ������������� ������� (����, �����, �����, �������� � ��)?",
                    "�� ��������, ��� ��� �������� ������� ����� ����� ������� �������� � ������ �� ������ ��������?",
                    "����� ��� ���� ���� �� ������� ������� ��� ���������� �����?"
                }
            },

            {"������� � ����� � ���������������",
                new List<string> {
                    "� ������� ���� �� �������� ������� ��������� ���������, ������������� ��������� ������� � ������������ �� ����?",
                    "���� ���� �� ��������� ���������� ������ �����, ������ �� ����������� � ��������� � ���������� �����?",
                    "���� �������� ��������� � ������ ������� � ����� ����� ���������?",
                    "����� �������� ������ � ������� ���������� ����� ���������� � ��������� ���� ����� ��� ������?"
                }
            },

            {"����������� ��������� �������",
                new List<string> {
                    "���� ��������� �������������� ����������� �������� � �������� �� �������� ����������� ����������� ��� �����?",
                    "�� ��������������� ����������� ������� (������� �� ����������� �����������, ����������� ������� ��� �������� ����������� �����)?",
                    "� ������� ���� �� �������� ���������� ������������ ���������, ������ ����������� � ������������ �� ����?",
                    "���� ������ �������� ��������� ������, �������������� �� ������?"
                }
            },

            {"�������� �������������� ��������",
                new List<string>{
                    "�� � ������� ��������� ����������� (�������, �����������, ����������)?",
                    "���� �������� ��������� �� ����� ����� ���������?",
                    "���� ������ ����� ��������� ���������, ������� ���� ����������� ����� ������������� � �����-���� ���������� �����?",
                    "�� ������ ������������ ������ ����� � ������� ��� �������� ����������� �������, ��� ����� �� ����� ���������?"
                }
            },

            {"���������-���������� ������������",
                new List<string>{
                    "����� �� ����������� ������ �� � ������� ������������� �������� �������������� �������?",
                    "���� ����� ������� ������� ���������� �����������, ���������� �������������� ����?",
                    "������ ����� ��� ���� � ����� ����� ���������� ������, ��������� � ����������� � ������?",
                    "�� �������� ������� ������������ �������� � �������� ������ ����������/����������?"
                }
            }
        };

    //public void OnClickPlay()
    //{
    //    qList = new List<object>(questions);
    //    questionGenerate();
    //}

    void Awake()
    {
        count = 1;
        n1 = 0;
        n2 = 0;
        n3 = 0;
        n4 = 0;
        n5 = 0;
        n6 = 0;
    }

    void Start()
    {
        qList = new List<object>(questions);
        qList2 = qList;
        questionGenerate();
        //print(q["���������� �����������"][2]);
        //print(q["�����������������"][2]);
        //print(q["������� � ����� � ���������������"][2]);
        //print(q["����������� ��������� �������"][2]);
        //print(q["�������� �������������� ��������"][2]);
        //print(q["���������-���������� ������������"][2]);
        //print(q.Keys[1]);
    }

    public void NextScene(int scene_Number)
    {
        SceneManager.LoadScene(scene_Number);
    }

    public void questionGenerate()
    {
        CountText.text = $"{count}/30";
        randQ = Random.Range(0, qList.Count - 1);
        QuestionList crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;
        //Debug.Log(crntQ.question);
        for (int i = 0; i < crntQ.answers.Length; i++)
        {
            answersText[i].text = crntQ.answers[i];
            //Debug.Log(crntQ.answers[i]);
            if (answersText[crntQ.answers.Length - 1].text.ToString() == "")
            {
                SceneManager.LoadScene(3);
                //print($"���������� �����������: {n1} ������");
                //print($"�����������������: {n2} ������");
                //print($"������� � ����� � ���������������: {n3} ������");
                //print($"����������� ��������� �������: {n4} ������");
                //print($"�������� �������������� ��������: {n5} ������");
                //print($"���������-���������� ������������: {n6} ������");
            }
        }
    }

    public void CheckPlus()
    {
        foreach (var category in q)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (qText.text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "���������� �����������":
                            n1++;
                            break;
                        case "�����������������":
                            n2++;
                            break;
                        case "������� � ����� � ���������������":
                            n3++;
                            break;
                        case "����������� ��������� �������":
                            n4++;
                            break;
                        case "�������� �������������� ��������":
                            n5++;
                            break;
                        case "���������-���������� ������������":
                            n6++;
                            break;
                    }
                }
            }
        }
    }

    public void CheckMinus()
    {
        foreach (var category in q)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (qText.text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "���������� �����������":
                            n1--;
                            break;
                        case "�����������������":
                            n2--;
                            break;
                        case "������� � ����� � ���������������":
                            n3--;
                            break;
                        case "����������� ��������� �������":
                            n4--;
                            break;
                        case "�������� �������������� ��������":
                            n5--;
                            break;
                        case "���������-���������� ������������":
                            n6--;
                            break;
                    }
                }
            }
        }
    }

    public void AnswerBttns(int index)
    {
        count++;
        if (answersText[index].text == "��")
        {
            CheckPlus();
        }
        else
        {
            CheckMinus();
        }
        qList.RemoveAt(randQ);
        questionGenerate();
    }
}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[2];
}

