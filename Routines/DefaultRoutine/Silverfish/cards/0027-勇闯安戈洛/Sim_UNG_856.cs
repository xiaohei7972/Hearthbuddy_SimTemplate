using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_856 : SimTemplate //* 幻觉 Hallucination
//<b>Discover</b> a card from your opponent's class.
//<b>发现</b>一张你对手职业的卡牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardNameEN.thecoin, ownplay, true);
			p.owncarddraw--;
        }
    }
}