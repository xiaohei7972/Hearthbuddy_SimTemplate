using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_530 : SimTemplate //* 蒙面选手 Masked Contender
//<b>Battlecry:</b> If you control a_<b>Secret</b>, cast a <b>Secret</b> from_your deck.
//<b>战吼：</b>如果你控制一个<b>奥秘</b>，则从你的牌库中施放一个<b>奥秘</b>。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_289);
		}
	}
}