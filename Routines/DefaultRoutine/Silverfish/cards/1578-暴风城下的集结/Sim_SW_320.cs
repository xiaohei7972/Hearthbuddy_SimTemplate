using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_320 : SimTemplate //* 硕鼠成群 Rats of Extraordinary Size
	{
		//[x]Summon seven 1/1Rats. Any that can't fiton the battlefield go toyour hand with +4/+4.
		//召唤七只1/1的老鼠。战场上放不下的老鼠会进入你的手牌，并获得+4/+4。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_455t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			//随从数
			int Count = p.ownMinions.Count;
			//随从空位数
			int DisCount = 7 - Count;
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			for (int i3 = 0; i3 < DisCount; i3++)
			{
				p.callKid(kid, pos, ownplay, false);
			}
			if(DisCount < 7)
            {

				for (int i5 = 0; i5 < Count; i5++)
			    {
					p.drawACard(CardDB.cardIDEnum.SW_455t, ownplay, true);
					Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestHP, GAME_TAGs.Mob);
					hc.addattack += 4;
					hc.addHp += 4;
				}
			}
		}

	}
}
