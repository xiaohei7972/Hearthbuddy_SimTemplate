using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：2 攻击力：1 耐久度：3
	//Remote Control
	//遥控器
	//After your hero attacks, summon a 1/1 Hound.
	//在你的英雄攻击后，召唤一只1/1的猎犬。
	class Sim_TOY_358 : SimTemplate
	{

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 召唤一只 1/1 的猎犬
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_358t), p.ownMinions.Count, own.own);
        }
    }
}
