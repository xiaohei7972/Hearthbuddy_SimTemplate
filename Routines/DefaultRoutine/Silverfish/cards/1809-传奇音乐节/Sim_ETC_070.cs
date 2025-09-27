using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：4 攻击力：3 生命值：4
	//Crazed Conductor
	//疯狂的指挥
	//[x]<b>Battlecry:</b> Take Fatiguedamage. Summon thatmany 3/3 Imps.@[x]<b>Battlecry:</b> Take {0} Fatiguedamage. Summon thatmany 3/3 Imps.
	//<b>战吼：</b>受到疲劳伤害。召唤相同数量的3/3的小鬼。@<b>战吼：</b>受到{0}点疲劳伤害。召唤相同数量的3/3的小鬼。
	class Sim_ETC_070 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ETC_070t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.ownHeroFatigue++;
				p.ownHero.getDamageOrHeal(p.ownHeroFatigue, p, false, true);
				for (int i = 0; i < p.ownHeroFatigue; i++)
				{
					p.callKid(kid, own.zonepos, own.own);
				}
			}
			else
			{
				p.enemyHeroFatigue++;
				p.enemyHero.getDamageOrHeal(p.enemyHeroFatigue, p, false, true);
				for (int i = 0; i < p.enemyHeroFatigue; i++)
				{
					p.callKid(kid, own.zonepos, own.own);
				}
			}

		}
		
	}
}
