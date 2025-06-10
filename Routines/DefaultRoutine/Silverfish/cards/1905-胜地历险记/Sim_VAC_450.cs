using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：3 攻击力：2 生命值：2
	//Carefree Cookie
	//悠闲的曲奇
	//[x]<b>Demon Hunter Tourist</b>After a friendly minion dies,summon a random minionthat costs (1) more.
	//<b>恶魔猎手游客</b>在一个友方随从死亡后，随机召唤一个法力值消耗增加（1）点的随从。
	class Sim_VAC_450 : SimTemplate
	{

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            // 检查死去的随从是否是友方随从
            if (diedMinion.own && m.own && m.silenced == false)
            {
                // 获取一个法力值消耗增加（1）点的随从
                int cost = diedMinion.handcard.card.cost + 1;
                CardDB.Card kid = p.getRandomCardForManaMinion(cost);

                // 召唤这个随从
                p.callKid(kid, p.ownMinions.Count, m.own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FROZEN_TARGET), // 冻结
            };
        }
    }
}
