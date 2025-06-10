using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_032b : SimTemplate //* 卡牌赠礼 Gift of Cards
//Each player draws a card.
//每个玩家抽一张牌。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, false);
           
        }


    }

}