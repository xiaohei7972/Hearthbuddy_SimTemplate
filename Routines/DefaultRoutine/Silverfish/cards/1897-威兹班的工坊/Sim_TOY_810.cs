using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 圣骑士 费用：4 攻击力：2 耐久度：3
	//Painter's Virtue
	//画师的美德
	//[x]<b>Lifesteal</b>After your hero attacks,give minions in yourhand +1/+1.
	//<b>吸血</b>在你的英雄攻击后，使你手牌中的随从牌获得+1/+1。
	class Sim_TOY_810 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理武器的装备
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_810), ownplay);
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 在英雄攻击后，给予手牌中的随从牌+1/+1
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB) // 只对随从牌生效
                {
                    hc.addattack++;
                    hc.addHp++;
                }
            }
        }


    }
}
