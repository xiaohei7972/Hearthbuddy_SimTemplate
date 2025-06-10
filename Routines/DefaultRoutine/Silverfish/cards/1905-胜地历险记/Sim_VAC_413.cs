using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：4 生命值：6
	//Ranger Gilly
	//园林护卫者基利
	//[x]<b>Warrior Tourist.</b> At the end ofyour turn, get a 2/3 Crocolisk.<b>Deathrattle:</b> Give all minionsin your hand +2/+3.
	//<b>战士游客</b>在你的回合结束时，获取一张2/3的鳄鱼。<b>亡语：</b>使你手牌中的所有随从牌获得+2/+3。
	class Sim_VAC_413 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 只在随从所有者的回合结束时触发
            if (turnEndOfOwner == m.own)
            {
                // 获取一张2/3的鳄鱼
                p.drawACard(CardDB.cardIDEnum.VAC_413t, m.own, true);
            }
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 当随从死亡时，给予手牌中的所有随从牌+2/+3
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB) // 判断是否是随从牌
                {
                    hc.addattack += 2;
                    hc.addHp += 3;
                }
            }
        }
    }
}
