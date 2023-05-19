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
            {"Прикладная информатика",
                new List<string> {
                    "Web-дизайнер",
                    "Разработчик мобильных приложений",
                    "IT-специалист"
                }
            },

            {"Медиакоммуникации",
                new List<string> {
                    "Продюсер",
                    "2/3D-моделист",
                    "Режиссёр монтажа",
                }
            },

            {"Реклама и связи с общественностью",
                new List<string> {
                    "PR-менеджер",
                    "SMM-менеджер",
                    "Медиа аналитик"
                }
            },

            {"Музыкальное искусство эстрады",
                new List<string> {
                    "Вокалист",
                    "Проподаватель вокала",
                    "Звукорежиссёр"
                }
            },

            {"Народная художественная культура",
                new List<string>{
                    "Искусствовед",
                    "Балетмейстер",
                    "Хореограф"
                }
            },

            {"Социально-культурная деятельность",
                new List<string>{
                    "Аниматор",
                    "Педагог-огранизатор",
                    "Сценарист",
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
                        case "Прикладная информатика":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Программист, который разрабатывает программные приложения для всевозможных мобильных устройств";
                            break;
                        case "Медиакоммуникации":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Визуализируют и оживляют любые трехмерные или двумерные объекты в цифровом пространстве";
                            break;
                        case "Реклама и связи с общественностью":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Специалист, который продвигает товары или услуги, развивает бренд, отвечает за ведение и наполнение аккаунтов в социальных сетях";
                            break;
                        case "Музыкальное искусство эстрады":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Одна из самых распространенных и востребованных профессий в музыкальной сфере. Обучение вокальной технике, постановка голоса, подготовка к выступлениям и конкурсам – эти задачи могут возникнуть как перед академическим музыкантом, так и перед любителем";
                            break;
                        case "Народная художественная культура":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Автор и постановщик балетов, танцев, хореографических номеров, танцевальных сцен в опере и оперетте, создатель танцевальных форм";
                            break;
                        case "Социально-культурная деятельность":
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Планирует и проводит досуговые мероприятия для детей с учетом их возраста, интересов, уровня развития, а в некоторых ситуациях и возможностей здоровья. Речь идет о походах, праздниках, экскурсиях, конкурсах, выступлениях детских коллективов, фестивалях и пр.";
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