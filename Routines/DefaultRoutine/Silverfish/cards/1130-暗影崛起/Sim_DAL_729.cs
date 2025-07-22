using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_729 : SimTemplate //* 拉祖尔女士 Madame Lazul
//[x]<b>Battlecry:</b> <b>Discover</b> acopy of a card in youropponent's hand.
//<b>战吼：</b><b>发现</b>一张你的对手手牌的复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own, true);
        }
    }
}