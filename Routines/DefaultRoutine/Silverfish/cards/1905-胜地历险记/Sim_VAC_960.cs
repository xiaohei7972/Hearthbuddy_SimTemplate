using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：3 攻击力：1 耐久度：2
	//Trusty Fishing Rod
	//可靠的鱼竿
	//[x]After your hero attacks, summona 1-Cost minionfrom your deck.
	//在你的英雄攻击后，从你的牌库中召唤一个法力值消耗为（1）的随从。
	class Sim_VAC_960 : SimTemplate
	{
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 从牌库中召唤一个法力值消耗为1的随从
            CardDB.Card kid = p.getRandomCardForManaMinion(1);
            p.callKid(kid, own.zonepos, own.own);
        }
    }
}
