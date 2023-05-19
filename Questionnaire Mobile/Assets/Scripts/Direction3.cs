using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Direction3 : MonoBehaviour
{
    public DirectionList3[] directions;
    public Text dirText;
    public Text ProfText3;
    public Text DescText3;

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
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Объединяет целую группу профессий, связанных с обслуживанием компьютерного оборудования, написанием программного обеспечения (ПО), созданием интернет-сайтов, автоматизированной обработкой и защитой информации";
                            break;
                        case "Медиакоммуникации":
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Превращает отдельные кадры в цельное произведение. Он не просто склеивает удачные сцены в ленту, а рассказывает историю с помощью средств монтажа";
                            break;
                        case "Реклама и связи с общественностью":
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Специалист, который определяет процент присутствия компании в информационном пространстве и даёт оценку её медиарепутации";
                            break;
                        case "Музыкальное искусство эстрады":
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Ворческая профессия, связанная с созданием звуковых художественных образов, формированием драматургии звука, концепции звука, созданием новых звуков, их фиксацией и обработкой";
                            break;
                        case "Народная художественная культура":
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Искусство сочинения и сценической постановки танца, первоначальное значение — искусство записи танца балетмейстером";
                            break;
                        case "Социально-культурная деятельность":
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Искусство сочинения и сценической постановки танца, первоначальное значение — искусство записи танца балетмейстером";
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

        DirectionList3 crntD = dirList[index] as DirectionList3;
        dirText.text = crntD.direction;
    }
}

[System.Serializable]
public class DirectionList3
{
    public string direction;
}
