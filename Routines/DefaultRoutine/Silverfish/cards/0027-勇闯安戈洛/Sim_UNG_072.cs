using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_072 : SimTemplate //* 石丘防御者 Stonehill Defender
//<b>Taunt</b><b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
//<b>嘲讽，战吼：</b><b>发现</b>一张具有<b>嘲讽</b>的随从牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.pompousthespian, own.own, true);
        }
    }
}