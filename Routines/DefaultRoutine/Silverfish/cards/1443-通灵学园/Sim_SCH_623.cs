using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_623 : SimTemplate //* 劈砍课程 Cutting Class
	{
		//[x]Draw 2 cards. Costs (1) less per Attack of your weapon.
		//抽两张牌。你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
        }
		
	}
}
