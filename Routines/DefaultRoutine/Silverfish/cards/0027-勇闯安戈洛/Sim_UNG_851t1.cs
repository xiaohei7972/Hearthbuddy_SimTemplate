using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_851t1 : SimTemplate //* 安戈洛卡牌包 Un'Goro Pack
//Add 5 <b>Journey to Un'Goro</b> cards to your hand.
//将五张<b>勇闯安戈洛</b>系列的卡牌置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}