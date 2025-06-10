using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：2 生命值：1
	//Elementium Geode
	//源质晶簇
	//<b>Battlecry and Deathrattle:</b>Draw a card. Deal 2 damage to your hero.
	//<b>战吼，亡语：</b>抽一张牌，并对你的英雄造成2点伤害。
	class Sim_DEEP_030 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
			p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 4);
		}

		public override void onDeathrattle(Playfield p, Minion m)		
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }


		
	}
}
