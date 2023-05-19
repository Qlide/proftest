using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Direction2 : MonoBehaviour
{
    public DirectionList2[] directions;
    public Text dirText;
    public Text ProfText2;
    public Text DescText2;

    List<object> dirList;
    List<int> res;
    List<int> resMax;
    static int max = 0;
    static int index;

    Dictionary<string, List<string>> profs = new Dictionary<string, List<string>>()
        {
            {"���������� �����������",
                new List<string> {
                    "Web-��������",
                    "����������� ��������� ����������",
                    "IT-����������"
                }
            },

            {"�����������������",
                new List<string> {
                    "��������",
                    "2/3D-��������",
                    "������� �������",
                }
            },

            {"������� � ����� � ���������������",
                new List<string> {
                    "PR-��������",
                    "SMM-��������",
                    "����� ��������"
                }
            },

            {"����������� ��������� �������",
                new List<string> {
                    "��������",
                    "������������� ������",
                    "������������"
                }
            },

            {"�������� �������������� ��������",
                new List<string>{
                    "������������",
                    "������������",
                    "���������"
                }
            },

            {"���������-���������� ������������",
                new List<string>{
                    "��������",
                    "�������-�����������",
                    "���������",
                }
            }
        };

    void Start()
    {
        foreach (var category in profs)
        {
            for (int i = 0; i < profs.Count; i++)
            {
                if (dirText.text.ToString() == category.Key.ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "���������� �����������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "�����������, ������� ������������� ����������� ���������� ��� ������������ ��������� ���������";
                            break;
                        case "�����������������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "������������� � �������� ����� ���������� ��� ��������� ������� � �������� ������������";
                            break;
                        case "������� � ����� � ���������������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "����������, ������� ���������� ������ ��� ������, ��������� �����, �������� �� ������� � ���������� ��������� � ���������� �����";
                            break;
                        case "����������� ��������� �������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "���� �� ����� ���������������� � �������������� ��������� � ����������� �����. �������� ��������� �������, ���������� ������, ���������� � ������������ � ��������� � ��� ������ ����� ���������� ��� ����� ������������� ����������, ��� � ����� ���������";
                            break;
                        case "�������� �������������� ��������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "����� � ����������� �������, ������, ���������������� �������, ������������ ���� � ����� � ��������, ��������� ������������ ����";
                            break;
                        case "���������-���������� ������������":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "��������� � �������� ��������� ����������� ��� ����� � ������ �� ��������, ���������, ������ ��������, � � ��������� ��������� � ������������ ��������. ���� ���� � �������, ����������, ����������, ���������, ������������ ������� �����������, ���������� � ��.";
                            break;
                    }
                }
            }
        }
    }

    void Awake()
    {
        List<int> res = new List<int>() { Task.n1, Task.n2, Task.n3, Task.n4, Task.n5, Task.n6 };
        List<int> resMax = new List<int>() { Task.n1, Task.n2, Task.n3, Task.n4, Task.n5, Task.n6 };
        index = 0;
        resMax.Sort();
        max = resMax[resMax.Count - 1];
        dirList = new List<object>(directions);
        for (int i = 0; i < res.Count; i++)
        {
            if (res[i] == max)
            {
                index = i;
                break;
            }
        }

        DirectionList2 crntD = dirList[index] as DirectionList2;
        dirText.text = crntD.direction;
    }
}

[System.Serializable]
public class DirectionList2
{
    public string direction;
}