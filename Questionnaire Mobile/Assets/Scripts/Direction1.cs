using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Direction1 : MonoBehaviour
{
    public DirectionList[] directions;
    public Text dirText;
    public Text ProfText1;
    public Text DescText1;

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
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Проектируют логическую структуру веб-страниц; продумывают наиболее удобные решения подачи информации";
                            break;
                        case "Медиакоммуникации":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Cпециалист, который раскручивает бренды, занимается творческими мероприятиями, участвует в продвижении фильмов, телевизионных проектов и пр.";
                            break;
                        case "Реклама и связи с общественностью":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Специалист, который отвечает за внешние коммуникации компании, бренда или продукта: общается со СМИ, следит за тем, что говорят и пишут клиенты";
                            break;
                        case "Музыкальное искусство эстрады":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Могут специализироваться на одном из видов певческого искусства, работать в опере, в театре, быть занятыми в различных музыкальных проектах, участвовать в музыкальных коллективах, а также выступать в клубах, на вечеринках, в ресторанах";
                            break;
                        case "Народная художественная культура":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Их основная задача — понимать и оценивать произведения искусства, находить в них символы, знаки и аллегории";
                            break;
                        case "Социально-культурная деятельность":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Специалист актерского мастерства; актёр, изображающий каких-либо персонажей на различных мероприятиях";
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
    }
}

[System.Serializable]
public class DirectionList
{
    public string direction;
}