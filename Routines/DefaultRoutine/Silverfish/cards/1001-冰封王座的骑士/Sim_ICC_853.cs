using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_853: SimTemplate //* 瓦拉纳王子 Prince Valanar
//<b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
//<b>战吼：</b>如果你的牌库里没有法力值消耗为（4）的牌，则获得<b>吸血</b>和<b>嘲讽</b>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.getDeckCardsForCost(4) == CardDB.cardIDEnum.None)
            {
                own.lifesteal = true;
                own.taunt = true;
                p.anzOwnTaunt++;
            }
        }
    }
}