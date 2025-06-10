using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_577 : SimTemplate //* 比斯巨兽 The Beast
	{
		//<b>Deathrattle:</b> Summon a 3/3 Finkle Einhorn for your opponent.
		//<b>亡语：</b>为你的对手召唤1个3/3的芬克·恩霍尔。

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_finkle);//finkleeinhorn
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int pos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(c, pos, !m.own);
        }
	}
}