using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：3 生命值：3
	//Gibbering Reject
	//残次聒噪怪
	//After your hero attacks, summon another Gibbering Reject.
	//在你的英雄攻击后，召唤另一个残次聒噪怪。
	class Sim_MIS_911 : SimTemplate
	{
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查是否是己方英雄攻击，且当前随从是残次聒噪怪
            if (own.own && own.handcard.card.nameCN == CardDB.cardNameCN.残次聒噪怪)
            {
                // 召唤另一个残次聒噪怪
                p.callKid(own.handcard.card, own.zonepos, own.own);
            }
        }
    }
}
