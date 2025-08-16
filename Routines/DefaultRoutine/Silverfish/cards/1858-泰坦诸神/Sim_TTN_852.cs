using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：2 攻击力：2 生命值：3
	//Noble Minibot
	//崇高的迷你机
	//<b>Magnetic</b>After this attacks,give a random minion in your hand +1/+1.
	//<b>磁力</b>。在本随从攻击后，随机使你手牌中的一张随从牌获得+1/+1。
	class Sim_TTN_852 : SimTemplate
	{
        public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
        {
			if (attacker.own)
			{
				foreach (Handmanager.Handcard handcard in p.owncards)
				{
					if (handcard.card.type == CardDB.cardtype.MOB)
					{
						handcard.addattack++;
						handcard.addHp++;
						p.anzOwnExtraAngrHp += 2;
						break;
					}
				}
			}
        }
		
	}
}
