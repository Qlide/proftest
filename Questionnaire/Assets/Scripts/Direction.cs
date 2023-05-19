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
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Программист, который разрабатывает программные приложения для всевозможных мобильных устройств";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Объединяет целую группу профессий, связанных с обслуживанием компьютерного оборудования, написанием программного обеспечения (ПО), созданием интернет-сайтов, автоматизированной обработкой и защитой информации";
                            break;
                        case "Медиакоммуникации":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Cпециалист, который раскручивает бренды, занимается творческими мероприятиями, участвует в продвижении фильмов, телевизионных проектов и пр.";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Визуализируют и оживляют любые трехмерные или двумерные объекты в цифровом пространстве";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Превращает отдельные кадры в цельное произведение. Он не просто склеивает удачные сцены в ленту, а рассказывает историю с помощью средств монтажа";
                            break;
                        case "Реклама и связи с общественностью":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Специалист, который отвечает за внешние коммуникации компании, бренда или продукта: общается со СМИ, следит за тем, что говорят и пишут клиенты";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Специалист, который продвигает товары или услуги, развивает бренд, отвечает за ведение и наполнение аккаунтов в социальных сетях";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Специалист, который определяет процент присутствия компании в информационном пространстве и даёт оценку её медиарепутации";
                            break;
                        case "Музыкальное искусство эстрады":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Могут специализироваться на одном из видов певческого искусства, работать в опере, в театре, быть занятыми в различных музыкальных проектах, участвовать в музыкальных коллективах, а также выступать в клубах, на вечеринках, в ресторанах";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Одна из самых распространенных и востребованных профессий в музыкальной сфере. Обучение вокальной технике, постановка голоса, подготовка к выступлениям и конкурсам – эти задачи могут возникнуть как перед академическим музыкантом, так и перед любителем";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Ворческая профессия, связанная с созданием звуковых художественных образов, формированием драматургии звука, концепции звука, созданием новых звуков, их фиксацией и обработкой";
                            break;
                        case "Народная художественная культура":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Их основная задача — понимать и оценивать произведения искусства, находить в них символы, знаки и аллегории";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Автор и постановщик балетов, танцев, хореографических номеров, танцевальных сцен в опере и оперетте, создатель танцевальных форм";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Искусство сочинения и сценической постановки танца, первоначальное значение — искусство записи танца балетмейстером";
                            break;
                        case "Социально-культурная деятельность":
                            ProfText1.text = category.Value[0];
                            DescText1.text = "Специалист актерского мастерства; актёр, изображающий каких-либо персонажей на различных мероприятиях";
                            ProfText2.text = category.Value[1];
                            DescText2.text = "Планирует и проводит досуговые мероприятия для детей с учетом их возраста, интересов, уровня развития, а в некоторых ситуациях и возможностей здоровья. Речь идет о походах, праздниках, экскурсиях, конкурсах, выступлениях детских коллективов, фестивалях и пр.";
                            ProfText3.text = category.Value[2];
                            DescText3.text = "Может сочинять оригинальный сюжет или же адаптировать существующий для съёмки фильма. Адаптированный сценарий для кино или телевидения преимущественно состоит из перевода или интерпретации литературных произведений";
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
