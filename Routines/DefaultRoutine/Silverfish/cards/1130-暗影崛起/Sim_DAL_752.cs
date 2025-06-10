using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_752 : SimTemplate //* 耶比托·乔巴斯 Jepetto Joybuzz
//<b>Battlecry:</b> Draw 2 minions from your deck. Set their Attack, Health, and Cost to 1.
//<b>战吼：</b>从你的牌库中抽两张随从牌。将其攻击力，生命值和法力值消耗变为1。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
			p.drawACard(CardDB.cardNameEN.unknown, own.own);
                p.owncards[p.owncards.Count - 2].manacost = 1;
		}
	}
}