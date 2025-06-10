using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：1 攻击力：1 生命值：1
	//Amateur Puppeteer
	//业余傀儡师
	//[x]<b>Mini</b>, <b>Taunt</b><b>Deathrattle:</b> Give Undeadin your hand +2/+2.
	//<b>微型</b><b>嘲讽</b>。<b>亡语：</b>使你手牌中的亡灵牌获得+2/+2。
	class Sim_TOY_828t : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 为手牌中的所有亡灵随从增加+2/+2
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if ((TAG_RACE)hc.card.race == TAG_RACE.UNDEAD) // 检查是否为亡灵种族
                {
                    hc.addattack += 2; // 增加攻击力
                    hc.addHp += 2; // 增加生命值
                }
            }
        }
    }
}
