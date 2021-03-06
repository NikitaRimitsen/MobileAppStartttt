using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppStart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoskop_Page : ContentPage
    {
        DatePicker data;
        Image pilti;
        Entry vvod;
        Label opisanie;
        //TableView table;
        Grid grid2x1;
        Frame pokazatel;
        string newGoro = "";
        public Horoskop_Page()
        {
            grid2x1 = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.DarkGray,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                }
            };

            data = new DatePicker { };
            data.DateSelected += Data_DateSelected;
            pilti = new Image { Source = "hororo.jpeg" };
            vvod = new Entry {
                Placeholder = "Напишите знак зодиака"
            };
            vvod.Completed += Vvod_Completed;
            opisanie = new Label
            {
                Text = "Гороскоп. Выберите дату или напишите названия знака зодиака",
                TextColor = Color.Black,
                FontSize = 16
            };
            pokazatel = new Frame()
            {
                BackgroundColor = Color.DarkGray,
                Content = new Image { Source = "hororo.jpeg" },
                WidthRequest = 50,
                HeightRequest = 250,
            };

            StackLayout vertical = new StackLayout
            {
                Children = { data, pokazatel },
            };

            StackLayout verticalvnix = new StackLayout
            {
                Children = { vvod, opisanie },
            };

            grid2x1.Children.Add(vertical, 0, 0);
            grid2x1.Children.Add(verticalvnix, 0, 1);
            Content = grid2x1;
        }

        private void Vvod_Completed(object sender, EventArgs e)
        {
            newGoro = vvod.Text;
            if (newGoro == "Козерог" || newGoro == "козерог")
            {
                opisanie.Text = "Козерог" + "\n 2022 год будет полон сюрпризов: произойдет то, чего вы никак не можете ожидать! Ветер перемен унесет вас далеко, так что вперед к новым приключениям! Вас могут заинтересовать такие сферы деятельности, как предприятие, журналистика или даже дизайн (вероятнее архитектуры). Можете смело двигаться вперед, ведь вас обязательно поддержат.";
                pokazatel.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (newGoro == "Водолей" || newGoro == "водолей")
            {
                opisanie.Text = "Водолей" + "\n В 2022 году у вас могут возникнуть финансовые трудности. Однако не спешите огорчаться: они временные и, если приложить достаточное количество усилий, из минуса вы сможете всего за пару месяцев выйти в жирный плюс. Но в случае, если вы не будете действовать и отправите всё на самотёк, вы можете весь год быть в простое.";
                pokazatel.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (newGoro == "Рыбы" || newGoro == "рыбы")
            {
                opisanie.Text = "Рыбы" + "\n 2022 год будет полон невероятных подарков судьбы: вам ждут увлекательные путешествия и открытия. Вы сможете почувствовать жизнь по-новому и расширить свои горизонты. В партнёрских отношениях будет царить гармония, но вам стоит обратить внимание на карьеру и решить все незаконченные вопросы.";
                pokazatel.Content = new Image { Source = "rebe.jpg" };
            }
            else if (newGoro == "Овен" || newGoro == "овен")
            {
                opisanie.Text = "Овен" + "\n 2022 год будет переломным периодом: вы поймете, что, то, к чему вы стремились все прошлые годы, уже может не иметь никакого значения. Вы обретете психологическую свободу и начнете слушать себя и свои интересы. Ваш круг общения может поменяться и возможно вы будете тяжело это переживать: но поверьте, ваши волнения не будут стоить прекрасного результата.";
                pokazatel.Content = new Image { Source = "oven.jpg" };
            }
            else if (newGoro == "Телец" || newGoro == "телец")
            {
                opisanie.Text = "Телец" + "\n В 2022 году будут на раздорожье: будет два варианта, по какой тропе свернуть. Это касается абсолютно каждой сферы жизни, где выбор будет между услышать сердце или послушать мозг. Какой делать выбор — это лишь ваше решение, но новый год точно не даст вам грустить или жалеть о чем-либо. Ожидайте успех в карьере и в партнерских отношениях.";
                pokazatel.Content = new Image { Source = "telec.jpg" };
            }
            else if (newGoro == "Близнецы" || newGoro == "близнецы")
            {
                opisanie.Text = "Близнецы" + "\n Этот год принесет удачу в здоровье: решаться все проблемы, которые сопутствовали более одного года. То же самое ждёт вашу семью: тотальные проблемы организмов испарятся, как будто их и не было. Но могут быть препятствия на работе: вам стоит подумать о том, насколько вам дорог карьерный рост и прибыль и понять, стоит ли менять сферу деятельности.";
                pokazatel.Content = new Image { Source = "bliznece.jpg" };
            }
            else if (newGoro == "Рак" || newGoro == "рак")
            {
                opisanie.Text = "Рак" + "\n Новый 2022 год принесет не только новые прекрасные знакомства, но и ударит их стрелой амура! У вас есть шанс либо найти новую любовь, с которой вы будете до конца жизни держаться за руки, либо прекратить все невзгоды с уже имеющимся партнёром. Произойдут изменения в характере: вы откроите в себе новые грани.";
                pokazatel.Content = new Image { Source = "rak.jpg" };
            }
            else if (newGoro == "Лев" || newGoro == "лев")
            {
                opisanie.Text = "Лев" + "\n 2022 год будет успешным в сфере бизнеса и карьеры. Ваша финансовая пирамида просто взорвется от всех успешных проектов! Вы будете поглощены разными идеями, которые точно получат хорошие отзывы. Можете точно ожидать повышения! Но при этом эти успехи могут потянуть за собой простой в других сферах жизни, старайтесь держать баланс. ";
                pokazatel.Content = new Image { Source = "lev.jpg" };
            }
            else if (newGoro == "Дева" || newGoro == "дева")
            {
                opisanie.Text = "Дева" + "\n В 2022 году должны быть осторожны со своими словами и действиями, так как в новом году вы можете сильно ранить близких. Это грозит уменьшением круга общения или даже одиночеством. Вам стоит переосмыслить ваше мнение касаемо окружения, а также обдумать поступки прошлого года. Однако уверяем: после вашего детального анализа черный водяной тигр точно подарит вам прекрасное настроение и невероятных людей рядом.";
                pokazatel.Content = new Image { Source = "deva.jpg" };
            }
            else if (newGoro == "Весы" || newGoro == "весы")
            {
                opisanie.Text = "Весы" + "\n  Стабильность — это ваше слово 2022 года. У вас будут абсолютно спокойные и приятные будни, какими они и были в 2021 году. Ваши родные будут счастливы и здоровы, старые друзья будут с вами, партнер будет любить вас, а вы будете любить его, а финансовая подушка будет более чем удовлетворительная. Это будет год-передышка: вам точно нужна такая перезагрузка.";
                pokazatel.Content = new Image { Source = "vese.jpg" };
            }
            else if (newGoro == "Козерог" || newGoro == "козерог")
            {
                opisanie.Text = "Скорпион" + "\n В этом году стоит задуматься над тем, чтобы открыть в себе новые таланты: возможно, вам нравится пение и танцы? Не стесняйтесь и начинайте новое хобби, ведь 2022 прогнозирует успех! В этом году не стоит себя ограничивать, беритесь за каждую возможность! Быть может, ваше новое начинание даже будет приносить прибыль и перерастет в масштабный бизнес.";
                pokazatel.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (newGoro == "Стрелец" || newGoro == "стрелец")
            {
                opisanie.Text = "Стрелец" + "\n Стоит уделить внимание своему здоровью: в 2022 году вам следует с особенной осторожностью относится к своему организму и пройти все необходимые осмотры. Вы часто пренебрегали этим, и самое время поменять свое мировоззрение. Однако уверяем, что в 2022 году вы точно будете прекрасно себя чувствовать, а рядом будет надежный партнер, который точно сделает вас счастливыми!";
                pokazatel.Content = new Image { Source = "strelec.jpg" };
            }
            else
            {
                opisanie.Text = "Нету такого, проверьте правильно вы ли написали знак зодика";
            }
        }

        private void Data_DateSelected(object sender, DateChangedEventArgs e)
        {
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;
            if (m==1 && d>=1 && d<=19 || m==12 && d>=22)
            {
                opisanie.Text = "Козерог"+ "\n 2022 год будет полон сюрпризов: произойдет то, чего вы никак не можете ожидать! Ветер перемен унесет вас далеко, так что вперед к новым приключениям! Вас могут заинтересовать такие сферы деятельности, как предприятие, журналистика или даже дизайн (вероятнее архитектуры). Можете смело двигаться вперед, ведь вас обязательно поддержат.";
                pokazatel.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (m == 1 && d >= 20 && d <= 31 || m == 2 && d >= 1 && d <= 18)
            {
                opisanie.Text = "Водолей"+ "\n В 2022 году у вас могут возникнуть финансовые трудности. Однако не спешите огорчаться: они временные и, если приложить достаточное количество усилий, из минуса вы сможете всего за пару месяцев выйти в жирный плюс. Но в случае, если вы не будете действовать и отправите всё на самотёк, вы можете весь год быть в простое.";
                pokazatel.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (m == 2 && d >= 19 && d <= 29 || m == 3 && d >= 1 && d <= 20)
            {
                opisanie.Text = "Рыбы" + "\n 2022 год будет полон невероятных подарков судьбы: вам ждут увлекательные путешествия и открытия. Вы сможете почувствовать жизнь по-новому и расширить свои горизонты. В партнёрских отношениях будет царить гармония, но вам стоит обратить внимание на карьеру и решить все незаконченные вопросы.";
                pokazatel.Content = new Image { Source = "rebe.jpg" };
            }
            else if (m == 3 && d >= 21 && d <= 31 || m == 4 && d >= 1 && d <= 19)
            {
                opisanie.Text = "Овен" + "\n 2022 год будет переломным периодом: вы поймете, что, то, к чему вы стремились все прошлые годы, уже может не иметь никакого значения. Вы обретете психологическую свободу и начнете слушать себя и свои интересы. Ваш круг общения может поменяться и возможно вы будете тяжело это переживать: но поверьте, ваши волнения не будут стоить прекрасного результата.";
                pokazatel.Content = new Image { Source = "oven.jpg" };
            }
            else if (m == 4 && d >= 21 && d <= 30 || m == 5 && d >= 1 && d <= 20)
            {
                opisanie.Text = "Телец" + "\n В 2022 году будут на раздорожье: будет два варианта, по какой тропе свернуть. Это касается абсолютно каждой сферы жизни, где выбор будет между услышать сердце или послушать мозг. Какой делать выбор — это лишь ваше решение, но новый год точно не даст вам грустить или жалеть о чем-либо. Ожидайте успех в карьере и в партнерских отношениях.";
                pokazatel.Content = new Image { Source = "telec.jpg" };
            }
            else if (m == 5 && d >= 21 && d <= 31 || m == 6 && d >= 1 && d <= 20)
            {
                opisanie.Text = "Близнецы" + "\n Этот год принесет удачу в здоровье: решаться все проблемы, которые сопутствовали более одного года. То же самое ждёт вашу семью: тотальные проблемы организмов испарятся, как будто их и не было. Но могут быть препятствия на работе: вам стоит подумать о том, насколько вам дорог карьерный рост и прибыль и понять, стоит ли менять сферу деятельности.";
                pokazatel.Content = new Image { Source = "bliznece.jpg" };
            }
            else if (m == 6 && d >= 21 && d <= 30 || m == 7 && d >= 1 && d <= 22)
            {
                opisanie.Text = "Рак" + "\n Новый 2022 год принесет не только новые прекрасные знакомства, но и ударит их стрелой амура! У вас есть шанс либо найти новую любовь, с которой вы будете до конца жизни держаться за руки, либо прекратить все невзгоды с уже имеющимся партнёром. Произойдут изменения в характере: вы откроите в себе новые грани.";
                pokazatel.Content = new Image { Source = "rak.jpg" };
            }
            else if (m == 7 && d >= 23 && d <= 31 || m == 8 && d >= 1 && d <= 22)
            {
                opisanie.Text = "Лев" + "\n 2022 год будет успешным в сфере бизнеса и карьеры. Ваша финансовая пирамида просто взорвется от всех успешных проектов! Вы будете поглощены разными идеями, которые точно получат хорошие отзывы. Можете точно ожидать повышения! Но при этом эти успехи могут потянуть за собой простой в других сферах жизни, старайтесь держать баланс. ";
                pokazatel.Content = new Image { Source = "lev.jpg" };
            }
            else if (m == 8 && d >= 23 && d <= 31 || m == 9 && d >= 1 && d <= 22)
            {
                opisanie.Text = "Дева" + "\n В 2022 году должны быть осторожны со своими словами и действиями, так как в новом году вы можете сильно ранить близких. Это грозит уменьшением круга общения или даже одиночеством. Вам стоит переосмыслить ваше мнение касаемо окружения, а также обдумать поступки прошлого года. Однако уверяем: после вашего детального анализа черный водяной тигр точно подарит вам прекрасное настроение и невероятных людей рядом.";
                pokazatel.Content = new Image { Source = "deva.jpg" };
            }
            else if (m == 9 && d >= 23 && d <= 30 || m == 10 && d >= 1 && d <= 22)
            {
                opisanie.Text = "Весы" + "\n  Стабильность — это ваше слово 2022 года. У вас будут абсолютно спокойные и приятные будни, какими они и были в 2021 году. Ваши родные будут счастливы и здоровы, старые друзья будут с вами, партнер будет любить вас, а вы будете любить его, а финансовая подушка будет более чем удовлетворительная. Это будет год-передышка: вам точно нужна такая перезагрузка.";
                pokazatel.Content = new Image { Source = "vese.jpg" };
            }
            else if (m == 10 && d >= 23 && d <= 31 || m == 11 && d >= 1 && d <= 21)
            {
                opisanie.Text = "Скорпион" + "\n В этом году стоит задуматься над тем, чтобы открыть в себе новые таланты: возможно, вам нравится пение и танцы? Не стесняйтесь и начинайте новое хобби, ведь 2022 прогнозирует успех! В этом году не стоит себя ограничивать, беритесь за каждую возможность! Быть может, ваше новое начинание даже будет приносить прибыль и перерастет в масштабный бизнес.";
                pokazatel.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (m == 11 && d >= 22 && d <= 30 || m == 12 && d >= 1 && d <= 21)
            {
                opisanie.Text = "Стрелец" + "\n Стоит уделить внимание своему здоровью: в 2022 году вам следует с особенной осторожностью относится к своему организму и пройти все необходимые осмотры. Вы часто пренебрегали этим, и самое время поменять свое мировоззрение. Однако уверяем, что в 2022 году вы точно будете прекрасно себя чувствовать, а рядом будет надежный партнер, который точно сделает вас счастливыми!";
                pokazatel.Content = new Image { Source = "strelec.jpg" };
            }
        }
    }
}