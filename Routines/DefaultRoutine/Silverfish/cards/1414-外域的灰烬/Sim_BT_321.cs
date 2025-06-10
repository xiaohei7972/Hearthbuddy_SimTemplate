using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_321  : SimTemplate// BT_321  虚无行者
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice) //战吼：发现一张恶魔牌。
		{
			p.drawACard(CardDB.cardNameEN.unknown, own.own,true);
		}
	}
}