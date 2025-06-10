using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：2 攻击力：2 生命值：2
	//Unlucky Powderman
	//倒霉的炸药师
	//<b>Taunt</b><b>Deathrattle:</b> Give <b>Taunt</b> minions in your hand and deck +1/+1.
	//<b>嘲讽</b>。<b>亡语：</b>使你手牌和牌库中的<b>嘲讽</b>随从牌获得+1/+1。
	class Sim_WW_367 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.tank)
                    {
                        hc.addattack++;
                        hc.addHp++;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
        }
		
	}
}
