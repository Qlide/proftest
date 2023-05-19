using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Direction : MonoBehaviour
{
    public DirectionList[] directions;
    public Text dirText;
    public Text desText;
    public Text ProfText1;
    public Text ProfText2;
    public Text ProfText3;
    public Text DescText1;
    public Text DescText2;
    public Text DescText3;

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
                            ProfText1.text = category.Value[0];
                            DescText1.text = "����������� ���������� ��������� ���-�������; ����������� �������� ������� ������� ������ ����������";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "�����������, ������� ������������� ����������� ���������� ��� ������������ ��������� ���������";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "���������� ����� ������ ���������, ��������� � ������������� ������������� ������������, ���������� ������������ ����������� (��), ��������� ��������-������, ������������������ ���������� � ������� ����������";
                            break;
                        case "�����������������":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "C���������, ������� ������������ ������, ���������� ����������� �������������, ��������� � ����������� �������, ������������� �������� � ��.";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "������������� � �������� ����� ���������� ��� ��������� ������� � �������� ������������";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "���������� ��������� ����� � ������� ������������. �� �� ������ ��������� ������� ����� � �����, � ������������ ������� � ������� ������� �������";
                            break;
                        case "������� � ����� � ���������������":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "����������, ������� �������� �� ������� ������������ ��������, ������ ��� ��������: �������� �� ���, ������ �� ���, ��� ������� � ����� �������";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "����������, ������� ���������� ������ ��� ������, ��������� �����, �������� �� ������� � ���������� ��������� � ���������� �����";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "����������, ������� ���������� ������� ����������� �������� � �������������� ������������ � ��� ������ � ��������������";
                            break;
                        case "����������� ��������� �������":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "����� ������������������ �� ����� �� ����� ���������� ���������, �������� � �����, � ������, ���� �������� � ��������� ����������� ��������, ����������� � ����������� �����������, � ����� ��������� � ������, �� ����������, � ����������";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "���� �� ����� ���������������� � �������������� ��������� � ����������� �����. �������� ��������� �������, ���������� ������, ���������� � ������������ � ��������� � ��� ������ ����� ���������� ��� ����� ������������� ����������, ��� � ����� ���������";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "��������� ���������, ��������� � ��������� �������� �������������� �������, ������������� ����������� �����, ��������� �����, ��������� ����� ������, �� ��������� � ����������";
                            break;
                        case "�������� �������������� ��������":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "�� �������� ������ � �������� � ��������� ������������ ���������, �������� � ��� �������, ����� � ���������";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "����� � ����������� �������, ������, ���������������� �������, ������������ ���� � ����� � ��������, ��������� ������������ ����";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "��������� ��������� � ����������� ���������� �����, �������������� �������� � ��������� ������ ����� ��������������";
                            break;
                        case "���������-���������� ������������":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "���������� ���������� ����������; ����, ������������ �����-���� ���������� �� ��������� ������������";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "��������� � �������� ��������� ����������� ��� ����� � ������ �� ��������, ���������, ������ ��������, � � ��������� ��������� � ������������ ��������. ���� ���� � �������, ����������, ����������, ���������, ������������ ������� �����������, ���������� � ��.";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "����� �������� ������������ ����� ��� �� ������������ ������������ ��� ������ ������. �������������� �������� ��� ���� ��� ����������� ��������������� ������� �� �������� ��� ������������� ������������ ������������";
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

        DirectionList crntD = dirList[index] as DirectionList;
        dirText.text = crntD.direction;
        desText.text = crntD.description;
    }
}

[System.Serializable]
public class DirectionList
{
    public string direction;
    public string description;
}
