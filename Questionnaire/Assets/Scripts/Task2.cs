using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Task2 : MonoBehaviour
{
    public QuestionList[] questions;
    public Text[] answersText;
    public Text qText;
    public Text CountText;

    List<object> qList;
    List<object> qList2;
    int randQ;

    Dictionary<string, List<string>> a = new Dictionary<string, List<string>>()
        {
            {"���������� �����������",
                new List<string> {
                    "� ������ ������ (�����������, ����������, ������)",
                    "����� ���� ���������� ������ � ������ ����",
                    "������ � ������������ ����",
                    "���� ������������� �� ����������� ����� �����������",
                    "����� ����� ���������, ��� ����� ������ ������, �����������",
                    "������ ���� ������ ���������� �� ������ �����"
                }
            },

            {"�����������������",
                new List<string> {
                    "� ������������ ������ (��������������, ����������, �������)",
                    "����� �������������� ������� ���� ������ � ���������� ��� ������",
                    "�������� ����� � ���������� ����� (������ �����, ���������� ����� ��� Tiktok, ������� ������)",
                    "������������ ����� ������������ � �������� ������������� ����",
                    "� ������� �������� � �������",
                    "�������� � �������, � �������������� � ������� ������"
                }
            },

            {"������� � ����� � ���������������",
                new List<string> {
                    "� ������������ ������ (��������������, ����������, �������)",
                    "����� �������������� ������� ���� ������ � ���������� ��� ������",
                    "�������� ����� � ���������� ����� (������ �����, ���������� ����� ��� Tiktok, ������� ������)",
                    "������������ ����� ������������ � �������� ������������� ����",
                    "� ������� �������� � �������",
                    "�������� � �������, � �������������� � ������� ������"
                }
            },

            {"����������� ��������� �������",
                new List<string> {
                    "� ���������� (������, ������, ������)",
                    "� ���������� ������, �  ������������� � ������������",
                    "������� � ����� ��� �� �������",
                    "����������� �������� � ����������� � ���������",
                    "�� ����",
                    "��������� ������, �������������� �� ������"
                }
            },

            {"�������� �������������� ��������",
                new List<string>{
                    "� ���������� (������, ������, ������)",
                    "� ���������� ������, �  ������������� � ������������",
                    "������� � ����� ��� �� �������",
                    "����������� �������� � ����������� � ���������",
                    "�� ����",
                    "��������� ������, �������������� �� ������"
                }
            },

            {"���������-���������� ������������",
                new List<string>{
                    "� ���������� (������, ������, ������)",
                    "� ���������� ������, �  ������������� � ������������",
                    "������� � ����� ��� �� �������",
                    "����������� �������� � ����������� � ���������",
                    "�� ����",
                    "��������� ������, �������������� �� ������"
                }
            }
        };

    void Start()
    {
        CountText.text = $"{Task.count}/30";
        qList = new List<object>(questions);
        qList2 = qList;
        questionGenerate();
    }

    void questionGenerate()
    {
        CountText.text = $"{Task.count}/30";
        randQ = Random.Range(0, qList.Count - 1);
        QuestionList crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;
        for (int i = 0; i < crntQ.answers.Length; i++)
        {
            answersText[i].text = crntQ.answers[i];
            if (answersText[crntQ.answers.Length - 1].text.ToString() == "")
            {
                SceneManager.LoadScene(6);
                //print($"���������� �����������: {Task.n1} ������");
                //print($"�����������������: {Task.n2} ������");
                //print($"������� � ����� � ���������������: {Task.n3} ������");
                //print($"����������� ��������� �������: {Task.n4} ������");
                //print($"�������� �������������� ��������: {Task.n5} ������");
                //print($"���������-���������� ������������: {Task.n6} ������");
            }
        }
    }

    public void Check(int index)
    {
        foreach (var category in a)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (answersText[index].text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "���������� �����������":
                            Task.n1++;
                            break;
                        case "�����������������":
                            Task.n2++;
                            break;
                        case "������� � ����� � ���������������":
                            Task.n3++;
                            break;
                        case "����������� ��������� �������":
                            Task.n4++;
                            break;
                        case "�������� �������������� ��������":
                            Task.n5++;
                            break;
                        case "���������-���������� ������������":
                            Task.n6++;
                            break;
                    }
                }
            }
        }
    }

    public void AnswerBttns(int index)
    {
        if (Task.count == 30)
        {
            Task.count = 30;
        }
        else {
            Task.count++;
        }
        Check(index);
        qList.RemoveAt(randQ);
        questionGenerate();
    }
}
[System.Serializable]
public class QuestionList2
{
    public string question;
    public string[] answers = new string[3];
}

