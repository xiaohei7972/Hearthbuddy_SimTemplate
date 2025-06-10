using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_201: SimTemplate //* 命运骨骰 Roll the Bones
//Draw a card.If it has <b>Deathrattle</b>, cast this again.
//抽一张牌。如果这张牌具有<b>亡语</b>，则再次施放该法术。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }
    }
}