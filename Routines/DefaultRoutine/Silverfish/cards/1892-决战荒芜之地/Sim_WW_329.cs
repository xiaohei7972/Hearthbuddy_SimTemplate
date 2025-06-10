using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：3 生命值：4
	//Detonation Juggernaut
	//机甲爆王
	//<b>Taunt</b>. <b>Battlecry:</b> Give <b>Taunt</b> minions in your hand +2/+2.
	//<b>嘲讽</b>。<b>战吼：</b>使你手牌中的<b>嘲讽</b>随从牌获得+2/+2。
	class Sim_WW_329 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {

                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.tank)
                    {
                        hc.addattack += 2;
                        hc.addHp += 2;
                        p.anzOwnExtraAngrHp += 4;
                    }
                }
            }
        }
    }
}
