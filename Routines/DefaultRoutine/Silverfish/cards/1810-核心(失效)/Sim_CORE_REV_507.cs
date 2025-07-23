using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：0
	//Dispose of Evidence
	//处理证据
	//Give your hero +3 Attack this turn. Choose a card in your hand to shuffle into your deck.
	//在本回合中，使你的英雄获得+3攻击力。选择一张你的手牌洗入你的牌库。
	class Sim_CORE_REV_507 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 3, 0);
            hero.updateReadyness();
			//TODO:洗手牌效果以后再想
		}
		
	}
}
