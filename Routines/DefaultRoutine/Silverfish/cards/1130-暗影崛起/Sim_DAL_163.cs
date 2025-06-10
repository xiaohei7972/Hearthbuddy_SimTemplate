using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_163 : SimTemplate //* 渡鸦信使 Messenger Raven
//<b>Battlecry:</b> <b>Discover</b> aMage minion.
//<b>战吼：</b><b>发现</b>一张法师随从牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own, true);
        }
    }
}