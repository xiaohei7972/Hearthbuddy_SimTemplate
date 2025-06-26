using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：3 生命值：5
	//Desert Nestmatron
	//沙漠巢母
	//<b>Taunt</b>. <b>Battlecry:</b> If you're holding a Dragon, refresh 4 Mana Crystals.
	//<b>嘲讽</b>。<b>战吼：</b>如果你的手牌中有龙牌，复原四个法力水晶。
	class Sim_WW_826 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			bool dragonInHand = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
				{
					dragonInHand = true;
					break;
				}
			}
			if (dragonInHand)
			{
				p.mana = Math.Max(p.ownMaxMana, p.mana + 4);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_OF_RACE_IN_HAND,24), //手牌里有龙
			};
		}

	}
}
