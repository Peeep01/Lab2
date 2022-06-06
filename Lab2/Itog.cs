using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Itog
    {
        public string chek(int varplayer1, int varplayer2 ) 
        { 
            //Сравнение и вывод итога
            if (varplayer1>0 && varplayer2>0)
            {
                if (varplayer1 > varplayer2)
                {
                    return ("Вы победили!");

                }
                if (varplayer1 < varplayer2)
                {
                    return ("Вы проиграли(");
                }
                if (varplayer1 == varplayer2)
                {
                    return "Ничья";
                }

            }
            return "Ошибка, программа не может выполнить команду";
        }

    }
}
